using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace webServiceObligatorio
{
    /// <summary>
    /// Descripción breve de Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsObligatorio : System.Web.Services.WebService
    {
        Fachada fach = new Fachada();

        [WebMethod]
        public void darPersona(long ci)
        {

            fach.darPersona(ci);
        }

        [WebMethod]
        public void esAdmin(long ci)
        {
            fach.esAdmin(ci);
        }

        public void esPaciente(long ci)
        {
            fach.esPaciente(ci);
        }

        public void esProfesional(long ci)
        {
            fach.esProfesional(ci);
        }

        public void eliminarPersona(long ci)
        {
            fach.eliminarPersona(ci);
        }

        public void ingresarPersona(long ci, String nombre, String apellido, String celular, DateTime fechaNacimiento, String direccion, String contraseña, bool habilitado)
        {
            fach.ingresarPersona(ci, nombre, apellido, celular, fechaNacimiento, direccion, contraseña, habilitado);
        }

        public void ingresarPaciente(long ci, String contactoEmergencia, String celularEmergencia, String emergenciaMovil, String mutualista)
        {
            fach.ingresarPaciente(ci, contactoEmergencia, celularEmergencia, emergenciaMovil, mutualista);
        }

        public void ingresarProfesional(long ci, String especialidad)
        {
            fach.ingresarProfesional(ci, especialidad);
        }

        public void ingresarConsultorio(String direccion, int fechaInicio, int fechaFin)
        {
            fach.ingresarConsultorio(direccion, fechaInicio, fechaFin);
        }

        public void ingresarAdmin(long ci)
        {
            fach.ingresarAdmin(ci);
        }

        public void modificarPersona(long ci, String nombre, String apellido, String celular, DateTime fechaNacimiento, String direccion, bool habilitado)
        {
            fach.modificarPersona(ci, nombre, apellido, celular, fechaNacimiento, direccion, habilitado);

        }

        public void modificarPaciente(long ci, String contactoEmergencia, String celularEmergencia, String emergenciaMovil, String mutualista)
        {
            fach.modificarPaciente(ci, contactoEmergencia, celularEmergencia, emergenciaMovil, mutualista);
        }

        public void modificarProfesional(long ci, String especialidad)
        {
            fach.modificarProfesional(ci, especialidad);
        }

        public void modificarConsultorio(long idConsultorio, String direccion, int fechaInicio, int fechaFin)
        {
            fach.modificarConsultorio(idConsultorio, direccion, fechaInicio, fechaFin);

        }

        public void eliminarConsultorio(long idConsultorio)
        {
            fach.eliminarConsultorio(idConsultorio);

        }

        public void darProfesional(long ced)
        {
            fach.darProfesional(ced);
        }

        public void darPaciente(long ced)
        {
            fach.darPaciente(ced);
        }

        public void darAdmin(long ced)
        {
            fach.darAdmin(ced);
        }

        public void darConsultorio(long idConsultorio)
        {
            fach.darConsultorio(idConsultorio);
        }
    }
   }

