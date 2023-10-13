using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class UniversidadesController : ControllerBase
    {
        private readonly ILogger<UniversidadesController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public UniversidadesController(
            ILogger<UniversidadesController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear universidades
        [Route("{idUniversidad}")]
        [HttpPost]
        public IActionResult PostUniversidad(
            [FromBody] Universidad universidad)
        {
            _aplicacionContexto.Universidad.Add(universidad);
            _aplicacionContexto.SaveChanges();
            return Ok(universidad);
        }
        //READ: Obtener lista de universidades
        [Route("{idUniversidad}")]
        [HttpGet]
        public IEnumerable<Universidad> GetUniversidad()
        {
            return _aplicacionContexto.Universidad.ToList();
        }
        //Update: Modificar universidades
        [Route("{idUniversidad}")]
        [HttpPut]
        public IActionResult PutUniversadad([FromBody] Universidad universidad)
        {
            _aplicacionContexto.Universidad.Update(universidad);
            _aplicacionContexto.SaveChanges();
            return Ok(universidad);
        }
        //Delete: Eliminar universidades
        [Route("{idUniversidad}")]
        [HttpDelete]
        public IActionResult DeleteUniversidad(int universidadID)
        {
            _aplicacionContexto.Universidad.Remove(
                _aplicacionContexto.Universidad.ToList()
                .Where(x => x.idUniversidad == universidadID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(universidadID);
        }
    }
}
