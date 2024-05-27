using Microsoft.EntityFrameworkCore;
using TFGBackend.Models;
using TFGBackend.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace TFGBackend.Data
{
    public class SesionEFRepository : ISesionRepository
    {
        private readonly TFGContext _context;

        public SesionEFRepository(TFGContext context)
        {
            _context = context;
        }

        public void Add(SesionSimpleDto sesionDto)
        {
            var sesion = new Sesion
            {
                IdSesion = sesionDto.IdSesion,
                SesionTime = sesionDto.SesionTime,
                IdPista = sesionDto.IdPista
            };
            _context.Sesion.Add(sesion);
            SaveChanges();
        }

        public SesionSimpleDto? Get(int sesionId)
        {
            var sesion = _context.Sesion.FirstOrDefault(s => s.IdSesion == sesionId);
            if (sesion == null)
                return null;

            return new SesionSimpleDto
            {
                IdSesion = sesion.IdSesion,
                SesionTime = sesion.SesionTime,
                IdPista = sesion.IdPista
            };
        }

        public void Update(SesionSimpleDto sesionDto)
        {
            var existingSesion = _context.Sesion.Find(sesionDto.IdPista);
            if (existingSesion != null)
            {
                existingSesion.SesionTime = sesionDto.SesionTime;
                existingSesion.IdPista = sesionDto.IdPista;

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
                throw new KeyNotFoundException("Sesion not found.");
            }

            _context.Sesion.Remove(sesion);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<SesionSimpleDto> GetAll()
        {
            return _context.Sesion.Select(s => new SesionSimpleDto
            {
                IdSesion = s.IdSesion,
                SesionTime = s.SesionTime,
                IdPista = s.IdPista
            }).ToList();
        }
    }
}
