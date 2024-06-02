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
        public IActionResult Create(PartidoSimpleDto partidoDto)
        {
            var partido = new Partido
            {
                Name = partidoDto.Name,
                Estrellas = partidoDto.Estrellas,
                Photo = partidoDto.Photo,
                Description = partidoDto.Description,
                Duration = partidoDto.Duration,
                Date = partidoDto.Date,
            };

            _partidoService.Add(partido);
            return CreatedAtAction(nameof(Get), new { id = partido.IdPartido }, partido);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Partido partido)
        {
            if (id != partido.IdPartido)
                return BadRequest();

            var existingPartido = _partidoService.Get(id);
            if (existingPartido is null)
                return NotFound();

            _partidoService.Update(partido);

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

        [HttpPost("{partidoId}/usuarios/{usuarioId}")]
        public ActionResult<List<UsuarioPartidoDto>> AddUsuarioToPartido(int partidoId, int usuarioId, int position)
        {
            try
            {
                _partidoService.AddUsuarioToPartido(usuarioId, partidoId, position);
                var usuariosPartido = _partidoService.GetUsuariosPartido(partidoId);
                return usuariosPartido.Any() ? usuariosPartido : new List<UsuarioPartidoDto>();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{partidoId}/usuarios")]
        public ActionResult<List<UsuarioPartidoDto>> GetUsuariosPartido(int partidoId)
        {
            var usuarios = _partidoService.GetUsuariosPartido(partidoId);

            if (usuarios == null || usuarios.Count == 0)
                return NotFound();

            return usuarios;
        }

        [HttpDelete("{partidoId}/usuarios/{usuarioId}")]
        public IActionResult DeleteUsuarioFromPartido(int partidoId, int usuarioId)
        {
            try
            {
                _partidoService.DeleteUserFromPartido(usuarioId, partidoId);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
