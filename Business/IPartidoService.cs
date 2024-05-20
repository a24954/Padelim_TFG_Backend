using TFGBackend.Models;

namespace TFGBackend.Business
{
     public interface IPartidoService
    {
        List<Partido> GetAll();
        Partido? Get(int id);
        void Add(Partido partido);
        void Delete(int id);
        void Update(Partido partido);
    }
}
