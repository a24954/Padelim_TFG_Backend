namespace TFGBackend.Models
{
    public class ReservaResponseDto
    {
        public int IdReservation { get; set; }
        public string ReservationPrice { get; set; }
        public DateTime ReservationDate { get; set; }
        public int IdPista { get; set; }
        public int IdSesion { get; set; }
        public string PistaName { get; set; }
        public string SesionTime { get; set; }
    }

}