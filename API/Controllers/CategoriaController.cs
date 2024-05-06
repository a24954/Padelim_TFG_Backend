using Microsoft.AspNetCore.Mvc;

using TFGBackend.Data;
using TFGBackend.Models;
using TFGBackend.Business;

namespace TFGBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public ActionResult<List<Categoria>> GetAll() =>
            _categoriaService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Categoria> Get(int id)
        {
            var categoria = _categoriaService.Get(id);

            if (categoria == null)
                return NotFound();

            return categoria;
        }

        [HttpPost]
        public IActionResult Create(Categoria categoria)
        {
            _categoriaService.Add(categoria);
            return CreatedAtAction(nameof(Get), new { id = categoria.IdCategoria }, categoria);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Categoria categoria)
        {
            if (id != categoria.IdCategoria)
                return BadRequest();

            try
            {
                _categoriaService.Update(categoria);
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
            var categoria = _categoriaService.Get(id);

            if (categoria is null)
                return NotFound();

            _categoriaService.Delete(id);

            return NoContent();
        }
    }
}