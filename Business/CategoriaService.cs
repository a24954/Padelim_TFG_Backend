using TFGBackend.Data;
using TFGBackend.Models;

namespace TFGBackend.Business
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository){

            _categoriaRepository = categoriaRepository;
            
        }
        public List<Categoria> GetAll() => _categoriaRepository.GetAll();

        public Categoria? Get(int id) => _categoriaRepository.Get(id);

        public void Add(Categoria categoria) => _categoriaRepository.Add(categoria);

        public void Delete(int id) => _categoriaRepository.Delete(id);

        public void Update(Categoria categoria) => _categoriaRepository.Update(categoria);
    
    }
}
