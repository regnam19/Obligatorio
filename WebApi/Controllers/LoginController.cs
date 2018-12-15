using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class LoginController : ApiController
    {
        public Login PostLogin (Login login)
        {
            //Logica.Fachada fach = new Logica.Fachada();
            Logica.IFachada fach = new Logica.Fachada();
            Login log = new Login();
            log.Correcto = fach.verificarUsuario(login.Usuario, login.Contrasena);
            log.Profesional = fach.verificarProfesional(login.Usuario);
            if (log.Profesional)
                log.Paciente = false;
            else
                log.Paciente = true;
            log.Habilitado = fach.usuarioHabilitado(login.Usuario);

           
            return log;
        }
    }
}
