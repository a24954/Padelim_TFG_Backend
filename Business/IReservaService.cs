using TFGBackend.Models;
using System.Collections.Generic;

namespace TFGBackend.Business
{
    public interface IReservaService
    {
        List<ReservaResponseDto> GetAll();
        Reserva? Get(int id);
        void Add(Reserva reserva);
        void Delete(int id);
        void Update(Reserva reserva);
        List<ReservaResponseDto> GetReservasByUser(int userId);

    }
}
