using TFGBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace TFGBackend.Data
{
    public class CategoriaEFRepository : ICategoriaRepository
    {
        private readonly TFGContext _context;

        public CategoriaEFRepository(TFGContext context)
        {
            _context = context;
        }

        public void Add(Categoria categoria)
        {
            _context.Categoria.Add(categoria);
            SaveChanges();
        }

        public Categoria? Get(int categoriaId)
        {
            return _context.Categoria.FirstOrDefault(categoria => categoria.IdCategoria == categoriaId);
        }

        public void Update(Categoria categoria)
        {
            var existingCategoria = _context.Categoria.Find(categoria.IdCategoria);
            if (existingCategoria != null)
            {
                existingCategoria.Tipo_Categoria = categoria.Tipo_Categoria;

                _context.Entry(existingCategoria).State = EntityState.Modified;
                SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Categoria not found.");
            }
        }

        public void Delete(int categoriaId)
        {
            var categoria = Get(categoriaId);
            if (categoria is null)
            {
                throw new KeyNotFoundException("Categoria not found.");
            }
            _context.Categoria.Remove(categoria);
            SaveChanges();
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<Categoria> GetAll()
        {
            return _context.Categoria.ToList();
        }
    }
}