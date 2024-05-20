using TFGBackend.Models;

namespace TFGBackend.Data
{
    public interface IPartidoRepository
    {
        List<Partido> GetAll();
        Partido? Get(int id);
        void Add(Partido partido);
        void Delete(int id);
        void Update(Partido partido);
    }
}
