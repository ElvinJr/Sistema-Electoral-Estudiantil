using System;

namespace Recursos
{
    public class VotosAudit
    {
        public int AuditID { get; set; }
        public int VotoID { get; set; }
        public int UsuarioID { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
