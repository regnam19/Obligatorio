using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class ReservasXconfirmar
    {
        public long IdReserva { get; set; }
        public int Hora { get; set; }
        public DateTime Dia { get; set; }
        public String Consultorio { get; set; }
        public String NombrePaciente { get; set; }
        public String ApellidoPaciente { get; set; }

    }
}