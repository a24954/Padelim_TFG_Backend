using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TFGBackend.Models;


public class Producto
{
    [Key]
    public int IdProduct { get; set; }
    [Required]
    public string Name_Product { get; set; }
    [Required]
    public string Product_Price { get; set; }
    [Required]
    public string Product_Description { get; set; }
    [Required]
    public string Product_Amount { get; set; }

    public int IdCategoria { get; set; }

}