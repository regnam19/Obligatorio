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

          
           Application.Run(new WINFORMS.Registros());
            // conexion funcionando

            DAOProfesional daop = new DAOProfesional();

            DAOHorario daoh = new DAOHorario();

            DAOConsultorio daoc = new DAOConsultorio();
            

            DAOPersona daope = new DAOPersona();

            VOPersona vope = new VOPersona();

            DAOPaciente vopa = new DAOPaciente();

            Fachada f = new Fachada();

            DAOReserva daor = new DAOReserva();



          
            Console.ReadLine();
            
        }


    }
}
