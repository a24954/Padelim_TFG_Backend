using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TFGBackend.Models;


public class PistaDto
{
    [Key]
    public int IdPista { get; set; }
    [Required]
    public string ? Name  { get; set; }
    [Required]
    public string  ? Duration { get; set; }
    public decimal Price { get; set; }
    

    

}