using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorApp.Models
{
    public class Telefonos
    {
        public int TelefonosId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public virtual ICollection<Sensores> Sensores { get; set; }
    }
}