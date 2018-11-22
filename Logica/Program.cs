using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Logica.WINFORMS;


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


            /*var pa = f.darProfesional(11111111);
            Console.WriteLine(pa.Nombre);
            Console.WriteLine(pa.Apellido);
            //Console.WriteLine(pa.ContactoEmergencia);
            Console.Read();

            foreach (var p in f.listarPacientes())
            {
                Console.WriteLine("Nombre: {0}", p.Nombre);
                Console.WriteLine("Apellido: {0}", p.Apellido);
                if (p.Habilitado)
                    Console.WriteLine("Habilitado");
                else
                    Console.WriteLine("no");
                Console.WriteLine("contactoEmergencia: {0}", p.ContactoEmergencia);
            }


            Console.Read();
            DateTime dia = new DateTime(2018, 09, 22);

           /* string rol = f.darRol("user", "user");
            Console.WriteLine(rol);
            Console.Read();

           /* var pe = f.darProfesional(11111111);
            Console.WriteLine("hola");

            /*foreach (var p in f.listaProfesionales())
            {
                Console.WriteLine("Nombre: {0}", p.Nombre);
                Console.WriteLine("Especialidad: {0}", p.Especialidad);
            }

            
            Console.ReadLine();
            /*
            Console.WriteLine("horarios lires: ");
            foreach(var h in f.HorariosLibresConsultorioDia(1,dia))
            {
                Console.WriteLine("Libre: {0}", h);
            }
            List<int> lista = new List<int>();

            lista = f.HorariosReservadosConsultorioDia(1, dia);
            lista.Sort();

            foreach (var h in lista)
            {
                Console.WriteLine("Ocupados: {0}", h);
            }

            foreach (var h in f.HorariosReservadosConsultorioDia(1, dia))
            {
                Console.WriteLine("Ocupados: {0}", h);
            }

            if (f.HorarioDisponible(1,dia,11))
                Console.WriteLine("Disponible");
            else
                Console.WriteLine("NO Disponible");
           */


            /*
             * 

            // craecion de diccionario de profesionales
            Profesionales dicc = new Profesionales();
            // cargo diccionario 
            dicc.InsertarProfesional(pr1.Ci, pr1);
            dicc.InsertarProfesional(pr2.Ci, pr2);
            dicc.InsertarProfesional(pr3.Ci, pr3);
            dicc.InsertarProfesional(pr4.Ci, pr4);



            Console.WriteLine("Nombre {0}", dicc.Find(pr1.Ci).Nombre);
            Console.WriteLine("Nombre {0}", dicc.Find(pr2.Ci).Nombre);
            Console.WriteLine("Nombre {0}", dicc.Find(pr3.Ci).Nombre);
            Console.WriteLine("Nombre {0}", dicc.Find(pr4.Ci).Nombre);
            Console.ReadLine();
             */
        }


    }
}
