using Microsoft.EntityFrameworkCore;
using TuorBrasil_API.Models;

namespace TuorBrasil_API.Context
{
     public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Passagem> Passagem { get; set; }
    }
}
