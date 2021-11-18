using System.Collections.Generic;

namespace GestorApp.Models
{
    public class Telefonos
    {
        public int TelefonosId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public virtual ICollection<TelefonosSensores> TelSen { get; set; }
        public virtual ICollection<Instalaciones> Instalaciones { get; set; }
    }
}