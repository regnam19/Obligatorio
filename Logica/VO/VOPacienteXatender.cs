using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.VO
{
    public class VOPacienteXatender
    {
        public DateTime Dia { get; set; }
        public int Hora { get; set; }
        public String Direccion { get; set; }
        public String NombrePaciente { get; set; }
        public String ApellidoPaciente { get; set; }

        public VOPacienteXatender() { }


        public VOPacienteXatender(DateTime dia, int hora, String direccion , String nombre, String apellido)
        {
            this.Dia = dia;
            this.Hora = hora;
            this.Direccion = direccion;
            this.NombrePaciente = nombre;
            this.ApellidoPaciente = apellido;
        }
    }
}
