using System.ComponentModel.DataAnnotations.Schema;

namespace app2game.Models
{
    [Table("t_carrito")]
    public class Carrito
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? UserName { get; set; }
        public Producto? Producto { get; set; }
        public int Cantidad { get; set; }
        public Decimal Precio { get; set; }
        public string Status { get; set; } ="PENDIENTE";
    }
}