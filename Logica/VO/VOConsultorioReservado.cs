using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.VO
{
    public class VOConsultorioReservado
    {
        public DateTime Dia { get; set; }
        public String Direccion { get; set; }
        public int Hora { get; set; }
        public long IdHorario { get; set; }

        public VOConsultorioReservado() { }

        public VOConsultorioReservado(DateTime dia, String direccion, int hora, long idhorario)
        {
            this.Dia = dia;
            this.Direccion = direccion;
            this.Hora = hora;
            this.IdHorario = idhorario;
        }
    }
}
