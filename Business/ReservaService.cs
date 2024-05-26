using TFGBackend.Data;
using TFGBackend.Models;
using System.Collections.Generic;

namespace TFGBackend.Business
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaService(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        public List<Reserva> GetAll() => _reservaRepository.GetAll();

        public Reserva? Get(int id) => _reservaRepository.Get(id);

        public void Add(Reserva reserva) => _reservaRepository.Add(reserva);

        public void Delete(int id) => _reservaRepository.Delete(id);

        public void Update(Reserva reserva) => _reservaRepository.Update(reserva);

        public List<Reserva> GetReservasByUser(int userId)
        {
            return _reservaRepository.GetReservasByUser(userId);
        }
    }
}
