using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TFGBackend.Models;


public class Partido
{
    [Key]
    public int IdPartido { get; set; }
    [Required]
    public string ? Name  { get; set; }
    [Required]
    public string ? Estrellas { get; set; }
    [Required]
    public string  ? Photo { get; set; }
    [Required]
    public string  ? Duration { get; set; }
    public decimal Price { get; set; }
    [Required]
    public DateTime  ? Date { get; set; }
    [Required]
    
    public int IdReservation { get; set; }

    public int IdUser {get; set; }
}