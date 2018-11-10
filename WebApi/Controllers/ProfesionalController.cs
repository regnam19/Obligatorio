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
            var lista = fach.listaProfesionales();
            WebApi.Models.Profesional[] profesionales = new WebApi.Models.Profesional[lista.LongCount()];
            int i = 0;
            foreach(var prof in lista)
            {
                profesionales[i].nombre = prof.Nombre;
                profesionales[i].apellido = prof.Apellido;
                profesionales[i].fechaNacimiento = prof.FechaNac;
                profesionales[i].especialidad = prof.Especialidad;
                i++;
            }
            return profesionales;
            
        }
    }
}
