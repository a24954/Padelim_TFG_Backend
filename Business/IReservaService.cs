using TFGBackend.Models;
using System.Collections.Generic;

namespace TFGBackend.Business
{
    public interface IReservaService
    {
        List<Reserva> GetAll();
        Reserva? Get(int id);
        void Add(Reserva reserva);
        void Delete(int id);
        void Update(Reserva reserva);
        List<Reserva> GetReservasByUser(int userId);

    }
}
