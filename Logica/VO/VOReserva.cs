using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.VO
{
    public class VOReserva
    {
        public long IdReserva { get; set; }
        public long IdHorario { get; set; }
        public long CiPaciente { get; set; }
        public sbyte Estado { get; set; }

        public VOReserva() { }

        public VOReserva(long idReserva,long idHorario,long ciPaciente,sbyte estado)
        {
            this.IdHorario = idHorario;
            this.CiPaciente = CiPaciente;
            this.Estado = estado;
        }
    }
}
