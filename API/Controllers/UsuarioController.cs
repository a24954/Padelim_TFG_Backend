using Microsoft.AspNetCore.Mvc;
using TFGBackend.Data;
using TFGBackend.Models;
using TFGBackend.Business;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace TFGBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public ActionResult<List<Usuario>> GetAll() =>
            _usuarioService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<UsuarioSimpleDto> Get(int id)
        {
            var usuario = _usuarioService.Get(id);

            if (usuario == null)
                return NotFound();

            return usuario;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUsuarioDto createUsuarioDto)
        {
            var usuario = new Usuario
            {
                UserName = createUsuarioDto.UserName,
                Password = createUsuarioDto.Password,
                Email = createUsuarioDto.Email,
                Rol = createUsuarioDto.Rol
            };

            _usuarioService.Add(usuario);

            return CreatedAtAction(nameof(Get), new { id = usuario.IdUser }, usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UsuarioSimpleDto usuarioDto)
        {
            if (id != usuarioDto.IdUser)
                return BadRequest();

            var existingUser = _usuarioService.GetForUpdate(id);
            if (existingUser == null)
                return NotFound();

            existingUser.UserName = usuarioDto.UserName;
            existingUser.Password = usuarioDto.Password;
            existingUser.Email = usuarioDto.Email;

            _usuarioService.Update(existingUser);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var usuario = _usuarioService.Get(id);

            if (usuario is null)
                return NotFound();

            _usuarioService.Delete(id);

            return NoContent();
        }

        [HttpGet("{id}/partidos")]
        public ActionResult<List<PartidoUsuarioDto>> GetPartidosUsuario(int id)
        {
            var partidos = _usuarioService.GetPartidosUsuario(id);

            if (partidos == null || partidos.Count == 0)
                return NotFound();

            return partidos;
        }

        [HttpPost("comprar")]
        public ActionResult<CompraResponseDto> ComprarProductos([FromBody] CompraRequestDto compraRequest)
        {
            try
            {
                var compraResponse = _usuarioService.ComprarProductos(compraRequest);
                return Ok(compraResponse);
            }
            catch (KeyNotFoundException e)
            {
                return NotFound(new { message = e.Message });
            }
            catch (InvalidOperationException e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpGet("{id}/compras")]
        public IActionResult GetComprasUsuario(int id)
        {
            if (_usuarioService == null)
            {
                return StatusCode(500, "Servicio de usuario no está disponible.");
            }

            var compras = _usuarioService.GetComprasUsuario(id);

            if (compras == null || !compras.Any())
                return NotFound();

            return Ok(compras);
        }
        [HttpDelete("{usuarioId}/compras/{compraId}")]
        public IActionResult BorrarCompra(int usuarioId, int compraId)
        {
            try
            {
                _usuarioService.BorrarCompra(usuarioId, compraId);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
