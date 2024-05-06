using TFGBackend.Models;

namespace TFGBackend.Data
{
    public interface ICategoriaRepository
    {
        List<Categoria> GetAll();
        Categoria? Get(int id);
        void Add(Categoria categoria);
        void Delete(int id);
        void Update(Categoria categoria);
    }
}
