using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Logica
{
    class Program
    {
        static void Main(string[] args)
        {
            
           

           

            

            // conexion funcionando

            DAOProfesional daop = new DAOProfesional();

            DAOHorario daoh = new DAOHorario();

            DAOConsultorio daoc = new DAOConsultorio();

            Fachada f = new Fachada();
            DateTime dia = new DateTime(2018, 09, 22);

            VOInsertarHorario v = new VOInsertarHorario(16, dia, 1, 22222222);

            foreach(var h in daoh.listarHorariosProfesional(11111111))
            {
                Console.WriteLine("Idconsultorio: {0}", h.IdConsultorio);
                Console.WriteLine("Fecha: {0}", h.Dia);
                Console.WriteLine("Hora: {0}", h.Hora);
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
