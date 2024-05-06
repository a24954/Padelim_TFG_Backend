using TFGBackend.Models;

namespace TFGBackend.Data
{
    public interface IProductoRepository
    {
        List<Producto> GetAll();
        Producto? Get(int id);
        void Add(Producto producto);
        void Delete(int id);
        void Update(Producto producto);
    }
}
