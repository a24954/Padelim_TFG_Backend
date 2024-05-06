using TFGBackend.Models;

namespace TFGBackend.Business
{
     public interface IProductoService
    {
        List<Producto> GetAll();
        Producto? Get(int id);
        void Add(Producto producto);
        void Delete(int id);
        void Update(Producto producto);
    }
}
