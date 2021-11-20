using System.Collections.Generic;

namespace GestorApp.Models
{
    public class Telefono
    {
        public int TelefonoId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public virtual ICollection<Instalacion> Instalaciones { get; set; }
        public virtual ICollection<Sensor> Sensores { get; set; }
    }
}