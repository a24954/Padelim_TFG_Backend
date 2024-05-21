using Microsoft.AspNetCore.Mvc;
using TFGBackend.Business;
using TFGBackend.Models;
using System.Collections.Generic;

namespace TFGBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartidoController : ControllerBase
    {
        private readonly IPartidoService _partidoService;

        public PartidoController(IPartidoService partidoService)
        {
            _partidoService = partidoService;
        }

        [HttpGet]
        public ActionResult<List<Partido>> GetAll() =>
            _partidoService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Partido> Get(int id)
        {
            var partido = _partidoService.Get(id);

            if (partido == null)
                return NotFound();

            return partido;
        }

        [HttpPost]
        public IActionResult Create(Partido partido)
        {
            _partidoService.Add(partido);
            return CreatedAtAction(nameof(Get), new { id = partido.IdPartido }, partido);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Partido partido)
        {
            if (id != partido.IdPartido)
                return BadRequest();

            try
            {
                _partidoService.Update(partido);
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
            var partido = _partidoService.Get(id);

            if (partido is null)
                return NotFound();

            _partidoService.Delete(id);

            return NoContent();
        }

        [HttpGet("{id}/usuarios")]
        public ActionResult<List<UsuarioPartidoDto>> GetUsuariosPartido(int id)
        {
            var usuarios = _partidoService.GetUsuariosPartido(id);

            if (usuarios == null || usuarios.Count == 0)
                return NotFound("No se encontraron usuarios para este partido.");

            return Ok(usuarios);
        }
    }
}
