using System.Collections.Generic;

namespace GestorApp.Models
{
    public class Sensor
    {
        public int SensorId { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Telefono> Telefonos { get; set; }
    }
}