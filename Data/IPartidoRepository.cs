using TFGBackend.Models;
using System.Collections.Generic;

namespace TFGBackend.Data
{
    public interface IPartidoRepository
    {
        List<Partido> GetAll();
        Partido? Get(int id);
        void Add(Partido partido);
        void Delete(int id);
        void Update(Partido partido);
        List<UsuarioPartidoDto> GetUsuariosPartido(int partidoId);  
        void AddUsuarioToPartido(int usuarioId, int partidoId);  

    }
}
