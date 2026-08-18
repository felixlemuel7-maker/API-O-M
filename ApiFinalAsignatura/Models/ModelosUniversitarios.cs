namespace ApiFinalAsignatura.Models;

public class PeriodoAcademico { public int Id { get; set; } public string Codigo { get; set; } = ""; public string Descripcion { get; set; } = ""; public bool Estado { get; set; } = true; }
public class Asignatura { public int Id { get; set; } public string Codigo { get; set; } = ""; public string Nombre { get; set; } = ""; public int Creditos { get; set; } public string Carrera { get; set; } = ""; }
public class Estudiante { public int Id { get; set; } public string Matricula { get; set; } = ""; public string Nombres { get; set; } = ""; public string Apellidos { get; set; } = ""; public string Correo { get; set; } = ""; public string Carrera { get; set; } = ""; public string Estado { get; set; } = "Activo"; }
public class Inscripcion { public int Id { get; set; } public string MatriculaEstudiante { get; set; } = ""; public string CodigoAsignatura { get; set; } = ""; public string Periodo { get; set; } = ""; public System.DateTime FechaRegistro { get; set; } = System.DateTime.UtcNow; }
