using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Paciente : Persona
    {
        public String ContactoEmergencia { get; set; }
        public String EmergenciaMovil { get; set; }
        public String Mutualista { get; set; }

        public Paciente (long ci, String nombre, String apellido,DateTime fecha, String celular, bool habilitado, int idUsuario,
                            String direccion,String contactoEmergencia,String emergenciaMovil,String mutualista)
                            : base (ci, nombre, apellido, fecha, celular, direccion, habilitado, idUsuario)
        {
            this.ContactoEmergencia = contactoEmergencia;
            this.EmergenciaMovil = emergenciaMovil;
            this.Mutualista = mutualista;
        }

    }
}
