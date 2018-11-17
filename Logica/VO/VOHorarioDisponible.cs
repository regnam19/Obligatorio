using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VOHorarioDisponible
    {
        public long IdHorario { get; set; }
        public int Hora { get; set; }
        public int IdConsultorio { get; set; }
        public DateTime dia { get; set; }

        public VOHorarioDisponible(long idHorario, int hora, int idConsultorio, DateTime dia)
        {
            this.IdHorario = idHorario;
            this.Hora = hora; 
            this.IdConsultorio = idConsultorio;
            this.dia = dia;
        }

        public VOHorarioDisponible() { }
    }
}
