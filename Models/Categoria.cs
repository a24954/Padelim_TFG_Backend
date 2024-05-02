using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TFGBackend.Models;


public class Categoria
{
    [Key]
    public int IdCategoria { get; set; }
    [Required]
    public string ? Tipo_Categoria  { get; set; }
}