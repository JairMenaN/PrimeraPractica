using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocentesController:ControllerBase
    {
        private readonly ILogger<DocentesController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public DocentesController(
            ILogger<DocentesController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear docente
        [Route("{idDocente}")]
        [HttpPost]
        public IActionResult PostDocente(
            [FromBody] Docente docente)
        {
            _aplicacionContexto.Docente.Add(docente);
            _aplicacionContexto.SaveChanges();
            return Ok(docente);
        }
        //READ: Obtener lista de docentes
        [Route("{idDocente}")]
        [HttpGet]
        public IEnumerable<Docente> GetDocente()
        {
            return _aplicacionContexto.Docente.ToList();
        }
        //Update: Modificar docentes
        [Route("{idDocente}")]
        [HttpPut]
        public IActionResult PutDocente([FromBody] Docente docente)
        {
            _aplicacionContexto.Docente.Update(docente);
            _aplicacionContexto.SaveChanges();
            return Ok(docente);
        }
        //Delete: Eliminar docentes
        [Route("{idDocente}")]
        [HttpDelete]
        public IActionResult DeleteDocente(int docenteID)
        {
            _aplicacionContexto.Docente.Remove(
                _aplicacionContexto.Docente.ToList()
                .Where(x => x.idDocente == docenteID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(docenteID);
        }
    }
}
