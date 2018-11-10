using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VOInsertarHorario
    {

        public int Hora { get; set; }
        public DateTime Dia { get; set; }
        public int IdConsultorio { get; set; }
        public long Profesional { get; set; }


        public VOInsertarHorario(int hora, DateTime dia, int idConsultorio, long ciProfesional)
        {
            this.Hora = hora;
            this.Dia = dia;
            this.IdConsultorio = idConsultorio;
            this.Profesional = ciProfesional;

        }

        public VOInsertarHorario() { }


    }
}
