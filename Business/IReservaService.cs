using TFGBackend.Models;

namespace TFGBackend.Business
{
     public interface IReservaService
    {
        List<Reserva> GetAll();
        Reserva? Get(int id);
        void Add(Reserva reserva);
        void Delete(int id);
        void Update(Reserva reserva);
    }
}
