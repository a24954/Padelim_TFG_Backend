using TFGBackend.Data;
using TFGBackend.Models;
using System.Collections.Generic;

namespace TFGBackend.Business
{
    public class PartidoService : IPartidoService
    {
        private readonly IPartidoRepository _partidoRepository;

        public PartidoService(IPartidoRepository partidoRepository)
        {
            _partidoRepository = partidoRepository;
        }

        public List<Partido> GetAll() => _partidoRepository.GetAll();

        public Partido? Get(int id) => _partidoRepository.Get(id);

        public void Add(Partido partido) => _partidoRepository.Add(partido);

        public void Delete(int id) => _partidoRepository.Delete(id);

        public void Update(Partido partido) => _partidoRepository.Update(partido);

        public List<UsuarioPartidoDto> GetUsuariosPartido(int partidoId)
        {
            return _partidoRepository.GetUsuariosPartido(partidoId);
        }

        public void AddUsuarioToPartido(int usuarioId, int partidoId, int position)
        {
            _partidoRepository.AddUsuarioToPartido(usuarioId, partidoId, position);
        }
        public void DeleteUserFromPartido(int usuarioId, int partidoId)
        {
            _partidoRepository.DeleteUserFromPartido(usuarioId, partidoId);
        }
    }
}
