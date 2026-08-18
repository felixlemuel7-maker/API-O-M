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
    public partial class AsignaturasControl : UserControl
    {
        private readonly Color RojoError = ColorTranslator.FromHtml("#C0392B");
        private readonly Color VerdeExito = ColorTranslator.FromHtml("#2E8B57");
        private readonly Color AzulMarino = ColorTranslator.FromHtml("#0B2545");
        private readonly Color DoradoClaro = ColorTranslator.FromHtml("#E4C560");

        private static List<Asignatura> Asignaturas => AsignaturasRepositorio.Asignaturas;
        private int? _idSeleccionado = null; // null = modo "crear"

        public AsignaturasControl()
        {
            InitializeComponent();
            ConfigurarGrid();
            CargarCarreras();
            AsignaturasRepositorio.SembrarDatosDemo();
            RefrescarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvAsignaturas.ColumnHeadersDefaultCellStyle.BackColor = AzulMarino;
            dgvAsignaturas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAsignaturas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvAsignaturas.DefaultCellStyle.SelectionBackColor = DoradoClaro;
            dgvAsignaturas.DefaultCellStyle.SelectionForeColor = AzulMarino;
            dgvAsignaturas.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F8F9FB");

            dgvAsignaturas.Columns.Add("Id", "ID");
            dgvAsignaturas.Columns.Add("Codigo", "Código");
            dgvAsignaturas.Columns.Add("Nombre", "Nombre");
            dgvAsignaturas.Columns.Add("Creditos", "Créditos");
            dgvAsignaturas.Columns.Add("Carrera", "Carrera");
            dgvAsignaturas.Columns.Add("Cuatrimestre", "Cuatrim.");
            dgvAsignaturas.Columns["Id"].FillWeight = 30;
        }

        private void CargarCarreras()
        {
            CarrerasRepositorio.SembrarDatosDemo();
            cmbCarrera.Items.Clear();
            cmbCarrera.Items.AddRange(CarrerasRepositorio.ObtenerNombres().ToArray());
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
            txtCodigo.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCreditos.Text.Trim(), out int creditos))
            {
                MostrarMensaje("Los créditos deben ser un número (ej. 3, 4).", esError: true);
                return;
            }

            if (!int.TryParse(txtCuatrimestre.Text.Trim(), out int cuatrimestre))
            {
                MostrarMensaje("El cuatrimestre debe ser un número (ej. 1, 2, 3).", esError: true);
                return;
            }

            var asignatura = new Asignatura
            {
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Creditos = creditos,
                Carrera = cmbCarrera.SelectedItem?.ToString(),
                Cuatrimestre = cuatrimestre
            };

            string error = asignatura.Validar();
            if (!string.IsNullOrEmpty(error))
            {
                MostrarMensaje(error, esError: true);
                return;
            }

            if (_idSeleccionado == null)
            {
                asignatura.Id = AsignaturasRepositorio.ObtenerSiguienteId();
                Asignaturas.Add(asignatura);
                MostrarMensaje($"Asignatura '{asignatura.Nombre}' creada correctamente.", esError: false);
            }
            else
            {
                var existente = Asignaturas.FirstOrDefault(a => a.Id == _idSeleccionado.Value);
                if (existente == null)
                {
                    MostrarMensaje("La asignatura seleccionada ya no existe.", esError: true);
                    return;
                }
                existente.Codigo = asignatura.Codigo;
                existente.Nombre = asignatura.Nombre;
                existente.Creditos = asignatura.Creditos;
                existente.Carrera = asignatura.Carrera;
                existente.Cuatrimestre = asignatura.Cuatrimestre;
                MostrarMensaje($"Asignatura '{existente.Nombre}' actualizada correctamente.", esError: false);
            }

            RefrescarGrid();
            LimpiarFormulario();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == null)
            {
                MostrarMensaje("Selecciona una asignatura de la lista para eliminarla.", esError: true);
                return;
            }

            var existente = Asignaturas.FirstOrDefault(a => a.Id == _idSeleccionado.Value);
            if (existente == null) return;

            var confirmacion = MessageBox.Show(
                $"¿Deseas eliminar la asignatura '{existente.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                Asignaturas.Remove(existente);
                MostrarMensaje($"Asignatura '{existente.Nombre}' eliminada.", esError: false);
                RefrescarGrid();
                LimpiarFormulario();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void DgvAsignaturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvAsignaturas.Rows[e.RowIndex];
            int id = Convert.ToInt32(fila.Cells["Id"].Value);
            var asignatura = Asignaturas.FirstOrDefault(a => a.Id == id);
            if (asignatura == null) return;

            _idSeleccionado = asignatura.Id;
            txtCodigo.Text = asignatura.Codigo;
            txtNombre.Text = asignatura.Nombre;
            txtCreditos.Text = asignatura.Creditos.ToString();
            cmbCarrera.SelectedItem = asignatura.Carrera;
            txtCuatrimestre.Text = asignatura.Cuatrimestre.ToString();

            btnGuardar.Text = "Actualizar";
        }

        private void RefrescarGrid(string filtroNombre = "")
        {
            dgvAsignaturas.Rows.Clear();

            IEnumerable<Asignatura> lista = Asignaturas;
            if (!string.IsNullOrWhiteSpace(filtroNombre))
            {
                lista = lista.Where(a => a.Nombre.Contains(filtroNombre, StringComparison.OrdinalIgnoreCase));
            }

            foreach (var a in lista.OrderBy(a => a.Nombre))
            {
                dgvAsignaturas.Rows.Add(a.Id, a.Codigo, a.Nombre, a.Creditos, a.Carrera, a.Cuatrimestre);
            }
        }

        private void LimpiarFormulario()
        {
            _idSeleccionado = null;
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCreditos.Clear();
            cmbCarrera.SelectedIndex = -1;
            txtCuatrimestre.Text = "1";
            btnGuardar.Text = "Guardar";
            dgvAsignaturas.ClearSelection();
        }

        private void MostrarMensaje(string texto, bool esError)
        {
            lblMensaje.Text = texto;
            lblMensaje.ForeColor = esError ? RojoError : VerdeExito;
        }
    }
}
