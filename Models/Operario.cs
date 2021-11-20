using System.Collections.Generic;

namespace GestorApp.Models
{
    public class Operario
    {
        public int OperarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public virtual ICollection<Instalacion> Instalaciones { get; set; }
    }
}