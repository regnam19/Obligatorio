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
    public class ReservasXconfirmarController : ApiController
    {
        public IEnumerable<ReservasXconfirmar> GetReservasXconfirmar(long id)
        {
            Logica.Fachada fach = new Logica.Fachada();

            ReservasXconfirmar[] reservas = new ReservasXconfirmar[fach.reservasXconfirmar(id).LongCount()];
            int i = 0;
            foreach(var r in fach.reservasXconfirmar(id))
            {
                reservas[i] = new ReservasXconfirmar();
                reservas[i].IdReserva = r.IdReserva;
                reservas[i].Dia = r.Dia;
                reservas[i].Hora = r.Hora;
                reservas[i].Consultorio = r.Consultorio;
                reservas[i].NombrePaciente = r.NombrePaciente;
                reservas[i].ApellidoPaciente = r.ApellidoPaciente;
                i++;
            }
            return reservas;
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


