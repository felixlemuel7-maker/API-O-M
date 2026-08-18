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
    public partial class CarrerasControl : UserControl
    {
        private readonly Color RojoError = ColorTranslator.FromHtml("#C0392B");
        private readonly Color VerdeExito = ColorTranslator.FromHtml("#2E8B57");
        private readonly Color AzulMarino = ColorTranslator.FromHtml("#0B2545");
        private readonly Color DoradoClaro = ColorTranslator.FromHtml("#E4C560");

        private static List<Carrera> Carreras => CarrerasRepositorio.Carreras;
        private int? _idSeleccionado = null; // null = modo "crear"

        public CarrerasControl()
        {
            InitializeComponent();
            ConfigurarGrid();
            CarrerasRepositorio.SembrarDatosDemo();
            RefrescarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvCarreras.ColumnHeadersDefaultCellStyle.BackColor = AzulMarino;
            dgvCarreras.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCarreras.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvCarreras.DefaultCellStyle.SelectionBackColor = DoradoClaro;
            dgvCarreras.DefaultCellStyle.SelectionForeColor = AzulMarino;
            dgvCarreras.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F8F9FB");

            dgvCarreras.Columns.Add("Id", "ID");
            dgvCarreras.Columns.Add("Codigo", "Código");
            dgvCarreras.Columns.Add("Nombre", "Nombre");
            dgvCarreras.Columns["Id"].FillWeight = 30;
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
            var carrera = new Carrera
            {
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim()
            };

            string error = carrera.Validar();
            if (!string.IsNullOrEmpty(error))
            {
                MostrarMensaje(error, esError: true);
                return;
            }

            if (_idSeleccionado == null)
            {
                carrera.Id = CarrerasRepositorio.ObtenerSiguienteId();
                Carreras.Add(carrera);
                MostrarMensaje($"Carrera '{carrera.Nombre}' creada correctamente.", esError: false);
            }
            else
            {
                var existente = Carreras.FirstOrDefault(c => c.Id == _idSeleccionado.Value);
                if (existente == null)
                {
                    MostrarMensaje("La carrera seleccionada ya no existe.", esError: true);
                    return;
                }
                existente.Codigo = carrera.Codigo;
                existente.Nombre = carrera.Nombre;
                MostrarMensaje($"Carrera '{existente.Nombre}' actualizada correctamente.", esError: false);
            }

            RefrescarGrid();
            LimpiarFormulario();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == null)
            {
                MostrarMensaje("Selecciona una carrera de la lista para eliminarla.", esError: true);
                return;
            }

            var existente = Carreras.FirstOrDefault(c => c.Id == _idSeleccionado.Value);
            if (existente == null) return;

            var confirmacion = MessageBox.Show(
                $"¿Deseas eliminar la carrera '{existente.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                Carreras.Remove(existente);
                MostrarMensaje($"Carrera '{existente.Nombre}' eliminada.", esError: false);
                RefrescarGrid();
                LimpiarFormulario();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void DgvCarreras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvCarreras.Rows[e.RowIndex];
            int id = Convert.ToInt32(fila.Cells["Id"].Value);
            var carrera = Carreras.FirstOrDefault(c => c.Id == id);
            if (carrera == null) return;

            _idSeleccionado = carrera.Id;
            txtCodigo.Text = carrera.Codigo;
            txtNombre.Text = carrera.Nombre;

            btnGuardar.Text = "Actualizar";
        }

        private void RefrescarGrid(string filtroNombre = "")
        {
            dgvCarreras.Rows.Clear();

            IEnumerable<Carrera> lista = Carreras;
            if (!string.IsNullOrWhiteSpace(filtroNombre))
            {
                lista = lista.Where(c => c.Nombre.Contains(filtroNombre, StringComparison.OrdinalIgnoreCase));
            }

            foreach (var c in lista.OrderBy(c => c.Nombre))
            {
                dgvCarreras.Rows.Add(c.Id, c.Codigo, c.Nombre);
            }
        }

        private void LimpiarFormulario()
        {
            _idSeleccionado = null;
            txtCodigo.Clear();
            txtNombre.Clear();
            btnGuardar.Text = "Guardar";
            dgvCarreras.ClearSelection();
        }

        private void MostrarMensaje(string texto, bool esError)
        {
            lblMensaje.Text = texto;
            lblMensaje.ForeColor = esError ? RojoError : VerdeExito;
        }
    }
}
