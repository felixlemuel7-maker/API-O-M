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
    public partial class InscripcionesControl : UserControl
    {
        private readonly Color RojoError = ColorTranslator.FromHtml("#C0392B");
        private readonly Color VerdeExito = ColorTranslator.FromHtml("#2E8B57");
        private readonly Color AzulMarino = ColorTranslator.FromHtml("#0B2545");
        private readonly Color DoradoClaro = ColorTranslator.FromHtml("#E4C560");

        // Estudiantes disponibles para el combo (mismo índice que cmbEstudiante.Items).
        private List<Estudiante> _estudiantesDisponibles = new();

        // Guardados del Paso 1 para usarlos al confirmar en el Paso 2.
        private Estudiante _estudianteSeleccionado;
        private string _carreraSeleccionada = "";
        private DateTime _fechaInscripcionSeleccionada = DateTime.Today;

        public InscripcionesControl()
        {
            InitializeComponent();
            ConfigurarGrid();
            CargarCarreras();
            AsignaturasRepositorio.SembrarDatosDemo();
            CargarEstudiantes();
            RefrescarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvInscripciones.ColumnHeadersDefaultCellStyle.BackColor = AzulMarino;
            dgvInscripciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInscripciones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvInscripciones.DefaultCellStyle.SelectionBackColor = DoradoClaro;
            dgvInscripciones.DefaultCellStyle.SelectionForeColor = AzulMarino;
            dgvInscripciones.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F8F9FB");

            dgvInscripciones.Columns.Add("Matricula", "Matrícula");
            dgvInscripciones.Columns.Add("Estudiante", "Estudiante");
            dgvInscripciones.Columns.Add("Carrera", "Carrera");
            dgvInscripciones.Columns.Add("FechaInscripcion", "Fecha inscripción");
            dgvInscripciones.Columns.Add("Periodo", "Período académico");
            dgvInscripciones.Columns.Add("Asignaturas", "Asignaturas inscritas");
        }

        /// <summary>
        /// PASO A PASO: si todavía no hay ningún estudiante registrado,
        /// no se puede continuar con la inscripción. Se bloquea el combo
        /// y el botón "Continuar" hasta que exista al menos un registro
        /// hecho en el módulo de Registro.
        /// </summary>
        private void CargarEstudiantes()
        {
            _estudiantesDisponibles = EstudiantesRepositorio.Estudiantes.ToList();

            cmbEstudiante.Items.Clear();
            foreach (var est in _estudiantesDisponibles)
            {
                string etiqueta = string.IsNullOrEmpty(est.Matricula)
                    ? est.NombreCompleto
                    : $"{est.NombreCompleto}  (Matrícula {est.Matricula})";
                cmbEstudiante.Items.Add(etiqueta);
            }

            bool hayEstudiantes = _estudiantesDisponibles.Count > 0;
            cmbEstudiante.Enabled = hayEstudiantes;
            cmbCarreraDeseada.Enabled = hayEstudiantes;
            dtpFechaInscripcion.Enabled = hayEstudiantes;
            btnContinuar.Enabled = hayEstudiantes;

            if (!hayEstudiantes)
            {
                MostrarMensaje("Debes completar tu registro primero en el módulo de Registro antes de poder inscribirte.", esError: true);
            }
        }

        private void CargarCarreras()
        {
            CarrerasRepositorio.SembrarDatosDemo();
            cmbCarreraDeseada.Items.Clear();
            cmbCarreraDeseada.Items.AddRange(CarrerasRepositorio.ObtenerNombres().ToArray());
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

        // ============================================================
        //  PASO 1: elegir estudiante, carrera y fecha de inscripción.
        //  Aquí es donde se le asigna la matrícula al estudiante, si
        //  todavía no tenía una (primera vez que se inscribe).
        // ============================================================
        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            if (cmbEstudiante.SelectedIndex == -1)
            {
                MostrarMensaje("Selecciona el estudiante que se va a inscribir.", esError: true);
                return;
            }

            if (cmbCarreraDeseada.SelectedItem == null)
            {
                MostrarMensaje("Selecciona la carrera que deseas estudiar.", esError: true);
                return;
            }

            var estudiante = _estudiantesDisponibles[cmbEstudiante.SelectedIndex];

            bool esPrimeraInscripcion = string.IsNullOrEmpty(estudiante.Matricula);
            if (esPrimeraInscripcion)
            {
                estudiante.Matricula = EstudiantesRepositorio.GenerarMatricula();
            }

            _estudianteSeleccionado = estudiante;
            _carreraSeleccionada = cmbCarreraDeseada.SelectedItem.ToString();
            _fechaInscripcionSeleccionada = dtpFechaInscripcion.Value.Date;

            lblResumen.Text = $"{estudiante.NombreCompleto} (Matrícula {estudiante.Matricula})  —  {_carreraSeleccionada}";

            var asignaturasPrimerCuatrimestre = AsignaturasRepositorio.Asignaturas
                .Where(a => a.Carrera == _carreraSeleccionada && a.Cuatrimestre == 1)
                .OrderBy(a => a.Nombre)
                .ToList();

            clbAsignaturas.Items.Clear();
            foreach (var asignatura in asignaturasPrimerCuatrimestre)
            {
                clbAsignaturas.Items.Add(asignatura.Nombre, isChecked: true);
            }

            if (esPrimeraInscripcion)
            {
                MostrarMensaje($"Se te asignó la matrícula {estudiante.Matricula}.", esError: false);
            }
            else if (asignaturasPrimerCuatrimestre.Count == 0)
            {
                MostrarMensaje($"Aún no hay asignaturas del primer cuatrimestre registradas para '{_carreraSeleccionada}'. Puedes inscribirte igual y agregarlas luego.", esError: true);
            }
            else
            {
                MostrarMensaje("", esError: false);
            }

            cardPaso1.Visible = false;
            cardPaso2.Visible = true;
        }

        // ============================================================
        //  PASO 2: elegir asignaturas y confirmar
        // ============================================================
        private void BtnAtras_Click(object sender, EventArgs e)
        {
            cardPaso2.Visible = false;
            cardPaso1.Visible = true;
        }

        private void BtnInscribir_Click(object sender, EventArgs e)
        {
            var asignaturasElegidas = clbAsignaturas.CheckedItems
                .Cast<object>()
                .Select(item => item.ToString())
                .ToList();

            PeriodoAcademico periodo;
            try
            {
                periodo = ObtenerPeriodoSegunFecha(_fechaInscripcionSeleccionada);
            }
            catch (Exception ex)
            {
                MostrarMensaje($"No se pudo consultar el período académico en la base de datos: {ex.Message}", esError: true);
                return;
            }

            var inscripcion = new Inscripcion
            {
                Id = InscripcionesRepositorio.ObtenerSiguienteId(),
                Matricula = _estudianteSeleccionado.Matricula,
                NombreEstudiante = _estudianteSeleccionado.NombreCompleto,
                Carrera = _carreraSeleccionada,
                FechaInscripcion = _fechaInscripcionSeleccionada,
                Periodo = periodo.NombrePeriodo,
                Asignaturas = asignaturasElegidas
            };

            InscripcionesRepositorio.Inscripciones.Add(inscripcion);
            RefrescarGrid();

            MostrarMensaje($"¡Listo! '{inscripcion.NombreEstudiante}' (Matrícula {inscripcion.Matricula}) quedó inscrito en '{inscripcion.Carrera}'. Según la fecha elegida ({inscripcion.FechaInscripcion:dd/MM/yyyy}), cayó en el período académico: {inscripcion.Periodo}.", esError: false);

            cardPaso2.Visible = false;
            cardPaso1.Visible = true;
            cmbEstudiante.SelectedIndex = -1;
            cmbCarreraDeseada.SelectedIndex = -1;
            dtpFechaInscripcion.Value = DateTime.Today;
            CargarEstudiantes(); // refresca las etiquetas del combo con la matrícula nueva
        }

        /// <summary>
        /// Todas las inscripciones se hacen siempre por Cuatrimestre (nunca
        /// Semestre ni Trimestre). El usuario elige la fecha de inscripción
        /// (por defecto hoy, pero se puede cambiar manualmente); el sistema
        /// calcula solo en cuál período Cuatrimestre activo cae esa fecha,
        /// según su rango FechaInicio–FechaFin. Si ninguno la cubre, crea
        /// uno nuevo automáticamente que sí la cubra, y queda registrado
        /// también en el módulo de Períodos Académicos.
        /// </summary>
        private static PeriodoAcademico ObtenerPeriodoSegunFecha(DateTime fechaInscripcion)
        {
            var periodoQueCorresponde = PeriodosRepositorio.ObtenerTodos()
                .Where(p => p.TipoPeriodo == "Cuatrimestre" && p.Estado == "Activo")
                .FirstOrDefault(p => fechaInscripcion >= p.FechaInicio && fechaInscripcion <= p.FechaFin);

            if (periodoQueCorresponde != null) return periodoQueCorresponde;

            var nuevoPeriodo = new PeriodoAcademico(
                0,
                $"Cuatrimestre {DeterminarNumeroDeCuatrimestre(fechaInscripcion)}-{fechaInscripcion.Year}",
                "Cuatrimestre",
                fechaInscripcion,
                fechaInscripcion.AddMonths(4),
                "Activo");

            nuevoPeriodo.IdPeriodo = PeriodosRepositorio.Agregar(nuevoPeriodo);
            return nuevoPeriodo;
        }

        /// <summary>
        /// Determina cuál de los 3 cuatrimestres del año corresponde según
        /// el mes de la fecha de inscripción (Ene-Abr = 1, May-Ago = 2,
        /// Sep-Dic = 3). Es solo para nombrar el período automáticamente.
        /// </summary>
        private static int DeterminarNumeroDeCuatrimestre(DateTime fecha)
        {
            if (fecha.Month <= 4) return 1;
            if (fecha.Month <= 8) return 2;
            return 3;
        }

        private void RefrescarGrid()
        {
            dgvInscripciones.Rows.Clear();

            foreach (var i in InscripcionesRepositorio.Inscripciones)
            {
                dgvInscripciones.Rows.Add(
                    i.Matricula,
                    i.NombreEstudiante,
                    i.Carrera,
                    i.FechaInscripcion.ToShortDateString(),
                    i.Periodo,
                    string.Join(", ", i.Asignaturas)
                );
            }
        }

        private void MostrarMensaje(string texto, bool esError)
        {
            lblMensaje.Text = texto;
            lblMensaje.ForeColor = esError ? RojoError : VerdeExito;
        }
    }
}
