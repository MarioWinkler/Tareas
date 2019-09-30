using System;
using System.Collections.Generic;

namespace Tareabd.Models
{
    public partial class Persona
    {
        public long IdPersona { get; set; }
        public string Rfc { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Email { get; set; }
    }
}
