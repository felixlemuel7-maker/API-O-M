#nullable disable
using System.Collections.Generic;
using System.Linq;

namespace Periodoacademico26.Repositorios
{
    using Periodoacademico26;

    public static class CarrerasRepositorio
    {
        public static List<Carrera> Carreras { get; } = [];

        private static int _siguienteId = 1;

        public static int ObtenerSiguienteId() => _siguienteId++;

        public static List<string> ObtenerNombres()
        {
            return Carreras.Select(c => c.Nombre).ToList();
        }

        /// <summary>
        /// Datos de ejemplo, solo la primera vez que se usa el repositorio.
        /// </summary>
        public static void SembrarDatosDemo()
        {
            if (Carreras.Count > 0) return;

            Carreras.Add(new Carrera(ObtenerSiguienteId(), "ISIS", "Ingeniería en Sistemas"));
            Carreras.Add(new Carrera(ObtenerSiguienteId(), "CONT", "Contabilidad"));
            Carreras.Add(new Carrera(ObtenerSiguienteId(), "DER", "Derecho"));
            Carreras.Add(new Carrera(ObtenerSiguienteId(), "ADM", "Administración de Empresas"));
            Carreras.Add(new Carrera(ObtenerSiguienteId(), "PSIC", "Psicología"));
        }
    }
}
