using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Consultorio
    {
        public int IdConsultorio { get; set; }
        public String Direccion { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }
    }
}