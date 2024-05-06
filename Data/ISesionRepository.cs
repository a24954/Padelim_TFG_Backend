using TFGBackend.Models;
namespace TFGBackend.Data
{
    public interface ISesionRepository
    {
        List<Sesion> GetAll();
        Sesion? Get(int id);
        void Add(Sesion sesion);
        void Delete(int id);
        void Update(Sesion sesion);
    }
}
