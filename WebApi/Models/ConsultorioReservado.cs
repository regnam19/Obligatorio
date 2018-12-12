using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class ConsultorioReservado
    {
        public DateTime Dia { get; set; }
        public String Direccion { get; set; }
        public int Hora { get; set; }
        public long IdHorario { get; set; }
    }
}