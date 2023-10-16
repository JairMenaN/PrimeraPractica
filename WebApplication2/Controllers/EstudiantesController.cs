using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudiantesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<EstudiantesController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public EstudiantesController(
            ILogger<EstudiantesController> logger, 
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        [HttpPost(Name = "GetEstudiante")]
        public IActionResult Post(
            [FromBody] Estudiante estudiante)
        {
            _aplicacionContexto.Add(estudiante);
            _aplicacionContexto.SaveChanges();
            return Ok(estudiante);
        }
        //READ: Obtener lista de estudiantes
        [HttpGet(Name = "GetEstudiante")]
        public IEnumerable<Estudiante> Get()
        {
            return null;
        }
        //Update: Modificar estudiantes
        [HttpPut(Name = "GetEstudiante")]
        public IEnumerable<Estudiante> Put()
        {
            return null;
        }
        //Delete: Eliminar estudiantes
        [HttpDelete(Name = "GetEstudiante")]
        public IEnumerable<Estudiante> Delete()
        {
            return null;
        }
    }
}