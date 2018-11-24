using WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebApi.Controllers
{
    public class HorarioController : ApiController
    {
        // GET api/values


        public IEnumerable<Horario> GetHorario(long id)
        {
            
            Logica.Fachada fach = new Logica.Fachada();

            Horario[] horarios = new Horario[fach.horasLibresProfesional(id).LongCount()];
            int i = 0;
            foreach (var hor in fach.horasLibresProfesional(id))
            {
                horarios[i] = new Horario();
                horarios[i].IdHorario = hor.IdHorario;
                horarios[i].Hora = hor.Hora;
                horarios[i].IdConsultorio = hor.IdConsultorio;
                horarios[i].Dia = hor.dia;
                horarios[i].Cedula = id;
                i++;
            }
            
            return horarios;

        }

        public IHttpActionResult PostHorario(Horario horario)
        {
            
            Console.WriteLine("Estoy2");
            Logica.Fachada fach = new Logica.Fachada();
            long cedula = horario.Cedula;
            long idHorario = horario.IdHorario;
            Logica.VOHorarioInsertarPaciente vo = new Logica.VOHorarioInsertarPaciente(idHorario, cedula);
            fach.reservaProfesional(vo);
            return Ok();
        }

        //Horarios libres
        
    }
}
