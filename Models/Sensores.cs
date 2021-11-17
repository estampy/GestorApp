using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorApp.Models
{
    public class Sensores
    {
        public int SensoresId { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Telefonos> Telefonos { get; set; }
    }
}