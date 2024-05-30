namespace TFGBackend.DTOs
{
    public class SesionSimpleDto
    {

        public int IdSesion { get; set; }
        public string SesionTime { get; set; }

        public DateTime SesionDate { get; set; }

        public int IdPista { get; set; }
    }
}