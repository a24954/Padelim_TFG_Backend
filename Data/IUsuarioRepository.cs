using TFGBackend.Models;
using System.Collections.Generic;

namespace TFGBackend.Data
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetAll();
        UsuarioSimpleDto? Get(int id);
        void Add(Usuario usuario);
        void Delete(int id);
        void Update(Usuario usuario);
        List<PartidoUsuarioDto> GetPartidosUsuario(int usuarioId); 
    }
}
