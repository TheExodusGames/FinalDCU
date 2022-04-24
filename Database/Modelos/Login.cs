using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Modelos
{
    public class Login
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string User { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }

    }
}
