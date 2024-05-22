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
        void Update(int id, UsuarioSimpleDto usuarioDto);
        Usuario Login(string userName, string password);
        List<PartidoUsuarioDto> GetPartidosUsuario(int usuarioId);
        CompraResponseDto ComprarProductos(CompraRequestDto compraRequest);
    }
}