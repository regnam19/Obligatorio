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

        public VOHorarioDisponible(long idHorario, int hora, int idConsultorio)
        {
            this.IdHorario = idHorario;
            this.Hora = hora; 
            this.IdConsultorio = idConsultorio;
        }

        public VOHorarioDisponible() { }
    }
}
