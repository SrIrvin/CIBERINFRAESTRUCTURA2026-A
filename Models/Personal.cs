using System;

namespace CIBERINFRAESTRUCTURA.Models
{
    public class Personal
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public DateTime FechaContratacion { get; set; }
        public bool Activo { get; set; }
    }
}
