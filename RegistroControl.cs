#nullable disable
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Periodoacademico26.Repositorios;

namespace Periodoacademico26
{
    public partial class RegistroControl : UserControl
    {
        private readonly Color RojoError = ColorTranslator.FromHtml("#C0392B");
        private readonly Color VerdeExito = ColorTranslator.FromHtml("#2E8B57");

        public RegistroControl()
        {
            InitializeComponent();
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

        /// <summary>
        /// Formatea la cédula automáticamente como 000-0000000-0
        /// mientras el usuario escribe.
        /// </summary>
        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {
            string numeros = txtCedula.Text.Replace("-", "");
            numeros = new string(Array.FindAll(numeros.ToCharArray(), char.IsDigit));

            if (numeros.Length > 11)
                numeros = numeros.Substring(0, 11);

            string cedula;
            if (numeros.Length > 3)
            {
                cedula = numeros.Substring(0, 3) + "-";
                cedula += numeros.Length > 10
                    ? numeros.Substring(3, 7) + "-" + numeros.Substring(10)
                    : numeros.Substring(3);
            }
            else
            {
                cedula = numeros;
            }

            txtCedula.TextChanged -= TxtCedula_TextChanged;
            txtCedula.Text = cedula;
            txtCedula.SelectionStart = txtCedula.Text.Length;
            txtCedula.TextChanged += TxtCedula_TextChanged;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" ||
                txtApellido.Text.Trim() == "" ||
                txtCorreo.Text.Trim() == "" ||
                txtContra.Text == "" ||
                txtCedula.Text.Trim() == "")
            {
                MostrarMensaje("Debe completar todos los campos.", esError: true);
                return;
            }

            if (!txtCorreo.Text.Trim().EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                MostrarMensaje("Debe ingresar un correo válido de Gmail.", esError: true);
                txtCorreo.Focus();
                return;
            }

            var estudiante = new Estudiante
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Contrasena = txtContra.Text,
                Cedula = txtCedula.Text.Trim()
            };

            EstudiantesRepositorio.Estudiantes.Add(estudiante);

            MostrarMensaje($"Estudiante '{estudiante.NombreCompleto}' registrado correctamente. Ve al módulo de Inscripciones para inscribirte y obtener tu matrícula.", esError: false);
            LimpiarFormulario();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtCorreo.Clear();
            txtContra.Clear();
            txtNombre.Focus();
        }

        private void MostrarMensaje(string texto, bool esError)
        {
            lblMensaje.Text = texto;
            lblMensaje.ForeColor = esError ? RojoError : VerdeExito;
        }
    }
}
