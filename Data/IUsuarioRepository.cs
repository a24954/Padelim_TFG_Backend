using TFGBackend.Models;
namespace TFGBackend.Data
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetAll();
        UsuarioSimpleDto? Get(int id);
        void Add(Usuario usuario);
        void Delete(int id);
        void Update(Usuario usuario);
    }
}
