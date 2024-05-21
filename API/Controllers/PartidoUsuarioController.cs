using Microsoft.AspNetCore.Mvc;
using TFGBackend.Business;
using TFGBackend.Models;
using System.Collections.Generic;


namespace TFGBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartidosUsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public PartidosUsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("{usuarioId}")]
        public ActionResult<List<PartidoUsuarioDto>> GetPartidosUsuario(int usuarioId)
        {
            var partidosUsuario = _usuarioService.GetPartidosUsuario(usuarioId);

            if (partidosUsuario == null)
                return NotFound();

            return partidosUsuario;
        }
    }
}
