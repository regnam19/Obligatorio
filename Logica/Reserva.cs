using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Reserva
    {
        private long idReserva;
        private long idHorario;
        private long ciPaciente;

        public long IdHorario { get { return this.idHorario; } }
        public long CiPaciente { get { return this.ciPaciente; } }

        public sbyte Estado { get; set; }
        
        public Reserva() { }

        public Reserva(long idReserva,long idHorario,long ciPaciente,sbyte estado)
        {
            this.idReserva = idReserva;
            this.idHorario = idHorario;
            this.ciPaciente = ciPaciente;
            this.Estado = estado;
        }

    }
}
