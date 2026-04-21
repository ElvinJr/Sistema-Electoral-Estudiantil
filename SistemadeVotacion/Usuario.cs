using System;

namespace Recursos
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public string Seccion { get; set; }
        public byte[] Contraseña { get; set; }
        public int RolID { get; set; }
        public int PadronID { get; set; }
    }
}