using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Horario
    {
        private long idHorario;
        private int hora;
        private DateTime dia;
        private int idConsultorio;
        private long ciProfesional;



        public long IdHorario { get { return this.idHorario; } }
        public int Hora { get { return this.hora; } }
        public DateTime Dia { get { return this.dia; } }
        public int IdConsultorio { get { return this.idConsultorio; } }
        public long CiProfesional { get { return this.ciProfesional; } }



        public sbyte Estado { get; set; }
        public long Paciente { get; set; }

        public Horario (long idHorario, int hora, DateTime dia,int idConsultorio,long ciProfesional,sbyte estado)
        {
            this.idHorario = idHorario;
            this.hora = hora;
            this.dia = dia;
            this.idConsultorio = idConsultorio;
            this.Estado = estado;
            this.ciProfesional = ciProfesional;
        }

    
    }
}
