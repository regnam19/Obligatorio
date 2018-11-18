using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Profesional
    {
        public long cedula { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String especialidad { get; set; }
    }
}