using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Usuario
    {
        private long ci;
        private String nombre;
        private String apellido;
        private DateTime fechaNac;

        public long Ci { get { return this.ci; } }
        public String Nombre { get { return this.nombre; } }
        public String Apellido { get { return this.apellido; } }
        public DateTime FechaNac { get { return this.fechaNac; } }

        public String Celular { get; set; }
        public bool Habilitado { get; set; }

        public Usuario(long ci, String nombre, String apellido, DateTime fecha, String celular,bool habilitado)
        {
            this.ci = ci;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fecha;
            this.Celular = celular;
            this.Habilitado = habilitado;
        }

    }
}
