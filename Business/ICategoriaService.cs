using TFGBackend.Models;

namespace TFGBackend.Business
{
     public interface ICategoriaService
    {
        List<Categoria> GetAll();
        Categoria? Get(int id);
        void Add(Categoria categoria);
        void Delete(int id);
        void Update(Categoria categoria);
    }
}
