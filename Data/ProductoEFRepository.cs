using TFGBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace TFGBackend.Data
{
    public class ProductoEFRepository : IProductoRepository
    {
        private readonly TFGContext _context;

        public ProductoEFRepository(TFGContext context)
        {
            _context = context;
        }

        public void Add(Producto producto)
        {
            _context.Producto.Add(producto);
            SaveChanges();
        }

        public Producto? Get(int productoId)
        {
            return _context.Producto.FirstOrDefault(producto => producto.IdProduct == productoId);
        }

        public void Update(Producto producto)
        {
            var existingProducto = _context.Producto.FirstOrDefault(p => p.IdProduct == producto.IdProduct);
            if (existingProducto != null)
            {
                existingProducto.Name_Product = producto.Name_Product;
                existingProducto.Product_Price = producto.Product_Price;
                existingProducto.Product_Description = producto.Product_Description;
                existingProducto.Product_Amount = producto.Product_Amount;
                existingProducto.IdCategoria = producto.IdCategoria;

                _context.Entry(existingProducto).State = EntityState.Modified;

                SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Product not found.");
            }
        }

        public void Delete(int productoId)
        {
            var producto = Get(productoId);
            if (producto is null)
            {
                throw new KeyNotFoundException("Account not found.");
            }
            _context.Producto.Remove(producto);
            SaveChanges();

        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<Producto> GetAll()
        {
            return _context.Producto.ToList();

        }
    }
}