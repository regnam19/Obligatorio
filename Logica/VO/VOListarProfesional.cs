using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VOListarProfesional
    {
        public long Cedula { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public String Especialidad { get; set; }


        public VOListarProfesional(long cedula, String nombre, String apellido, DateTime fecha,String especialidad)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fecha;
            this.Especialidad = especialidad;
        }

        public VOListarProfesional() { }
    }
}
