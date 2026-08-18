#nullable disable
using System;
using System.Collections.Generic;

namespace Periodoacademico26.Repositorios
{
    using Periodoacademico26;

    /// <summary>
    /// Guarda los estudiantes registrados en memoria mientras el
    /// programa está abierto. Cuando el módulo de Estudiantes tenga su
    /// propia pantalla de consulta/listado, puede leer de aquí mismo.
    /// </summary>
    public static class EstudiantesRepositorio
    {
        public static List<Estudiante> Estudiantes { get; } = [];

        private static int _siguienteMatricula = 1;

        /// <summary>
        /// Genera una matrícula con formato AÑO-0001 (secuencial por
        /// cada estudiante registrado, sin repetirse).
        /// </summary>
        public static string GenerarMatricula()
        {
            return $"{DateTime.Today.Year}-{(_siguienteMatricula++):D4}";
        }
    }
}
