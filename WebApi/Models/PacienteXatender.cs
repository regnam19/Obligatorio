using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class PacienteXatender
    {
        public DateTime Dia { get; set; }
        public int Hora { get; set; }
        public String Direccion { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
    }
}