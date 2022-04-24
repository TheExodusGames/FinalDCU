using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Modelos
{
    public class Cita
    {
        public int id { get; set; }
        public int Id_Pacientes { get; set; }
        public int Id_Medico { get; set; }
        public DateTime FechayHora { get; set; }
        public string Causa { get; set; }
        public string Estado { get; set; }
    }
}
