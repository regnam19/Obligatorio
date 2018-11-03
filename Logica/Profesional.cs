using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Profesional : Usuario
    {
        public String Especialidad { get; set; }

        public Profesional(long ci, String nombre, String apellido, DateTime fecha, String celular, bool habilitado,String especialidad) : base(ci, nombre, apellido, fecha, celular, habilitado)
        {
            this.Especialidad = especialidad;
        }


    }
}
