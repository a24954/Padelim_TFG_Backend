namespace TFGBackend.Models
{
    public class PistaSimpleDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Photo { get; set; }
        public string? Duration { get; set; }
        public decimal Price { get; set; }
        public DateTime? Date { get; set; }
    }
}