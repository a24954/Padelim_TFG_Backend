using TFGBackend.Data;
using TFGBackend.Models;

namespace TFGBackend.Business
{
    public class PartidoService : IPartidoService
    {
        private readonly IPartidoRepository _partidoRepository;

        public PartidoService(IPartidoRepository partidoRepository){

            _partidoRepository = partidoRepository;
            
        }
        public List<Partido> GetAll() => _partidoRepository.GetAll();

        public Partido? Get(int id) => _partidoRepository.Get(id);

        public void Add(Partido partido) => _partidoRepository.Add(partido);

        public void Delete(int id) => _partidoRepository.Delete(id);

        public void Update(Partido partido) => _partidoRepository.Update(partido);
    
    }
}
