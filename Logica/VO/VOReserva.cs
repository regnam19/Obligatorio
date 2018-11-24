using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.VO
{
    public class VOReserva
    {
        
        public long IdHorario { get; set; }
        public long CiPaciente { get; set; }
        public String Estado { get; set; }

        public VOReserva() { }

        public VOReserva(long idHorario,long ciPaciente,String estado)
        {
            this.IdHorario = idHorario;
            this.CiPaciente = CiPaciente;
            this.Estado = estado;
        }
    }
}
