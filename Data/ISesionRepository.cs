using TFGBackend.DTOs;
using TFGBackend.Models;
namespace TFGBackend.Data
{
    public interface ISesionRepository
    {
        List<SesionSimpleDto> GetAll();
        SesionSimpleDto? Get(int id);
        void Add(SesionSimpleDto sesion);
        void Delete(int id);
        void Update(SesionSimpleDto sesion);
    }
}
