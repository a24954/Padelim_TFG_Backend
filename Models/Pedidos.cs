using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TFGBackend.Models;


public class Pedidos
{
    [Key]
    public int IdPedidos { get; set; }
    [Required]
    public DateTime Fe_Inicio { get; set; }
    [Required]
    public double Total_Price { get; set; }
    [Required]
    public string Estado { get; set; }

    public int IdProduct { get; set; }

}