using TFGBackend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace TFGBackend.Data
{
    public class UsuarioEFRepository : IUsuarioRepository
    {
        private readonly TFGContext _context;

        public UsuarioEFRepository(TFGContext context)
        {
            _context = context;
        }

        public void Add(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            SaveChanges();
        }

        public UsuarioSimpleDto? Get(int usuarioId)
        {
            return _context.Usuarios
                .Where(usuario => usuario.IdUser == usuarioId)
                .Select(r => new UsuarioSimpleDto
                {
                    UserName = r.UserName,
                    Password = r.Password,
                })
                .FirstOrDefault();
        }

        public List<PartidoUsuarioDto> GetPartidosUsuario(int usuarioId)
        {
            var partidosUsuario = _context.Partido
                .Where(p => p.IdUser == usuarioId)
                .Select(p => new PartidoUsuarioDto
                {
                    NombrePartido = p.Name,
                    Estrellas = p.Estrellas,
                    Duracion = p.Duration,
                    Fecha = p.Date,
                    UserName = _context.Usuarios.FirstOrDefault(u => u.IdUser == usuarioId).UserName
                })
                .ToList();

            return partidosUsuario;
        }

        public void Update(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            SaveChanges();
        }

        public Usuario? GetForUpdate(int IdUser)
        {
            return _context.Usuarios.FirstOrDefault(p => p.IdUser == IdUser);
        }


        public void Delete(int usuarioId)
        {
            var usuario = _context.Usuarios.Find(usuarioId);
            if (usuario is null)
            {
                throw new KeyNotFoundException("Account not found.");
            }
            _context.Usuarios.Remove(usuario);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }
    }
}
