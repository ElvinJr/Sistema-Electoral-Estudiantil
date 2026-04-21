using System;

namespace Recursos
{
    public class Usuarios
    {
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public string Seccion { get; set; }
        public byte[] Contraseña { get; set; }   // hash o bytes
        public int RolID { get; set; }
        public int PadronID { get; set; }
    }
}
