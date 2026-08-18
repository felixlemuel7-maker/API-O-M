#nullable disable

namespace Periodoacademico26
{
    /// <summary>
    /// Representa una asignatura (materia) que pertenece a una carrera.
    /// Basado en la clase "Materias" del módulo original del equipo
    /// (getCodigo/getNombre/getCreditos), pero como propiedades de C#.
    /// </summary>
    public class Asignatura
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = "";
        public string Nombre { get; set; } = "";
        public int Creditos { get; set; }
        public string Carrera { get; set; } = "";
        public int Cuatrimestre { get; set; } = 1;

        public Asignatura() { }

        public Asignatura(int id, string codigo, string nombre, int creditos, string carrera, int cuatrimestre)
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Creditos = creditos;
            Carrera = carrera;
            Cuatrimestre = cuatrimestre;
        }

        /// <summary>
        /// Devuelve un mensaje de error vacío cuando los datos son válidos.
        /// </summary>
        public string Validar()
        {
            if (string.IsNullOrWhiteSpace(Codigo))
                return "El código de la asignatura es obligatorio.";

            if (string.IsNullOrWhiteSpace(Nombre))
                return "El nombre de la asignatura es obligatorio.";

            if (Creditos <= 0)
                return "Los créditos deben ser un número mayor a cero.";

            if (Cuatrimestre <= 0)
                return "El cuatrimestre debe ser un número mayor a cero.";

            if (string.IsNullOrWhiteSpace(Carrera))
                return "Debe seleccionar la carrera a la que pertenece.";

            return string.Empty;
        }
    }
}
