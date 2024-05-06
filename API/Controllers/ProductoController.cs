using Microsoft.AspNetCore.Mvc;

using TFGBackend.Data;
using TFGBackend.Models;
using TFGBackend.Business;

namespace TFGBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public ActionResult<List<Producto>> GetAll() =>
            _productoService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Producto> Get(int id)
        {
            var producto = _productoService.Get(id);

            if (producto == null)
                return NotFound();

            return producto;
        }

        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            _productoService.Add(producto);
            return CreatedAtAction(nameof(Get), new { id = producto.IdProduct }, producto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Producto producto)
        {
            if (id != producto.IdProduct)
                return BadRequest();

            try
            {
                _productoService.Update(producto);
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
            var producto = _productoService.Get(id);

            if (producto is null)
                return NotFound();

            _productoService.Delete(id);

            return NoContent();
        }
    }
}