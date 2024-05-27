using TFGBackend.DTOs;

namespace TFGBackend.Models
{
    public class ReservaResponseDto
    {
        public int IdReservation { get; set; }
        public string ReservationPrice { get; set; }
        public DateTime ReservationDate { get; set; }
       
        public SesionDto Sesion { get; set; }

        public UsuarioSimpleDto User { get; set; }
    }

}