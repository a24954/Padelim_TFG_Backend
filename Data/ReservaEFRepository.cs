using TFGBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace TFGBackend.Data
{
    public class ReservaEFRepository : IReservaRepository
    {
        private readonly TFGContext _context;

        public ReservaEFRepository(TFGContext context)
        {
            _context = context;
        }

        public void Add(Reserva reserva)
        {
            _context.Reserva.Add(reserva);
            SaveChanges();
        }

        public Reserva? Get(int reservaId)
        {
            return _context.Reserva.FirstOrDefault(reserva => reserva.IdReservation == reservaId);
        }

        public void Update(Reserva reserva)
        {
            var existingReserva = _context.Reserva.FirstOrDefault(r => r.IdReservation == reserva.IdReservation);
            if (existingReserva != null)
            {
                existingReserva.User_Email = reserva.User_Email;
                existingReserva.ReservationPrice = reserva.ReservationPrice;
                existingReserva.ReservationDate = reserva.ReservationDate;
                existingReserva.IdUser = reserva.IdUser;
                existingReserva.IdPista = reserva.IdPista;
                existingReserva.IdSesion = reserva.IdSesion;

                _context.Entry(existingReserva).State = EntityState.Modified;

                SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Reservation not found.");
            }
        }

        public void Delete(int reservaId)
        {
            var reserva = Get(reservaId);
            if (reserva is null)
            {
                throw new KeyNotFoundException("Account not found.");
            }
            _context.Reserva.Remove(reserva);
            SaveChanges();

        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<Reserva> GetAll()
        {
            return _context.Reserva.ToList();

        }
    }
}