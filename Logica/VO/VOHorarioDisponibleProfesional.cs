using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.VO
{
    public class VOHorarioDisponibleProfesional
    {
        public long IdHorario { get; set; }
        public int Hora { get; set; }
        public int IdConsultorio { get; set; }
        public DateTime dia { get; set; }
        public String Direccion { get; set; }

        public VOHorarioDisponibleProfesional(long idHorario, int hora, int idConsultorio, DateTime dia, String direccion)
        {
            this.IdHorario = idHorario;
            this.Hora = hora;
            this.IdConsultorio = idConsultorio;
            this.dia = dia;
            this.Direccion = direccion;
        }

        public VOHorarioDisponibleProfesional() { }
    }
}
