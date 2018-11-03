using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VOConsultorio
    {

        public int IdConsultorio { get; set; }
        public String Direccion { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }


        public VOConsultorio(int idConsultorio, String direccion, int horaInicio, int horaFin)
        {
            this.IdConsultorio = idConsultorio;
            this.Direccion = direccion;
            this.HoraInicio = horaInicio;
            this.HoraFin = horaFin;
        }

        public VOConsultorio() { }
    }
}
