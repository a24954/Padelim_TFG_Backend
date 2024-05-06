using Microsoft.AspNetCore.Mvc;

using TFGBackend.Data;
using TFGBackend.Models;
using TFGBackend.Business;

namespace TFGBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PistaController : ControllerBase
    {
        private readonly IPistaService _pistaService;

        public PistaController(IPistaService pistaService)
        {
            _pistaService = pistaService;
        }

        [HttpGet]
        public ActionResult<List<Pista>> GetAll() =>
            _pistaService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Pista> Get(int id)
        {
            var pista = _pistaService.Get(id);

            if (pista == null)
                return NotFound();

            return pista;
        }

        [HttpPost]
        public IActionResult Create(Pista pista)
        {
            _pistaService.Add(pista);
            return CreatedAtAction(nameof(Get), new { id = pista.IdPista }, pista);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Pista pista)
        {
            if (id != pista.IdPista)
                return BadRequest();

            try
            {
                _pistaService.Update(pista);
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
            var pista = _pistaService.Get(id);

            if (pista is null)
                return NotFound();

            _pistaService.Delete(id);

            return NoContent();
        }
    }
}