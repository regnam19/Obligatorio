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
        // GET api/values
        public IEnumerable<WebApi.Models.Horario> GetHorario(long id)
        {
            Fachada fach = new Fachada();

            WebApi.Models.Horario[] horarios = new WebApi.Models.Horario[fach.horasLibresProfesional(id).LongCount()];
            int i = 0;
            foreach (var hor in fach.horasLibresProfesional(id))
            {
                horarios[i] = new Models.Horario();
                horarios[i].IdHorario = hor.IdHorario;
                horarios[i].Hora = hor.Hora;
                horarios[i].IdConsultorio = hor.IdConsultorio;
                horarios[i].Dia = hor.dia;
                i++;
            }
            return horarios;

        }

        /*public IHttpActionResult PostHorario(WebApi.Models.Horario horario)
        {
            
            Console.WriteLine("Estoy2");
            Fachada fach = new Fachada();
            long cedula = horario.cedula;
            long idHorario = horario.fecha;
            VOHorarioInsertarPaciente vo = new VOHorarioInsertarPaciente(idHorario, cedula);
            fach.reservaProfesional(vo);
            return Ok();
        }*/

        //Horarios libres
        
    }
}
