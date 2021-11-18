using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorApp.Models
{
    public class Instalaciones
    {
        public int InstalacionesId { get; set; }
        public bool Exitosa { get; set; }
        public DateTime Fecha { get; set; }

        public int TelefonosID { get; set; }
        public virtual Telefonos Telefonos { get; set; }

        public int OperariosId { get; set; }
        public virtual Operarios Operarios { get; set; }

        public int AppsId { get; set; }
        public virtual Apps Apps { get; set; }
    }
}