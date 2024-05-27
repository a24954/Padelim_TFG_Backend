using TFGBackend.Models;
namespace TFGBackend.Data
{
    public interface IReservaRepository
    {
        List<ReservaResponseDto> GetAll();
        Reserva? Get(int id);
        void Add(Reserva reserva);
        void Delete(int id);
        void Update(Reserva reserva);

        List<ReservaResponseDto> GetReservasByUser(int userId);
    }
}
