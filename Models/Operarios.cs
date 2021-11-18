using System.Collections.Generic;

namespace GestorApp.Models
{
    public class Operarios
    {
        public int OperariosId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public virtual ICollection<Instalaciones> Instalaciones { get; set; }
    }
}