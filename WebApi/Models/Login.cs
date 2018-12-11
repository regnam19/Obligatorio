using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Login
    {
        public Boolean Habilitado { get; set; }
        public Boolean Profesional { get; set; }
        public Boolean Paciente { get; set; }
        public Boolean Correcto { get; set; }

        public long Usuario { get; set; }
        public String Contrasena { get; set; }

    }
}