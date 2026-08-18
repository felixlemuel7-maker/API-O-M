#nullable disable
using System;
using System.Collections.Generic;

namespace Periodoacademico26
{
    /// <summary>
    /// Representa la inscripción de un estudiante a una carrera, con las
    /// asignaturas del primer cuatrimestre y el período académico
    /// (siempre de tipo "Cuatrimestre") en el que cae según la fecha
    /// de inscripción.
    /// </summary>
    public class Inscripcion
    {
        public int Id { get; set; }
        public string Matricula { get; set; } = "";
        public string NombreEstudiante { get; set; } = "";
        public string Carrera { get; set; } = "";
        public DateTime FechaInscripcion { get; set; } = DateTime.Today;
        public string Periodo { get; set; } = "";
        public List<string> Asignaturas { get; set; } = [];
    }
}
