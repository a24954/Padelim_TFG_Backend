using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFGBackend.Models
{
    public class UsuarioPartido
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Usuario")]
        public int IdUser { get; set; }
        public Usuario Usuario { get; set; }

        [ForeignKey("Partido")]
        public int IdPartido { get; set; }
        public Partido Partido { get; set; }
    }
}
