#nullable disable
using System;

namespace Periodoacademico26
{
    /// <summary>
    /// Representa un período académico en el cual los estudiantes pueden
    /// realizar sus inscripciones (semestre, cuatrimestre o trimestre).
    /// </summary>
    public class PeriodoAcademico
    {
        public int IdPeriodo { get; set; }
        public string NombrePeriodo { get; set; }
        public string TipoPeriodo { get; set; } // Semestre, Cuatrimestre, Trimestre
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; } // Activo / Inactivo

        public PeriodoAcademico() { }

        public PeriodoAcademico(int idPeriodo, string nombrePeriodo, string tipoPeriodo,
                                 DateTime fechaInicio, DateTime fechaFin, string estado)
        {
            IdPeriodo = idPeriodo;
            NombrePeriodo = nombrePeriodo;
            TipoPeriodo = tipoPeriodo;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Estado = estado;
        }

        /// <summary>
        /// Devuelve un mensaje de error vacío cuando los datos son válidos.
        /// </summary>
        public string Validar()
        {
            if (string.IsNullOrWhiteSpace(NombrePeriodo))
                return "El nombre del período es obligatorio.";

            if (string.IsNullOrWhiteSpace(TipoPeriodo))
                return "Debe seleccionar el tipo de período.";

            if (FechaFin <= FechaInicio)
                return "La fecha de finalización debe ser posterior a la fecha de inicio.";

            if (string.IsNullOrWhiteSpace(Estado))
                return "Debe seleccionar el estado del período.";

            return string.Empty;
        }

        public override string ToString()
        {
            return $"{NombrePeriodo} ({TipoPeriodo}) - {Estado}";
        }
    }
}
