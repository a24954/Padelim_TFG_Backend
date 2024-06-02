using TFGBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace TFGBackend.Data
{
    public class PistaEFRepository : IPistaRepository
    {
        private readonly TFGContext _context;

        public PistaEFRepository(TFGContext context)
        {
            _context = context;
        }

        public void Add(Pista pista)
        {
            _context.Pista.Add(pista);
            SaveChanges();
        }

        public Pista? Get(int pistaId)
        {
            return _context.Pista.FirstOrDefault(pista => pista.IdPista == pistaId);
        }

        public void Update(Pista pista)
        {
            var existingPista = _context.Pista.FirstOrDefault(p => p.IdPista == pista.IdPista);
            if (existingPista != null)
            {
                existingPista.Name = pista.Name;
                existingPista.Description = pista.Description;
                existingPista.Photo = pista.Photo;
                existingPista.Duration = pista.Duration;
                existingPista.Price = pista.Price;
                existingPista.Date = pista.Date;

                _context.Entry(existingPista).State = EntityState.Modified;

                SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Pista not found.");
            }
        }

        public void Delete(int pistaId)
        {
            var pista = Get(pistaId);
            if (pista == null)
            {
                throw new KeyNotFoundException("Pista not found.");
            }

            var sesiones = _context.Sesion.Where(s => s.IdPista == pistaId).ToList();
            foreach (var sesion in sesiones)
            {
                var reservas = _context.Reserva.Where(r => r.IdSesion == sesion.IdSesion).ToList();
                _context.Reserva.RemoveRange(reservas);
            }

            _context.Sesion.RemoveRange(sesiones);
            _context.Pista.Remove(pista);
            SaveChanges();
        }



        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<Pista> GetAll()
        {
            return _context.Pista.ToList();

        }
    }
}