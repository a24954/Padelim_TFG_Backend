using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFGBackend.Models
{
    public class Compra
    {
        [Key]
        public int IdCompra { get; set; }
        [Required]
        public int IdUser { get; set; }
        [Required]
        public int IdProducto { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public decimal PrecioTotal { get; set; }

        [ForeignKey("IdUser")]
        public virtual Usuario Usuario { get; set; }
        
        [ForeignKey("IdProducto")]
        public virtual Producto Producto { get; set; }
    }
}
