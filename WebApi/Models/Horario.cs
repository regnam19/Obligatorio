﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Horario
    {
        public long IdHorario { get; set; }
        public int Hora { get; set; }
        public int IdConsultorio { get; set; }
        public DateTime Dia { get; set; }
        public long Cedula { get; set; }
        public String Direccion { get; set; }
    }
}