using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public DbSet<GestorApp.Models.Instalaciones> Instalaciones { get; set; }
        public DbSet<GestorApp.Models.Operarios> Operarios { get; set; }
        public DbSet<GestorApp.Models.Apps> Apps { get; set; }
        public DbSet<GestorApp.Models.Telefonos> Telefonos { get; set; }
        public DbSet<GestorApp.Models.Sensores> Sensores { get; set; }
    }
    
}
