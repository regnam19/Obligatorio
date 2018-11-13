using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VOPersona
    {
       
        public long Ci { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Celular { get; set; }
        public DateTime FechaNac { get; set; }
        public String Direccion { get; set; }
        public bool Habilitado { get; set; }
        public int IdUsuario { get; set; }

        public VOPersona(long ci, String nombre, String apellido, String celular, DateTime fechaNac, String direccion, bool habilitado, int idUsuario)
        {
            this.Ci = ci;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Celular = celular;
            this.FechaNac = fechaNac;
            this.Direccion = direccion;
            this.Habilitado = habilitado;
            this.IdUsuario = IdUsuario;
        }

        public VOPersona() { }
    }
}
