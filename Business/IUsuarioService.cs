using TFGBackend.Models;
using System.Collections.Generic;

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
        List<PartidoUsuarioDto> GetPartidosUsuario(int usuarioId); // Añadir esta línea
    }
}
