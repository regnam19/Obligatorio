using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica 
{
    public class Admin : Persona
    {
        public Admin(long ci, String nombre, String apellido, DateTime fecha, String celular, String direccion, bool habilitado, String contrasena) : base(ci, nombre, apellido, fecha, celular, direccion, habilitado, contrasena)
        {
           
        }
    }
}
