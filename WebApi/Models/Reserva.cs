using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Reserva
    {
        public long IdReserva { get; set; }
        public int Hora { get; set; }
        public DateTime Fecha { get; set; }
        public String NombreProfesional { get; set; }
        public String ApellidoProfesional { get; set; }
        public String Consultorio { get; set; }
        public sbyte Estado { get; set; }
    }
}
