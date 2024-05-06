using TFGBackend.Data;
using TFGBackend.Models;

namespace TFGBackend.Business
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoService(IProductoRepository productoRepository){

            _productoRepository = productoRepository;
            
        }
        public List<Producto> GetAll() => _productoRepository.GetAll();

        public Producto? Get(int id) => _productoRepository.Get(id);

        public void Add(Producto producto) => _productoRepository.Add(producto);

        public void Delete(int id) => _productoRepository.Delete(id);

        public void Update(Producto producto) => _productoRepository.Update(producto);
    
    }
}
