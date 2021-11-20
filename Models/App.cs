using System.Collections.Generic;

namespace GestorApp.Models
{
    public class App
    {
        public int AppId { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Instalacion> Instalaciones { get; set; }
    }
}