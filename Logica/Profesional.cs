using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Profesional : Persona
    {
        public String Especialidad { get; set; }

        public Profesional(long ci, String nombre, String apellido, DateTime fecha, String celular, String direccion, bool habilitado,String especialidad) : base(ci, nombre, apellido, fecha, celular, direccion, habilitado)
        {
            this.Especialidad = especialidad;
        }


    }
}
