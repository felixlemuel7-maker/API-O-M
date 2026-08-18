#nullable disable
using System.Collections.Generic;

namespace Periodoacademico26.Repositorios
{
    using Periodoacademico26;

    /// <summary>
    /// Guarda las asignaturas en memoria, compartidas entre módulos
    /// (misma idea que PeriodosRepositorio y EstudiantesRepositorio).
    /// </summary>
    public static class AsignaturasRepositorio
    {
        public static List<Asignatura> Asignaturas { get; } = [];

        private static int _siguienteId = 1;

        public static int ObtenerSiguienteId() => _siguienteId++;

        /// <summary>
        /// Datos de ejemplo (varias asignaturas, varios cuatrimestres,
        /// varias carreras), solo la primera vez que se usa el repositorio.
        /// </summary>
        public static void SembrarDatosDemo()
        {
            if (Asignaturas.Count > 0) return;

            // Ingeniería en Sistemas
            Asignaturas.Add(new Asignatura(ObtenerSiguienteId(), "ISIS-101", "Introducción a la Programación", 4, "Ingeniería en Sistemas", 1));
            Asignaturas.Add(new Asignatura(ObtenerSiguienteId(), "MAT-101", "Matemática I", 4, "Ingeniería en Sistemas", 1));
            Asignaturas.Add(new Asignatura(ObtenerSiguienteId(), "LESP-101", "Lengua Española I", 3, "Ingeniería en Sistemas", 1));
            Asignaturas.Add(new Asignatura(ObtenerSiguienteId(), "ISIS-102", "Estructura de Datos", 4, "Ingeniería en Sistemas", 2));

            // Contabilidad
            Asignaturas.Add(new Asignatura(ObtenerSiguienteId(), "CONT-101", "Contabilidad I", 4, "Contabilidad", 1));
            Asignaturas.Add(new Asignatura(ObtenerSiguienteId(), "MATF-101", "Matemática Financiera", 3, "Contabilidad", 1));
            Asignaturas.Add(new Asignatura(ObtenerSiguienteId(), "CONT-102", "Contabilidad II", 4, "Contabilidad", 2));

            // Derecho
            Asignaturas.Add(new Asignatura(ObtenerSiguienteId(), "DER-101", "Introducción al Derecho", 4, "Derecho", 1));
            Asignaturas.Add(new Asignatura(ObtenerSiguienteId(), "DER-102", "Derecho Constitucional", 4, "Derecho", 1));
        }
    }
}
