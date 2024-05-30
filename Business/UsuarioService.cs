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

        public Usuario? GetForUpdate(int IdUser)
        {
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
            return _usuarioRepository.ComprarProductos(compraRequest);
        }

        public List<CompraResponseDto> GetComprasUsuario(int usuarioId)
        {
            return _usuarioRepository.GetComprasUsuario(usuarioId);
        }
        public void BorrarComprasPorUsuario(int usuarioId)
        {
            _usuarioRepository.BorrarComprasPorUsuario(usuarioId);
        }

        public void BorrarCompra(int usuarioId, int compraId)
        {
            _usuarioRepository.BorrarCompra(usuarioId, compraId);
        }

    }
}
