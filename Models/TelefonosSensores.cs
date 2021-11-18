using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorApp.Models
{
    public class TelefonosSensores
    {
        public int Id { get; set; }
        public int TelefonosId { get; set; }
        public int SensoresId { get; set; }
    }
}
