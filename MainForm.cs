#nullable disable
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Periodoacademico26
{
    public partial class MainForm : Form
    {
        private readonly Color AzulMarinoClaro = ColorTranslator.FromHtml("#13315C");
        private readonly Color Dorado = ColorTranslator.FromHtml("#C9A227");

        public MainForm()
        {
            InitializeComponent();
            MostrarModulo(navPeriodos);
        }

        private void PanelLogo_Paint(object sender, PaintEventArgs e)
        {
            using var brush = new SolidBrush(AzulMarinoClaro);
            e.Graphics.FillEllipse(brush, 70, 15, 90, 90);
            using var pen = new Pen(Dorado, 2);
            e.Graphics.DrawEllipse(pen, 70, 15, 90, 90);
        }

        private void NavItem_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = AzulMarinoClaro;
        }

        private void NavItem_MouseLeave(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            if (lbl != UltimoSeleccionado)
            {
                lbl.BackColor = Color.Transparent;
            }
        }

        private Label UltimoSeleccionado;

        private void NavItem_Click(object sender, EventArgs e)
        {
            MostrarModulo((Label)sender);
        }

        private void MostrarModulo(Label itemMenu)
        {
            // Resalta el ítem activo en el menú
            foreach (Control control in panelSidebar.Controls)
            {
                if (control is Label lbl)
                {
                    lbl.BackColor = Color.Transparent;
                }
            }
            itemMenu.BackColor = AzulMarinoClaro;
            UltimoSeleccionado = itemMenu;

            // Intercambia el contenido según el módulo elegido.
            // Cada compañero debe agregar aquí su propio "case" cuando
            // termine de convertir su Form en UserControl.
            panelContenido.Controls.Clear();

            UserControl moduloActivo = itemMenu.Tag?.ToString() switch
            {
                // 1. Inscripciones (ya integrado)
                "Inscripciones" => new InscripcionesControl(),
                // 2. Registro (ya integrado)
                "Registro" => new RegistroControl(),
                // 3. Carreras (ya integrado)
                "Carreras" => new CarrerasControl(),
                // 4. Asignaturas (ya integrado)
                "Asignaturas" => new AsignaturasControl(),
                // 5. Períodos (tu módulo, ya integrado)
                "Periodos" => new PeriodosAcademicosControl(),
                _ => CrearModuloPendiente(itemMenu.Text.Trim())
            };

            moduloActivo.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(moduloActivo);
        }

        /// <summary>
        /// Marcador de posición para los módulos que el equipo aún no
        /// ha integrado. Cuando un compañero entregue su UserControl,
        /// reemplaza el "case" correspondiente en MostrarModulo().
        /// </summary>
        private static UserControl CrearModuloPendiente(string nombreModulo)
        {
            var contenedor = new UserControl { Dock = DockStyle.Fill, BackColor = ColorTranslator.FromHtml("#F4F6F9") };
            var lbl = new Label
            {
                Text = $"Módulo \"{nombreModulo}\" aún no integrado por el equipo.",
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12F),
                ForeColor = Color.Gray
            };
            contenedor.Controls.Add(lbl);
            return contenedor;
        }
    }
}
