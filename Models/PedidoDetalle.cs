using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrecosApi.Models
{
    public class PedidoDetalle
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Pedido))]
        public int PedidoId { get; set; }

        [ForeignKey(nameof(Producto))]
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
    }
}
