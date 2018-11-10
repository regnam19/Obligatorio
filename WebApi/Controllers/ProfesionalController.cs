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
    public class ProfesionalController : ApiController
    {
        // GET api/values
        public IEnumerable<WebApi.Models.Profesional> GetProfesioales()
        {
            Fachada fach = new Fachada();
            
            WebApi.Models.Profesional[] profesionales = new WebApi.Models.Profesional[fach.listaProfesionales().LongCount()];
            int i = 0;
            foreach(var prof in fach.listaProfesionales())
            {
                profesionales[i] = new Models.Profesional();
                profesionales[i].nombre = prof.Nombre;
                profesionales[i].apellido = prof.Apellido;
                profesionales[i].fechaNacimiento = prof.FechaNac;
                profesionales[i].especialidad = prof.Especialidad;
                i++;
            }
            return profesionales;
            
        }
        public WebApi.Models.Profesional GetProfesioales(long id)
        {
            Fachada fach = new Fachada();
            WebApi.Models.Profesional p = new WebApi.Models.Profesional();
            p.nombre = fach.darProfesional(id).Nombre;
            p.apellido = fach.darProfesional(id).Apellido;
            p.nombre = fach.darProfesional(id).Especialidad;
            return p;
        }


    }
}
