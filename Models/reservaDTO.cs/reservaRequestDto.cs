namespace TFGBackend.Models
{
    public class ReservaRequestDto
    {

        public int IdUser { get; set; }

        public int IdSesion { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ReservationPrice { get; set; }
    }

}