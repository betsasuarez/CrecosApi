using CrecosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CrecosApi.Data
{
    public class CrecosDbContext : DbContext
    {
        public CrecosDbContext()
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalle> DetallesDePedido { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
