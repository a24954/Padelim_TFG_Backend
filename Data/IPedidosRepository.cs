using TFGBackend.Models;

namespace TFGBackend.Data
{
    public interface IPedidosRepository
    {
        List<Pedidos> GetAll();
        Pedidos? Get(int id);
        void Add(Pedidos pedidos);
        void Delete(int id);
        void Update(Pedidos pedidos);
    }
}
