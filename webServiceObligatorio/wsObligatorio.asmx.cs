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
    public class Service1 : System.Web.Services.WebService
    {
        
        Fachada fach = new Fachada();

        [WebMethod]
        public void darPersona(long ci)
        {
            fach.darPersona(ci);
        }

        [WebMethod]
        public bool esAdmin(long ci)
        {
            return fach.esAdmin(ci);
        }

        [WebMethod]
        public bool esPaciente(long ci)
        {
            return fach.esPaciente(ci);
        }

        [WebMethod]
        public bool esProfesional(long ci)
        {
            return fach.esProfesional(ci);
        }

         [WebMethod]
        public Boolean consultorioExiste(long id)
        {
            return fach.consultorioExiste(id);
        }
        [WebMethod]
        public Boolean ConsultorioTieneHorarios(long idConsultorio)
        {
            return fach.ConsultorioTieneHorarios(idConsultorio);
        }
        [WebMethod]
        public void eliminarPersona(long ci)
        {
            fach.eliminarPersona(ci);
        }
        [WebMethod]
        public Boolean contraseñaCorrecta(String contraseña)
        {
            return fach.contraseñaCorrecta(contraseña);
        }
        [WebMethod]
        public void ingresarPersona(long ci, String nombre, String apellido, String celular, DateTime fechaNacimiento, String direccion, String contraseña, bool habilitado)
        {
            fach.ingresarPersona(ci, nombre, apellido, celular, fechaNacimiento, direccion, contraseña, habilitado);
        }

        [WebMethod]
        public void ingresarPaciente(long ci, String contactoEmergencia, String celularEmergencia, String emergenciaMovil, String mutualista)
        {
            fach.ingresarPaciente(ci, contactoEmergencia, celularEmergencia, emergenciaMovil, mutualista);
        }

        [WebMethod]
        public void ingresarProfesional(long ci, String especialidad)
        {
            fach.ingresarProfesional(ci, especialidad);
        }

        [WebMethod]
        public void ingresarConsultorio(String direccion, int fechaInicio, int fechaFin)
        {
            fach.ingresarConsultorio(direccion, fechaInicio, fechaFin);
        }

        [WebMethod]
        public void ingresarAdmin(long ci)
        {
            fach.ingresarAdmin(ci);
        }

        [WebMethod]
        public void modificarPersona(long ci, String nombre, String apellido, String celular, DateTime fechaNacimiento, String direccion, bool habilitado)
        {
            fach.modificarPersona(ci, nombre, apellido, celular, fechaNacimiento, direccion, habilitado);
        }

        [WebMethod]
        public void modificarPaciente(long ci, String contactoEmergencia, String celularEmergencia, String emergenciaMovil, String mutualista)
        {
            fach.modificarPaciente(ci, contactoEmergencia, celularEmergencia, emergenciaMovil, mutualista);
        }

        [WebMethod]
        public void modificarProfesional(long ci, String especialidad)
        {
            fach.modificarProfesional(ci, especialidad);
        }

        [WebMethod]
        public void modificarConsultorio(long idConsultorio, String direccion, int fechaInicio, int fechaFin)
        {
            fach.modificarConsultorio(idConsultorio, direccion, fechaInicio, fechaFin);
        }

        [WebMethod]
        public void eliminarConsultorio(long idConsultorio)
        {
            fach.eliminarConsultorio(idConsultorio);
        }

        [WebMethod]
        public VOProfesional darProfesional(long ced)
        {
            return fach.darProfesional(ced);
        }

        [WebMethod]
        public VOPaciente darPaciente(long ced)
        {
            return fach.darPaciente(ced);
        }

        [WebMethod]
        public VOAdmin darAdmin(long ced)
        {
            return fach.darAdmin(ced);
        }

        [WebMethod]
        public VOConsultorio darConsultorio(long idConsultorio)
        {
            return fach.darConsultorio(idConsultorio);
        }
    }
   }

