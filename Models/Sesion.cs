using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TFGBackend.Models;


public class Sesion
{
    [Key]
    public int IdSesion { get; set; }
    [Required]
    public string SesionTime { get; set; }
    public int IdPista { get; set; }
}
