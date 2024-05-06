using Microsoft.AspNetCore.Mvc;

using TFGBackend.Data;
using TFGBackend.Models;
using TFGBackend.Business;

namespace TFGBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SesionController : ControllerBase
    {
        private readonly ISesionService _sesionService;

        public SesionController(ISesionService sesionService)
        {
            _sesionService = sesionService;
        }

        [HttpGet]
        public ActionResult<List<Sesion>> GetAll() =>
            _sesionService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Sesion> Get(int id)
        {
            var sesion = _sesionService.Get(id);

            if (sesion == null)
                return NotFound();

            return sesion;
        }

        [HttpPost]
        public IActionResult Create(Sesion sesion)
        {
            _sesionService.Add(sesion);
            return CreatedAtAction(nameof(Get), new { id = sesion.IdSesion }, sesion);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Sesion sesion)
        {
            if (id != sesion.IdSesion)
                return BadRequest();

            try
            {
                _sesionService.Update(sesion);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var sesion = _sesionService.Get(id);

            if (sesion is null)
                return NotFound();

            _sesionService.Delete(id);

            return NoContent();
        }
    }
}