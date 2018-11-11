using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VOHorarioReservadoProfesional
    {
        public long IdHorario { get; set; }
        public int Hora { get; set; }
        public DateTime Dia { get; set; }
        public int IdConsultorio { get; set; }
        public String Estado { get; set; }
        public long Paciente { get; set; }

        public VOHorarioReservadoProfesional(long idHorario, int hora, DateTime dia, int idConsultorio, String estado, long ciPaciente)
        {
            this.IdHorario = idHorario;
            this.Hora = hora;
            this.Dia = dia;
            this.IdConsultorio = idConsultorio;
            this.Estado = estado;
            this.Paciente = ciPaciente;
        }

        public VOHorarioReservadoProfesional() { }
    }
}
