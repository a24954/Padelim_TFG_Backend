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
    
    public DateTime  ? Date { get; set; }
    [Required]
    
    public int IdUser {get; set; }
}