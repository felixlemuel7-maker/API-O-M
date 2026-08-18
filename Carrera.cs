#nullable disable

namespace Periodoacademico26
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = "";
        public string Nombre { get; set; } = "";

        public Carrera() { }

        public Carrera(int id, string codigo, string nombre)
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
        }

        public string Validar()
        {
            if (string.IsNullOrWhiteSpace(Codigo))
                return "El código de la carrera es obligatorio.";

            if (string.IsNullOrWhiteSpace(Nombre))
                return "El nombre de la carrera es obligatorio.";

            return string.Empty;
        }
    }
}
