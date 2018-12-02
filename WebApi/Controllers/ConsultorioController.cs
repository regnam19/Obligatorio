using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ConsultorioController : ApiController
    {
        public IEnumerable<Consultorio> GetConsultorios()
        {
            Logica.Fachada fach = new Logica.Fachada();

            Consultorio[] consultorios = new Consultorio[fach.listarConsultorios().LongCount()];
            int i = 0;
            foreach (var con in fach.listarConsultorios())
            {
                consultorios[i] = new Consultorio();
                consultorios[i].IdConsultorio = con.IdConsultorio;
                consultorios[i].Direccion = con.Direccion;
                consultorios[i].HoraInicio = con.HoraInicio;
                consultorios[i].HoraFin = con.HoraFin;
                i++;
            }
            return consultorios;

        }


        [Route("~/api/ReservasXconfirmar/ConfirmarReserva/{idReserva:long}")]
        [HttpGet]
        public IHttpActionResult GetConfirmarReserva(long idReserva)
        {
            Logica.Fachada fach = new Logica.Fachada();
            fach.aceptarReserva(idReserva);
            return Ok();
        }

        [Route("~/api/ReservasXconfirmar/RechazarReserva/{idReserva:long}")]
        [HttpGet]
        public IHttpActionResult GetRechazarReserva(long idReserva)
        {
            Logica.Fachada fach = new Logica.Fachada();
            fach.rechazarReserva(idReserva);
            return Ok();
        }
    }
}
