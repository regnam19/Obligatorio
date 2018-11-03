using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Paciente : Usuario
    {
        public String Direccion { get; set; }
        public long CelularEmergencia { get; set; }
        public String ContactoEmergencia { get; set; }
        public String EmergenciaMovil { get; set; }
        public String Mutualista { get; set; }

        public Paciente (long ci, String nombre, String apellido,DateTime fecha, String celular, bool habilitado,
                            String direccion, long celularEmergencia,String contactoEmergencia,String emergenciaMovil,String mutualista)
                            : base (ci, nombre, apellido, fecha, celular, habilitado)
        {
            this.Direccion = direccion;
            this.CelularEmergencia = celularEmergencia;
            this.ContactoEmergencia = contactoEmergencia;
            this.EmergenciaMovil = emergenciaMovil;
            this.Mutualista = mutualista;
        }

    }
}
