using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VOHorario
    {
        public long IdHorario { get; set; }
        public int Hora { get; set; }
        public DateTime Dia { get; set; }
        public int IdConsultorio { get; set; }
        public long Profesional { get; set; }
        public String Estado { get; set; }
        public long Paciente { get; set; }

        public VOHorario(long idHorario, int hora, DateTime dia, int idConsultorio, long ciProfesional, String estado, long ciPaciente)
        {
            this.IdHorario = idHorario;
            this.Hora = hora;
            this.Dia = dia;
            this.IdConsultorio = idConsultorio;
            this.Estado = estado;
            this.Profesional = ciProfesional;
            this.Paciente = ciPaciente;
        }

        public VOHorario() { }



    }
}
