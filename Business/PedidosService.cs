using TFGBackend.Data;
using TFGBackend.Models;

namespace TFGBackend.Business
{
    public class PedidosService : IPedidosService
    {
        private readonly IPedidosRepository _pedidosRepository;

        public PedidosService(IPedidosRepository pedidosRepository){

            _pedidosRepository = pedidosRepository;
            
        }
        public List<Pedidos> GetAll() => _pedidosRepository.GetAll();

        public Pedidos? Get(int id) => _pedidosRepository.Get(id);

        public void Add(Pedidos pedidos) => _pedidosRepository.Add(pedidos);

        public void Delete(int id) => _pedidosRepository.Delete(id);

        public void Update(Pedidos pedidos) => _pedidosRepository.Update(pedidos);
    
    }
}
