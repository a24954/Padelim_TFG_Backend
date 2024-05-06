using TFGBackend.Models;

namespace TFGBackend.Business
{
     public interface IPistaService
    {
        List<Pista> GetAll();
        Pista? Get(int id);
        void Add(Pista pista);
        void Delete(int id);
        void Update(Pista pista);
    }
}
