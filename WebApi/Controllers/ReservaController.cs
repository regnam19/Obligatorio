using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ReservaController : ApiController
    {
        public IEnumerable<Reserva> GetReserva(long id)
        {
            Logica.Fachada fach = new Logica.Fachada();
            Reserva[] reservas = new Reserva[fach.horasReservadasPaciente(id).LongCount()];
            int i = 0;
            foreach (var res in fach.horasReservadasPaciente(id))
            {
                reservas[i] = new Reserva();
                reservas[i].IdReserva = res.IdReserva;
                reservas[i].Hora = res.;
                reservas[i].Fecha = res.;
                reservas[i].NombreProfesional = res.;
                reservas[i].ApellidoProfesional = res.;
                reservas[i].Consultorio = res.;
                reservas[i].Estado = res.;
                i++;
            }

            return reservas;
        }
    }
}
