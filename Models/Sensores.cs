using System.Collections.Generic;

namespace GestorApp.Models
{
    public class Sensores
    {
        public int SensoresId { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<TelefonosSensores> TelSen { get; set; }
    }
}