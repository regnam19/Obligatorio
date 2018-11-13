using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VOPaciente
    {
        public long Ci { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public String Celular { get; set; }
        public bool Habilitado { get; set; }
        public String ContactoEmergencia { get; set; }
        public String EmergenciaMovil { get; set; }
        public String Mutualista { get; set; }

        public VOPaciente(long ci, String nombre, String apellido, DateTime fecha, String celular, bool habilitado, String contactoEmergencia, String emergenciaMovil, String mutualista)
                           
        {
            this.Ci = ci;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fecha;
            this.Celular = celular;
            this.Habilitado = habilitado;
            this.ContactoEmergencia = contactoEmergencia;
            this.EmergenciaMovil = emergenciaMovil;
            this.Mutualista = mutualista;
        }

        public VOPaciente() { }
    }
}
