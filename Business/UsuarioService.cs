using TFGBackend.Data;
using TFGBackend.Models;
using System.Collections.Generic;
using System.Linq;
using Serilog.Data;

namespace TFGBackend.Business
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IProductoRepository _productoRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository, IProductoRepository productoRepository)
        {
            _usuarioRepository = usuarioRepository;
            _productoRepository = productoRepository;
        }

        public List<Usuario> GetAll() => _usuarioRepository.GetAll();

        public UsuarioSimpleDto? Get(int id) => _usuarioRepository.Get(id);

        public void Add(Usuario usuario) => _usuarioRepository.Add(usuario);

        public void Delete(int id) => _usuarioRepository.Delete(id);
        
        public Usuario? GetForUpdate(int IdUser) {
            return _usuarioRepository.GetForUpdate(IdUser);
        }

        public void Update(Usuario usuario) => _usuarioRepository.Update(usuario);
        
        public Usuario Login(string userName, string password)
        {
            return _usuarioRepository.GetAll().FirstOrDefault(u => u.UserName == userName && u.Password == password);
        }

        public List<PartidoUsuarioDto> GetPartidosUsuario(int usuarioId)
        {
            return _usuarioRepository.GetPartidosUsuario(usuarioId);
        }

        public CompraResponseDto ComprarProductos(CompraRequestDto compraRequest)
        {
            var usuario = _usuarioRepository.Get(compraRequest.IdUser);
            if (usuario == null) throw new KeyNotFoundException("Usuario no encontrado");

            decimal total = 0;
            List<ProductoCompraResponseDto> productosComprados = new List<ProductoCompraResponseDto>();

            foreach (var productoDto in compraRequest.Productos)
            {
                var producto = _productoRepository.Get(productoDto.IdProducto);
                if (producto == null) throw new KeyNotFoundException($"Producto con ID {productoDto.IdProducto} no encontrado");

                int cantidadDisponible = int.Parse(producto.Product_Amount);
                if (productoDto.Cantidad > cantidadDisponible) throw new InvalidOperationException($"No hay suficiente stock para el producto {producto.Name_Product}");

                producto.Product_Amount = (cantidadDisponible - productoDto.Cantidad).ToString();
                _productoRepository.Update(producto);

                decimal precioProducto = decimal.Parse(producto.Product_Price) * productoDto.Cantidad;
                total += precioProducto;

                productosComprados.Add(new ProductoCompraResponseDto
                {
                    IdProducto = producto.IdProduct,
                    Nombre = producto.Name_Product,
                    Cantidad = productoDto.Cantidad,
                    PrecioTotal = precioProducto
                });
            }

            return new CompraResponseDto
            {
                IdUser = compraRequest.IdUser,
                UserName = usuario.UserName,
                Productos = productosComprados,
            };
        }
    }
}
