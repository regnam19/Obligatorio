using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class PacienteXatenderController : ApiController
    {
       
        public IEnumerable<PacienteXatender> GetPacienteXatender(long id)
        {
            System.Diagnostics.Debug.WriteLine("id que viene: {0}", id);


            //Logica.Fachada fach = new Logica.Fachada();
            Logica.IFachada fach = new Logica.Fachada();

            PacienteXatender[] paciente = new PacienteXatender[fach.pacientesXatender(id).LongCount()];
            int i = 0;
            foreach (var p in fach.pacientesXatender(id))
            {
                paciente[i] = new PacienteXatender();
                paciente[i].Dia = p.Dia;
                paciente[i].Hora = p.Hora;
                paciente[i].Direccion = p.Direccion;
                paciente[i].Nombre = p.NombrePaciente;
                paciente[i].Apellido = p.ApellidoPaciente;
                i++;
            }
            return paciente;
        }

        public IEnumerable<PacienteXatender> GetPacienteAtendido(long id)
        {
            System.Diagnostics.Debug.WriteLine("id que viene: {0}", id);


            //Logica.Fachada fach = new Logica.Fachada();
            Logica.IFachada fach = new Logica.Fachada();

            PacienteXatender[] paciente = new PacienteXatender[fach.pacientesAtendidos(id).LongCount()];
            int i = 0;
            foreach (var p in fach.pacientesAtendidos(id))
            {
                paciente[i] = new PacienteXatender();
                paciente[i].Dia = p.Dia;
                paciente[i].Hora = p.Hora;
                paciente[i].Direccion = p.Direccion;
                paciente[i].Nombre = p.NombrePaciente;
                paciente[i].Apellido = p.ApellidoPaciente;
                i++;
            }
            return paciente;
        }

    }
}
