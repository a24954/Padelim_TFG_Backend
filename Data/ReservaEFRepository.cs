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
            var reserva = _context.Reserva
                .Include(r => r.Sesion)
                .ThenInclude(s => s.Pista)
                .Include(s => s.Usuario)
                .FirstOrDefault(reserva => reserva.IdReservation == reservaId);
                return reserva;
        }


        public void Update(Reserva reserva)
        {
            var existingReserva = _context.Reserva.FirstOrDefault(r => r.IdReservation == reserva.IdReservation);
            if (existingReserva != null)
            {
                existingReserva.ReservationPrice = reserva.ReservationPrice;
                existingReserva.ReservationDate = reserva.ReservationDate;
                existingReserva.IdUser = reserva.IdUser;
                existingReserva.IdSesion = reserva.IdSesion;

                _context.Entry(existingReserva).State = EntityState.Modified;

                SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Reservation not found.");
            }
        }

        public List<ReservaResponseDto> GetReservasByUser(int userId)
        {
            
            var reservations = _context.Reserva
                .Include(r => r.Sesion)
                .ThenInclude(s => s.Pista)
                .Where(r => r.IdUser == userId)
                .Select(c => new ReservaResponseDto
                {
                    IdReservation = c.IdReservation,
                    ReservationPrice = c.ReservationPrice,
                    ReservationDate = c.ReservationDate,
                    Sesion = new SesionDto {
                        IdSesion = c.Sesion.IdSesion,
                        SesionTime = c.Sesion.SesionTime,
                        Pista = new PistaDto {
                            IdPista = c.Sesion.Pista.IdPista,
                            Name = c.Sesion.Pista.Name,
                            Duration = c.Sesion.Pista.Duration,
                            Price = c.Sesion.Pista.Price,
                        }
                    }            
                })
                .ToList();
                return reservations;
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

        public List<ReservaResponseDto> GetAll()
        {
            var reservas = _context.Reserva.Include(s=>s.Sesion)
            .ThenInclude(s=>s.Pista)
            .Include(s=>s.Usuario)
            .Select(r => new ReservaResponseDto{
                IdReservation = r.IdReservation,
                ReservationPrice = r.ReservationPrice,
                ReservationDate = r.ReservationDate,
                Sesion = new SesionDto {
                    IdSesion = r.Sesion.IdSesion,
                    SesionTime = r.Sesion.SesionTime,
                    Pista = new PistaDto {
                        IdPista = r.Sesion.Pista.IdPista,
                        Name = r.Sesion.Pista.Name,
                        Duration = r.Sesion.Pista.Duration,
                        Price = r.Sesion.Pista.Price,
                    }
                }
                
            })
            .ToList();
            return reservas;

        }
    }
}