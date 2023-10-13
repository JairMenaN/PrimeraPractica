using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudiantesController : ControllerBase
    {
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
        [Route("{idEstudiante}")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Estudiante estudiante)
        {
            _aplicacionContexto.Estudiante.Add(estudiante);
            _aplicacionContexto.SaveChanges();
            return Ok(estudiante);
        }
        //READ: Obtener lista de estudiantes
        [Route("{idEstudiante}")]
        [HttpGet]
        public IEnumerable<Estudiante> Get()
        {
            return _aplicacionContexto.Estudiante.ToList();
        }
        //Update: Modificar estudiantes
        [Route("{idEstudiante}")]
        [HttpPut]
        public IActionResult Put([FromBody] Estudiante estudiante)
        {
            _aplicacionContexto.Estudiante.Update(estudiante);
            _aplicacionContexto.SaveChanges();
            return Ok(estudiante);
        }
        //Delete: Eliminar estudiantes
        [Route("{idEstudiante}")]
        [HttpDelete]
        public IActionResult Delete(int estudianteID)
        {
            _aplicacionContexto.Estudiante.Remove(
                _aplicacionContexto.Estudiante.ToList()
                .Where(x=>x.idEstudiante== estudianteID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(estudianteID);
        }
    }
}