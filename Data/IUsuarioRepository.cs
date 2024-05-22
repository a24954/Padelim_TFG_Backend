using TFGBackend.Models;
using System.Collections.Generic;
using TFGBackend.Models.DTOs;

namespace TFGBackend.Data
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetAll();
        UsuarioSimpleDto? Get(int id);
        void Add(Usuario usuario);
        void Delete(int id);
        void Update(Usuario usuario);
        Usuario? GetForUpdate(int IdUser);
        List<PartidoUsuarioDto> GetPartidosUsuario(int usuarioId);
    }
}
