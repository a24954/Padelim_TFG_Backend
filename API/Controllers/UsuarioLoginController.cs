using Microsoft.AspNetCore.Mvc;
using TFGBackend.Data;
using TFGBackend.Models;
using TFGBackend.Business;

namespace TFGBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioLoginController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioLoginController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UsuarioSimpleDto usuarioLogin)
        {
            if (_usuarioService == null)
            {
                return StatusCode(500, "Servicio de usuario no está disponible.");
            }

            var usuario = _usuarioService.Login(usuarioLogin.UserName, usuarioLogin.Password);

            if (usuario == null)
                return Unauthorized();

            return Ok(usuario);
        }
    }
}
