using System;

namespace GestorApp.Models
{
    public class Instalacion
    {
        public int InstalacionId { get; set; }
        public bool Exitosa { get; set; }
        public DateTime Fecha { get; set; }

        public int TelefonoId { get; set; }
        public virtual Telefono Telefonos { get; set; }

        public int OperarioId { get; set; }
        public virtual Operario Operarios { get; set; }

        public int AppId { get; set; }
        public virtual App Apps { get; set; }
    }
}