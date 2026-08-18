#nullable disable

namespace Periodoacademico26
{
    /// <summary>
    /// Datos de la cuenta del estudiante. La carrera, el período y las
    /// asignaturas se manejan en el módulo de Inscripciones, no aquí.
    /// </summary>
    public class Estudiante
    {
        public string Matricula { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string Correo { get; set; } = "";
        public string Contrasena { get; set; } = "";
        public string Cedula { get; set; } = "";

        public string NombreCompleto => $"{Nombre} {Apellido}".Trim();
    }
}
