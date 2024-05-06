using Microsoft.EntityFrameworkCore;
using TFGBackend.Data;
using TFGBackend.Models;

namespace TFGBackend.Data
{
    public class SesionEFRepository : ISesionRepository
    {
        private readonly TFGContext _context;

        public SesionEFRepository(TFGContext context)
        {
            _context = context;
        }

        public void Add(Sesion sesion)
        {
            _context.Sesion.Add(sesion);
            SaveChanges();
        }

        public Sesion? Get(int sesionId)
        {
            return _context.Sesion.FirstOrDefault(sesion => sesion.IdSesion == sesionId);
        }

        public void Update(Sesion sesion)
        {
            var existingSesion = _context.Sesion.Find(sesion.IdSesion);

            if (existingSesion != null)
            {
                existingSesion.SesionTime = sesion.SesionTime;
                existingSesion.IdPista = sesion.IdPista;

                _context.Entry(existingSesion).State = EntityState.Modified;

                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Sesion not found.");
            }
        }


        public void Delete(int sesionId)
        {
            var sesion = _context.Sesion.Find(sesionId);
            if (sesion == null)
            {
                throw new KeyNotFoundException("Reservation not found.");
            }

            _context.Sesion.Remove(sesion);
            SaveChanges();
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<Sesion> GetAll()
        {
            return _context.Reserva.Select(r => new Sesion { IdSesion = r.IdSesion, SesionTime = r.SesionTime, IdPista = r.IdPista }).ToList();
        }
    }
}