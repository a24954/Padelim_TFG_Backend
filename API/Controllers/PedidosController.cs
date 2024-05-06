using Microsoft.AspNetCore.Mvc;

using TFGBackend.Data;
using TFGBackend.Models;
using TFGBackend.Business;

namespace TFGBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidosContrroller : ControllerBase
    {
        private readonly IPedidosService _pedidosService;

        public PedidosContrroller(IPedidosService pedidosService)
        {
            _pedidosService = pedidosService;
        }

        [HttpGet]
        public ActionResult<List<Pedidos>> GetAll() =>
            _pedidosService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Pedidos> Get(int id)
        {
            var pedidos = _pedidosService.Get(id);

            if (pedidos == null)
                return NotFound();

            return pedidos;
        }

        [HttpPost]
        public IActionResult Create(Pedidos pedidos)
        {
            _pedidosService.Add(pedidos);
            return CreatedAtAction(nameof(Get), new { id = pedidos.IdPedidos }, pedidos);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Pedidos pedidos)
        {
            if (id != pedidos.IdPedidos)
                return BadRequest();

            try
            {
                _pedidosService.Update(pedidos);
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
            var pedidos = _pedidosService.Get(id);

            if (pedidos is null)
                return NotFound();

            _pedidosService.Delete(id);

            return NoContent();
        }
    }
}