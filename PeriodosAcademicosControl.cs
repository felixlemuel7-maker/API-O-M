#nullable disable
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Periodoacademico26.Repositorios;

namespace Periodoacademico26
{
    public partial class PeriodosAcademicosControl : UserControl
    {
        private readonly Color RojoError = ColorTranslator.FromHtml("#C0392B");
        private readonly Color VerdeExito = ColorTranslator.FromHtml("#2E8B57");
        private readonly Color AzulMarino = ColorTranslator.FromHtml("#0B2545");
        private readonly Color DoradoClaro = ColorTranslator.FromHtml("#E4C560");

        private int? _idSeleccionado = null; // null = modo "crear"

        public PeriodosAcademicosControl()
        {
            InitializeComponent();
            ConfigurarGrid();
            RefrescarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvPeriodos.ColumnHeadersDefaultCellStyle.BackColor = AzulMarino;
            dgvPeriodos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPeriodos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvPeriodos.DefaultCellStyle.SelectionBackColor = DoradoClaro;
            dgvPeriodos.DefaultCellStyle.SelectionForeColor = AzulMarino;
            dgvPeriodos.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F8F9FB");

            dgvPeriodos.Columns.Add("IdPeriodo", "ID");
            dgvPeriodos.Columns.Add("NombrePeriodo", "Nombre");
            dgvPeriodos.Columns.Add("TipoPeriodo", "Tipo");
            dgvPeriodos.Columns.Add("FechaInicio", "Fecha inicio");
            dgvPeriodos.Columns.Add("FechaFin", "Fecha fin");
            dgvPeriodos.Columns.Add("Estado", "Estado");
            dgvPeriodos.Columns["IdPeriodo"].FillWeight = 40;

            cmbTipoPeriodo.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            dtpFechaFin.Value = DateTime.Today.AddMonths(4);
        }

        private void Card_Paint(object sender, PaintEventArgs e)
        {
            var card = (Panel)sender;
            var rect = new Rectangle(0, 0, card.Width - 1, card.Height - 1);
            using var path = ObtenerRutaRedondeada(rect, 12);
            using var pen = new Pen(Color.Gainsboro);
            card.Region = new Region(path);
            e.Graphics.DrawPath(pen, path);
        }

        private static GraphicsPath ObtenerRutaRedondeada(Rectangle rect, int radio)
        {
            var path = new GraphicsPath();
            int d = radio * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Simula un placeholder (TextBox.PlaceholderText no existe en WinForms clásico)
        private void TxtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar por nombre...")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void TxtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar por nombre...";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.ForeColor == Color.Gray) return;
            RefrescarGrid(txtBuscar.Text);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtNombre.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var periodo = new PeriodoAcademico
            {
                NombrePeriodo = txtNombre.Text.Trim(),
                TipoPeriodo = cmbTipoPeriodo.SelectedItem?.ToString(),
                FechaInicio = dtpFechaInicio.Value.Date,
                FechaFin = dtpFechaFin.Value.Date,
                Estado = cmbEstado.SelectedItem?.ToString()
            };

            string error = periodo.Validar();
            if (!string.IsNullOrEmpty(error))
            {
                MostrarMensaje(error, esError: true);
                return;
            }

            try
            {
                if (_idSeleccionado == null)
                {
                    PeriodosRepositorio.Agregar(periodo);
                    MostrarMensaje($"Período '{periodo.NombrePeriodo}' creado correctamente.", esError: false);
                }
                else
                {
                    periodo.IdPeriodo = _idSeleccionado.Value;
                    PeriodosRepositorio.Actualizar(periodo);
                    MostrarMensaje($"Período '{periodo.NombrePeriodo}' actualizado correctamente.", esError: false);
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"No se pudo guardar en la base de datos: {ex.Message}", esError: true);
                return;
            }

            RefrescarGrid();
            LimpiarFormulario();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == null)
            {
                MostrarMensaje("Selecciona un período de la lista para eliminarlo.", esError: true);
                return;
            }

            var confirmacion = MessageBox.Show(
                "¿Deseas eliminar el período seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            try
            {
                PeriodosRepositorio.Eliminar(_idSeleccionado.Value);
                MostrarMensaje("Período eliminado.", esError: false);
                RefrescarGrid();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MostrarMensaje($"No se pudo eliminar: {ex.Message}", esError: true);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void DgvPeriodos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvPeriodos.Rows[e.RowIndex];
            int id = Convert.ToInt32(fila.Cells["IdPeriodo"].Value);

            var periodo = PeriodosRepositorio.ObtenerPorId(id);
            if (periodo == null) return;

            _idSeleccionado = periodo.IdPeriodo;
            txtNombre.Text = periodo.NombrePeriodo;
            cmbTipoPeriodo.SelectedItem = periodo.TipoPeriodo;
            dtpFechaInicio.Value = periodo.FechaInicio;
            dtpFechaFin.Value = periodo.FechaFin;
            cmbEstado.SelectedItem = periodo.Estado;

            btnGuardar.Text = "Actualizar";
        }

        private void RefrescarGrid(string filtroNombre = "")
        {
            dgvPeriodos.Rows.Clear();

            List<PeriodoAcademico> lista;
            try
            {
                lista = PeriodosRepositorio.ObtenerTodos(filtroNombre);
            }
            catch (Exception ex)
            {
                MostrarMensaje($"No se pudo conectar a la base de datos: {ex.Message}", esError: true);
                return;
            }

            foreach (var p in lista)
            {
                dgvPeriodos.Rows.Add(
                    p.IdPeriodo,
                    p.NombrePeriodo,
                    p.TipoPeriodo,
                    p.FechaInicio.ToShortDateString(),
                    p.FechaFin.ToShortDateString(),
                    p.Estado
                );
            }
        }

        private void LimpiarFormulario()
        {
            _idSeleccionado = null;
            txtNombre.Clear();
            cmbTipoPeriodo.SelectedIndex = 0;
            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaFin.Value = DateTime.Today.AddMonths(4);
            cmbEstado.SelectedIndex = 0;
            btnGuardar.Text = "Guardar";
            dgvPeriodos.ClearSelection();
        }

        private void MostrarMensaje(string texto, bool esError)
        {
            lblMensaje.Text = texto;
            lblMensaje.ForeColor = esError ? RojoError : VerdeExito;
        }
    }
}
