using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.VO
{
    public class VOReservasPaciente
    {
        public long IdReserva { get; set; }
        public DateTime Fecha { get; set; }
        public int Hora { get; set; }
        public sbyte Estado { get; set; }
        public String NombreProfesional { get; set; }
        public String ApellidoProfesional { get; set; }
        public String DireccionConsultorio { get; set; }

        public VOReservasPaciente() { }

        public VOReservasPaciente(long idReserva, DateTime fecha, int hora, sbyte estado,String nombreProfesional,String apellidoProfesional,String direccionConsultorio)
        {
            this.IdReserva = idReserva;
            this.Fecha = fecha;
            this.Hora = hora;
            this.Estado = estado;
            this.NombreProfesional = nombreProfesional;
            this.ApellidoProfesional = apellidoProfesional;
            this.DireccionConsultorio = direccionConsultorio;
        }
    }
}
