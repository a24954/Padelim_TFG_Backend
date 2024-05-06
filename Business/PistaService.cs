using TFGBackend.Data;
using TFGBackend.Models;

namespace TFGBackend.Business
{
    public class PistaService : IPistaService
    {
        private readonly IPistaRepository _pistaRepository;

        public PistaService(IPistaRepository pistaRepository){

            _pistaRepository = pistaRepository;
            
        }
        public List<Pista> GetAll() => _pistaRepository.GetAll();

        public Pista? Get(int id) => _pistaRepository.Get(id);

        public void Add(Pista pista) => _pistaRepository.Add(pista);

        public void Delete(int id) => _pistaRepository.Delete(id);

        public void Update(Pista pista) => _pistaRepository.Update(pista);
    
    }
}
