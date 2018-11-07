using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VOHorarioInsertarPaciente
    {
        public long IdHorario { get; set; }
        public long CiPaciente { get; set; }

        public VOHorarioInsertarPaciente(long idHorario, long ciPaciente)
        {
            this.IdHorario = idHorario;
            this.CiPaciente = ciPaciente;
        }

        public VOHorarioInsertarPaciente() { }
    }
}
