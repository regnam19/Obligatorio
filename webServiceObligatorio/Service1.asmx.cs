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

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public double getTemperatura(String ciudad)
        {
            double temperatura = 0;
            switch (ciudad)
            {
                case "Montevideo":
                    temperatura = 20.5;
                    break;
                case "Maldonado":
                    temperatura = 15.8;
                    break;
                case "Salto":
                    temperatura = 29.8;
                    break;
                default:
                    break;
            }
            return temperatura;
            }

        [WebMethod]
        public void reservaProfesional(long idHorario, long ciPaciente)
        {
            Fachada fach = new Fachada();
            VOHorarioInsertarPaciente voInsertar = new VOHorarioInsertarPaciente(idHorario, ciPaciente);
            fach.reservaProfesional(voInsertar);
        }
        }
    }

