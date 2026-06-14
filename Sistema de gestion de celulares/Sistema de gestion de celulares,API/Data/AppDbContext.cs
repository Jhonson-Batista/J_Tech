using Microsoft.EntityFrameworkCore;
using Sistema_de_gestion_de_celulares_API.Models;

namespace Sistema_de_gestion_de_celulares_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}