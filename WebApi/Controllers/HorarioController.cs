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

            //Logica.Fachada fach = new Logica.Fachada();
            Logica.IFachada fach = new Logica.Fachada();

            Horario[] horarios = new Horario[fach.horasLibresProfesional(id).LongCount()];
            int i = 0;
            foreach (var hor in fach.horasLibresProfesional(id))
            {
                horarios[i] = new Horario();
                horarios[i].IdHorario = hor.IdHorario;
                horarios[i].Hora = hor.Hora;
                horarios[i].IdConsultorio = hor.IdConsultorio;
                horarios[i].Dia = hor.dia;
                horarios[i].Direccion = hor.Direccion;
                horarios[i].Cedula = id;
                i++;
            }
            
            return horarios;

        }

        public IEnumerable<Horario> GetHorariosLibres(long id)
        {

            //Logica.Fachada fach = new Logica.Fachada();
            Logica.IFachada fach = new Logica.Fachada();

            Horario[] horarios = new Horario[fach.listarHorariosLibresProfeisonal(id).LongCount()];
            int i = 0;
            foreach (var hor in fach.listarHorariosLibresProfeisonal(id))
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

        public IEnumerable<int> PostHorariosDisponibles(Horario horario)
        {


            //Logica.Fachada fach = new Logica.Fachada();
            Logica.IFachada fach = new Logica.Fachada();

            int[] horarios = new int[fach.horariosDisponiblesConsultorio(horario.IdConsultorio,horario.Dia).LongCount()];
            int i = 0;
            foreach (var hor in fach.horariosDisponiblesConsultorio(horario.IdConsultorio, horario.Dia))
            {
                horarios[i] = new int();
                horarios[i] = hor;
                i++;
            }

            return horarios;

        }



        public IHttpActionResult PostReservarHorarioProfesional(Horario horario)
        {

            //Logica.Fachada fach = new Logica.Fachada();
            Logica.IFachada fach = new Logica.Fachada();
            long cedula = horario.Cedula;
            long idHorario = horario.IdHorario;
            Logica.VOHorarioInsertarPaciente vo = new Logica.VOHorarioInsertarPaciente(idHorario, cedula);
            fach.reservaProfesional(vo);
            return Ok();
        }

        public IHttpActionResult PostReservarHorario(Horario horario)
        {
            System.Diagnostics.Debug.WriteLine("Dia: {0}", horario.Dia);
            System.Diagnostics.Debug.WriteLine("Profesional: {0}", horario.Cedula);
            System.Diagnostics.Debug.WriteLine("Hora: {0}", horario.Hora);
            System.Diagnostics.Debug.WriteLine("Consultorio: {0}", horario.IdConsultorio);


            //Logica.Fachada fach = new Logica.Fachada();
            Logica.IFachada fach = new Logica.Fachada();
            long ciProfesional = horario.Cedula;
            int hora = horario.Hora;
            DateTime dia = horario.Dia;
            int consultorio = horario.IdConsultorio;
            Logica.VOInsertarHorario voih = new Logica.VOInsertarHorario(hora, dia, consultorio, ciProfesional);
            fach.insertarHorario(voih);
            return Ok();
        }

    }
}
