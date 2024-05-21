using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TFGBackend.Models;


public class Usuario
{
    [Key]
        public int IdUser { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public UserRole Rol { get; set; }

        public enum UserRole
        {
            Admin = 1,
            StandardUser = 2
        }

        public virtual ICollection<Reserva> Reserva { get; set; } = new List<Reserva>(); 

        public int IdPartido { get; set; } 

        public int IdProducto { get; set; }
}