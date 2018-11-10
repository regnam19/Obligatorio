using WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Logica;

namespace WebApi.Controllers
{
    public class HorarioController : ApiController
    {

        public IHttpActionResult PostHorario(WebApi.Models.Horario horario)
        {
            Fachada fach = new Fachada();
            long cedula = horario.cedula;
            long idHorario = horario.fecha;
            VOHorarioInsertarPaciente vo = new VOHorarioInsertarPaciente(idHorario, cedula);
            fach.reservaProfesional(vo);
            return Ok();
        }
    }
}
