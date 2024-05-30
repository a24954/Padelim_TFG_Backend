using TFGBackend.Models;
using System.Collections.Generic;
using TFGBackend.Models.DTOs;

namespace TFGBackend.Business
{
    public interface IUsuarioService
    {
        List<Usuario> GetAll();
        UsuarioSimpleDto? Get(int id);
        void Add(Usuario usuario);
        void Delete(int id);
        void Update(Usuario usuario);
        Usuario Login(string userName, string password);
        Usuario? GetForUpdate(int IdUser);
        List<PartidoUsuarioDto> GetPartidosUsuario(int usuarioId);
        CompraResponseDto ComprarProductos(CompraRequestDto compraRequest);
        List<CompraResponseDto> GetComprasUsuario(int usuarioId);
        void BorrarComprasPorUsuario(int usuarioId);
        void BorrarCompra(int usuarioId, int compraId);

    }
}