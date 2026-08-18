using Microsoft.AspNetCore.Mvc;
using ApiFinalAsignatura.Models;
using System.Collections.Generic;

namespace ApiFinalAsignatura.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AcademicoController : ControllerBase
{
    private static List<PeriodoAcademico> _periodos = new();
    private static List<Asignatura> _asignaturas = new();
    private static List<Estudiante> _estudiantes = new();
    private static List<Inscripcion> _inscripciones = new();

    [HttpGet("periodos")] public IActionResult GetPeriodos() => Ok(_periodos);
    [HttpPost("periodos")] public IActionResult PostPeriodo([FromBody] PeriodoAcademico p) { p.Id = _periodos.Count + 1; _periodos.Add(p); return StatusCode(201, p); }

    [HttpGet("asignaturas")] public IActionResult GetAsignaturas() => Ok(_asignaturas);
    [HttpPost("asignaturas")] public IActionResult PostAsignatura([FromBody] Asignatura a) { a.Id = _asignaturas.Count + 1; _asignaturas.Add(a); return StatusCode(201, a); }

    [HttpGet("estudiantes")] public IActionResult GetEstudiantes() => Ok(_estudiantes);
    [HttpPost("estudiantes")] public IActionResult PostEstudiante([FromBody] Estudiante e) { e.Id = _estudiantes.Count + 1; _estudiantes.Add(e); return StatusCode(201, e); }

    [HttpGet("inscripciones")] public IActionResult GetInscripciones() => Ok(_inscripciones);
    [HttpPost("inscripciones")] public IActionResult PostInscripcion([FromBody] Inscripcion i) { i.Id = _inscripciones.Count + 1; _inscripciones.Add(i); return StatusCode(201, i); }
}
