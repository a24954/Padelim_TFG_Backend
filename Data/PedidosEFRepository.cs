using TFGBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace TFGBackend.Data
{
    public class PedidosEFRepository : IPedidosRepository
    {
        private readonly TFGContext _context;

        public PedidosEFRepository(TFGContext context)
        {
            _context = context;
        }

        public void Add(Pedidos pedidos)
        {
            _context.Pedidos.Add(pedidos);
            SaveChanges();
        }

        public Pedidos? Get(int pedidosId)
        {
            return _context.Pedidos.FirstOrDefault(pedidos => pedidos.IdPedidos == pedidosId);
        }

        public void Update(Pedidos pedido)
        {
            var existingPedido = _context.Pedidos.FirstOrDefault(p => p.IdPedidos == pedido.IdPedidos);
            if (existingPedido != null)
            {
                existingPedido.Fe_Inicio = pedido.Fe_Inicio;
                existingPedido.Total_Price = pedido.Total_Price;
                existingPedido.Estado = pedido.Estado;
                existingPedido.IdProduct = pedido.IdProduct;

                _context.Entry(existingPedido).State = EntityState.Modified;

                SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Pedido not found.");
            }
        }

        public void Delete(int pedidosId)
        {
            var pedidos = Get(pedidosId);
            if (pedidos is null)
            {
                throw new KeyNotFoundException("Account not found.");
            }
            _context.Pedidos.Remove(pedidos);
            SaveChanges();

        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<Pedidos> GetAll()
        {
            return _context.Pedidos.ToList();

        }
    }
}