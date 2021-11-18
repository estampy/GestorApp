using System.Collections.Generic;

namespace GestorApp.Models
{
    public class Apps
    {
        public int AppsId { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Instalaciones> Instalaciones { get; set; }
    }
}
