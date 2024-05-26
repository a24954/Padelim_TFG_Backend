using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFGBackend.Models
{
    public class Reserva
    {
        [Key]
        public int IdReservation { get; set; }

        [Required]
        public string ReservationPrice { get; set; }

        [Required]
        public DateTime ReservationDate { get; set; }

        [ForeignKey("Pista")]
        public int IdPista { get; set; }
        public Pista Pista { get; set; }

        [ForeignKey("Sesion")]
        public int IdSesion { get; set; }
        public Sesion Sesion { get; set; }

        [ForeignKey("Usuario")]
        public int IdUser { get; set; }
        public Usuario Usuario { get; set; }
    }
}
