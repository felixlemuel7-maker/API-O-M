#nullable disable
using System.Collections.Generic;

namespace Periodoacademico26.Repositorios
{
    using Periodoacademico26;

    public static class InscripcionesRepositorio
    {
        public static List<Inscripcion> Inscripciones { get; } = [];

        private static int _siguienteId = 1;

        public static int ObtenerSiguienteId() => _siguienteId++;
    }
}
