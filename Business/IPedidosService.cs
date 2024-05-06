using TFGBackend.Models;

namespace TFGBackend.Business
{
     public interface IPedidosService
    {
        List<Pedidos> GetAll();
        Pedidos? Get(int id);
        void Add(Pedidos pedidos);
        void Delete(int id);
        void Update(Pedidos pedidos);
    }
}
