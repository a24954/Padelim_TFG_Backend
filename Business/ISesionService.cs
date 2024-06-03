using TFGBackend.DTOs;
using TFGBackend.Models;

namespace TFGBackend.Business
{
     public interface ISesionService
    {
        List<SesionSimpleDto> GetAll();
        SesionSimpleDto? Get(int id);
        List<SesionSimpleDto>? GetPista(int id);
        void Add(SesionSimpleDto sesion);
        void Delete(int id);
        void Update(SesionSimpleDto sesion);
    }
}
