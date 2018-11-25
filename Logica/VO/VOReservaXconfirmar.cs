using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.VO
{
    public class VOReservaXconfirmar
    {
        public long IdReserva { get; set; }
        public int Hora { get; set; }
        public DateTime Dia { get; set; }
        public String Consultorio { get; set; }
        public String NombrePaciente { get; set; }
        public String ApellidoPaciente { get; set; }

        public VOReservaXconfirmar() { }

        public VOReservaXconfirmar(long idReserva,int hora,DateTime dia, String consultorio, String nombrePaciente,String apellidoPaciente)
        {
            this.IdReserva = idReserva;
            this.Hora = hora;
            this.Dia = dia;
            this.Consultorio = consultorio;
            this.NombrePaciente = nombrePaciente;
            this.ApellidoPaciente = apellidoPaciente;
        }
    }
}
