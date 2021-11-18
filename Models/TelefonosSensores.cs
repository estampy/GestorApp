namespace GestorApp.Models
{
    public class TelefonosSensores
    {
        public int Id { get; set; }
        public int TelefonosId { get; set; }
        public virtual Telefonos Telefonos { get; set; }
        public int SensoresId { get; set; }
        public virtual Sensores Sensores { get; set; }
    }
}