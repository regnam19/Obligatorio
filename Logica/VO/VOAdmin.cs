using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VOAdmin
    {
        public long Ci { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public String Direccion { get; set; }
        public String Celular { get; set; }
        public bool Habilitado { get; set; }

        public VOAdmin(long ci, String nombre, String apellido, DateTime fecha, String celular, String direccion, bool habilitado)
        {
            this.Ci = ci;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fecha;
            this.Celular = celular;
            this.Direccion = direccion;
            this.Habilitado = habilitado;
       
        }

        public VOAdmin() { }
    }
}
