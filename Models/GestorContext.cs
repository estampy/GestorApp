using Microsoft.EntityFrameworkCore;

namespace GestorApp.Models
{
    public class GestorContext : DbContext
    {
        public GestorContext(DbContextOptions<GestorContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<GestorApp.Models.Instalacion> Instalaciones { get; set; }
        public DbSet<GestorApp.Models.Operario> Operarios { get; set; }
        public DbSet<GestorApp.Models.App> Apps { get; set; }
        public DbSet<GestorApp.Models.Telefono> Telefonos { get; set; }
        public DbSet<GestorApp.Models.Sensor> Sensores { get; set; }
    }

}
