using TFGBackend.Models;

namespace TFGBackend.Data
{
    public interface IPistaRepository
    {
        List<Pista> GetAll();
        Pista? Get(int id);
        void Add(Pista pista);
        void Delete(int id);
        void Update(Pista pista);
    }
}
