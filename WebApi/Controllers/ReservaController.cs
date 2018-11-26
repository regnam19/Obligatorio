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
                reservas[i].Hora = res.Hora;
                reservas[i].Fecha = res.Fecha;
                reservas[i].NombreProfesional = res.NombreProfesional;
                reservas[i].ApellidoProfesional = res.ApellidoProfesional;
                reservas[i].Consultorio = res.DireccionConsultorio;
                reservas[i].Estado = res.Estado;
                i++;
            }

            return reservas;
        }

        public IEnumerable<Reserva> GetHistorialReserva(long id)
        {
            Logica.Fachada fach = new Logica.Fachada();
            Reserva[] reservas = new Reserva[fach.historialReservaPaciente(id).LongCount()];
            int i = 0;
            foreach (var res in fach.historialReservaPaciente(id))
            {
                reservas[i] = new Reserva();
                reservas[i].IdReserva = res.IdReserva;
                reservas[i].Hora = res.Hora;
                reservas[i].Fecha = res.Fecha;
                reservas[i].NombreProfesional = res.NombreProfesional;
                reservas[i].ApellidoProfesional = res.ApellidoProfesional;
                reservas[i].Consultorio = res.DireccionConsultorio;
                reservas[i].Estado = res.Estado;
                i++;
            }

            return reservas;
        }

        
        public IHttpActionResult PostBorrarReserva(Reserva reserva)
        {
            Logica.Fachada fach = new Logica.Fachada();
            long idReserva = reserva.IdReserva;
            fach.cancelarReservaPaciente(idReserva);
            return Ok();
        }
    }
}
