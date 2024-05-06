using TFGBackend.Models;

namespace TFGBackend.Business
{
     public interface ISesionService
    {
        List<Sesion> GetAll();
        Sesion? Get(int id);
        void Add(Sesion sesion);
        void Delete(int id);
        void Update(Sesion sesion);
    }
}
