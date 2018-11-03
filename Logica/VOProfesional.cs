using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VOProfesional
    {
        public long Ci { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public String Celular { get; set; }
        public bool Habilitado { get; set; }
        public String Especialidad { get; set; }


        public VOProfesional(long ci, String nombre, String apellido, DateTime fecha, String celular, bool habilitado,String especialidad)
        {
            this.Ci = ci;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fecha;
            this.Celular = celular;
            this.Habilitado = habilitado;
            this.Especialidad = especialidad;
        }

        public VOProfesional() { }
    }
}
