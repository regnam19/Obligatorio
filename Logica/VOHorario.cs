using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class VOHorario
    {
        public long IdHorario { get; set; }
        public int Hora { get; set; }
        public DateTime Dia { get; set; }
        public int IdConsultorio { get; set; }
        public long Profesional { get; set; }
        public Enumerados.Estado Estado { get; set; }
        public long Paciente { get; set; }

        public VOHorario(long idHorario, int hora, DateTime dia, int idConsultorio, long ciProfesional)
        {
            this.IdHorario = idHorario;
            this.Hora = hora;
            this.Dia = dia;
            this.IdConsultorio = idConsultorio;
            this.Estado = Enumerados.Estado.disponible;
            this.Profesional = ciProfesional;
        }

        public VOHorario() { }



    }
}
