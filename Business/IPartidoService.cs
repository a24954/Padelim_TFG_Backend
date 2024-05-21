using TFGBackend.Models;
using System.Collections.Generic;

namespace TFGBackend.Business
{
    public interface IPartidoService
    {
        List<Partido> GetAll();
        Partido? Get(int id);
        void Add(Partido partido);
        void Delete(int id);
        void Update(Partido partido);
        List<UsuarioPartidoDto> GetUsuariosPartido(int partidoId);  
    }
}
