using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Consultorio
    {
        private int idConsultorio;
        private String direccion;

        public int IdConsultorio { get { return idConsultorio; } }
        public String Direccion { get { return direccion; } }

        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }


        public Consultorio(int idConsultorio, String direccion, int horaInicio, int horaFin)
        {
            this.idConsultorio = idConsultorio;
            this.direccion = direccion;
            this.HoraInicio = horaInicio;
            this.HoraFin = horaFin;
        }
    }
}
