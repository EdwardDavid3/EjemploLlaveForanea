using EjemploLlaveForanea.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EjemploLlaveForanea
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Moneda>().HasKey(e => e.IdMoneda);
            modelBuilder.Entity<Moneda>().Property(e => e.NombreMoneda).HasMaxLength(70);

            modelBuilder.Entity<Pais>().HasKey(e => e.IdPais);
            modelBuilder.Entity<Pais>().Property(e => e.NombrePais).HasMaxLength(70);
        }
        public DbSet<Moneda> Monedas { get; set; }
        public DbSet<Pais> Paises { get; set; }

    }
}
