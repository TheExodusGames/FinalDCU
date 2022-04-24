using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Modelos
{
    public class ResultadoPrueba
    {
        public int id { get; set; }
        public int Id_Pacientes { get; set; }
        public int Id_Cita { get; set; }
        public int Id_PruebaLab { get; set; }
        public int Id_Medico { get; set; }
        public string Resultados { get; set; }
        public string Estadoresult { get; set; }
    }
}
