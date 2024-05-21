using TFGBackend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace TFGBackend.Data
{
    public class PartidoEFRepository : IPartidoRepository
    {
        private readonly TFGContext _context;

        public PartidoEFRepository(TFGContext context)
        {
            _context = context;
        }

        public void Add(Partido partido)
        {
            _context.Partido.Add(partido);
            SaveChanges();
        }

        public Partido? Get(int partidoId)
        {
            return _context.Partido.FirstOrDefault(partido => partido.IdPartido == partidoId);
        }

        public List<UsuarioPartidoDto> GetUsuariosPartido(int partidoId)
        {
            var usuariosPartido = _context.UsuarioPartidos
                .Where(up => up.IdPartido == partidoId)
                .Select(up => new UsuarioPartidoDto
                {
                    UserName = up.Usuario.UserName,
                    Email = up.Usuario.Email
                })
                .Take(4)  // Tomar solo los primeros 4 usuarios
                .ToList();

            return usuariosPartido;
        }

        public void AddUsuarioToPartido(int usuarioId, int partidoId)
        {
            var usuarioPartido = new UsuarioPartido
            {
                IdUser = usuarioId,
                IdPartido = partidoId
            };

            _context.UsuarioPartidos.Add(usuarioPartido);
            SaveChanges();
        }

        public void Update(Partido partido)
        {
            var existingPartido = _context.Partido.FirstOrDefault(p => p.IdPartido == partido.IdPartido);
            if (existingPartido != null)
            {
                existingPartido.Name = partido.Name;
                existingPartido.Estrellas = partido.Estrellas;
                existingPartido.Photo = partido.Photo;
                existingPartido.Duration = partido.Duration;
                existingPartido.Date = partido.Date;
                existingPartido.IdUser = partido.IdUser;

                _context.Entry(existingPartido).State = EntityState.Modified;

                SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Partido not found.");
            }
        }

        public void Delete(int partidoId)
        {
            var partido = Get(partidoId);
            if (partido is null)
            {
                throw new KeyNotFoundException("Partido not found.");
            }
            _context.Partido.Remove(partido);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<Partido> GetAll()
        {
            return _context.Partido.ToList();
        }
    }
}
