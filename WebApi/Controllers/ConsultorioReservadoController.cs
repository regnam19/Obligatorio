using Logica.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ConsultorioReservadoController : ApiController
    {
        public IEnumerable<ConsultorioReservado> GetConsultorioReservado(long id)
        {

            Logica.Fachada fach = new Logica.Fachada();

            ConsultorioReservado[] horarios = new ConsultorioReservado[fach.consultorioReservado(id).LongCount()];
            int i = 0;
            foreach (var hor in fach.consultorioReservado(id))
            {
                horarios[i] = new ConsultorioReservado();
                horarios[i].IdHorario = hor.IdHorario;
                horarios[i].Hora = hor.Hora;
                horarios[i].Dia = hor.Dia;
                horarios[i].Direccion = hor.Direccion;
                i++;
            }

            return horarios;

        }
    }
}
