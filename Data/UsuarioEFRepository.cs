using TFGBackend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace TFGBackend.Data
{
    public class UsuarioEFRepository : IUsuarioRepository
    {
        private readonly TFGContext _context;

        public UsuarioEFRepository(TFGContext context)
        {
            _context = context;
        }

        public void Add(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            SaveChanges();
        }

        public UsuarioSimpleDto? Get(int usuarioId)
        {
            return _context.Usuarios
                .Where(usuario => usuario.IdUser == usuarioId)
                .Select(r => new UsuarioSimpleDto
                {
                    UserName = r.UserName,
                    Password = r.Password,
                })
                .FirstOrDefault();
        }

        public List<PartidoUsuarioDto> GetPartidosUsuario(int usuarioId)
        {
            var partidosUsuario = _context.Partido
                .Where(p => p.IdUser == usuarioId)
                .Select(p => new PartidoUsuarioDto
                {
                    NombrePartido = p.Name,
                    Estrellas = p.Estrellas,
                    Duracion = p.Duration,
                    Fecha = p.Date,
                    UserName = _context.Usuarios.Where(u => u.IdUser == p.IdUser).Select(u => u.UserName).FirstOrDefault()
                })
                .ToList();

            return partidosUsuario;
        }

        public void Update(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            SaveChanges();
        }

        public Usuario? GetForUpdate(int IdUser)
        {
            return _context.Usuarios.FirstOrDefault(p => p.IdUser == IdUser);
        }

        public void Delete(int usuarioId)
        {
            var usuario = _context.Usuarios.Find(usuarioId);
            if (usuario is null)
            {
                throw new KeyNotFoundException("Account not found.");
            }
            _context.Usuarios.Remove(usuario);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        public CompraResponseDto ComprarProductos(CompraRequestDto compraRequest)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.IdUser == compraRequest.IdUser);
            if (usuario == null) throw new KeyNotFoundException("Usuario no encontrado");

            decimal total = 0;
            List<ProductoCompraResponseDto> productosComprados = new List<ProductoCompraResponseDto>();

            foreach (var productoDto in compraRequest.Productos)
            {
                var producto = _context.Producto.FirstOrDefault(p => p.IdProduct == productoDto.IdProducto);
                if (producto == null) throw new KeyNotFoundException($"Producto con ID {productoDto.IdProducto} no encontrado");

                int cantidadDisponible = int.Parse(producto.Product_Amount);
                if (productoDto.Cantidad > cantidadDisponible) throw new InvalidOperationException($"No hay suficiente stock para el producto {producto.Name_Product}");

                producto.Product_Amount = (cantidadDisponible - productoDto.Cantidad).ToString();
                _context.Entry(producto).State = EntityState.Modified;

                decimal precioProducto = (decimal)producto.Product_Price * productoDto.Cantidad;
                total += precioProducto;

                productosComprados.Add(new ProductoCompraResponseDto
                {
                    IdProducto = producto.IdProduct,
                    Nombre = producto.Name_Product,
                    Cantidad = productoDto.Cantidad,
                    PrecioTotal = precioProducto
                });

                var compra = new Compra
                {
                    IdUser = compraRequest.IdUser,
                    IdProducto = producto.IdProduct,
                    Cantidad = productoDto.Cantidad,
                    PrecioTotal = precioProducto
                };
                _context.Compras.Add(compra);
            }

            _context.SaveChanges();

            return new CompraResponseDto
            {
                IdUser = compraRequest.IdUser,
                UserName = usuario.UserName,
                Productos = productosComprados,
            };
        }

        public List<CompraResponseDto> GetComprasUsuario(int usuarioId)
        {
            return _context.Compras
                .Where(c => c.IdUser == usuarioId)
                .Select(c => new CompraResponseDto
                {
                    IdCompra = c.IdCompra,
                    IdUser = c.IdUser,
                    UserName = _context.Usuarios.FirstOrDefault(u => u.IdUser == c.IdUser).UserName,
                    Productos = _context.Compras
                        .Where(cp => cp.IdUser == c.IdUser && cp.IdCompra == c.IdCompra)
                        .Select(cp => new ProductoCompraResponseDto
                        {
                            IdProducto = cp.IdProducto,
                            Nombre = _context.Producto.FirstOrDefault(p => p.IdProduct == cp.IdProducto).Name_Product,
                            Cantidad = cp.Cantidad,
                            PrecioTotal = cp.PrecioTotal
                        }).ToList()
                }).ToList();
        }
        public void BorrarComprasPorUsuario(int usuarioId)
        {
            var compras = _context.Set<Compra>().Where(c => c.IdUser == usuarioId);
            _context.Set<Compra>().RemoveRange(compras);
            _context.SaveChanges();
        }

        public void BorrarCompra(int usuarioId, int compraId)
        {
            var compra = _context.Compras.FirstOrDefault(c => c.IdUser == usuarioId && c.IdCompra == compraId);
            if (compra != null)
            {
                _context.Compras.Remove(compra);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"Compra no encontrada: IdCompra = {compraId}, IdUser = {usuarioId}");
            }
        }


    }
}
