using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Logica.WINFORMS;
using Logica.DAOS;

namespace Logica
{
    class Program
    {
        static void Main(string[] args)
        {

          
            //Application.Run(new WINFORMS.Registros());
            // conexion funcionando

            DAOProfesional daop = new DAOProfesional();

            DAOHorario daoh = new DAOHorario();

            DAOConsultorio daoc = new DAOConsultorio();
            

            DAOPersona daope = new DAOPersona();

            VOPersona vope = new VOPersona();

            DAOPaciente vopa = new DAOPaciente();

            Fachada f = new Fachada();

            DAOReserva daor = new DAOReserva();

            
            foreach (var re in f.horasReservadasPaciente(12345678)){
                Console.WriteLine("idreserva: {0}", re.IdReserva);
                Console.WriteLine("fecha: {0}", re.Fecha);
                Console.WriteLine("hora: {0}", re.Hora);
                Console.WriteLine("direccion: {0}", re.DireccionConsultorio);
                Console.WriteLine("nombre: {0}", re.NombreProfesional);
                Console.WriteLine("apellido: {0}", re.ApellidoProfesional);
                Console.WriteLine("estado: {0}", re.Estado);

                Console.WriteLine("***************************");
            }
          
            Console.ReadLine();
            
        }


    }
}
