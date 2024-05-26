using TFGBackend.Models;
namespace TFGBackend.Data
{
    public interface IReservaRepository
    {
        List<Reserva> GetAll();
        Reserva? Get(int id);
        void Add(Reserva reserva);
        void Delete(int id);
        void Update(Reserva reserva);

        List<Reserva> GetReservasByUser(int userId);
    }
}
