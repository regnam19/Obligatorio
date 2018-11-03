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

            // cracion de 4 profesionales

            DateTime fechap1 = new DateTime(1990, 9, 1);
            Profesional pr1 = new Profesional(11111111, "Mateo", "Reyes", fechap1,"091000948", true, "individual");

            DateTime fechap2 = new DateTime(1991, 6, 14);
            Profesional pr2 = new Profesional(22222222, "Gonzalo", "Inzaurrald", fechap2, "099308786", true, "grupal");

            DateTime fechap3 = new DateTime(1991, 10, 3);
            Profesional pr3 = new Profesional(33333333, "Bruno", "Grecco", fechap3, "099878985", true, "adiccion a las drogas");

            DateTime fechap4 = new DateTime(1991, 4, 4);
            Profesional pr4 = new Profesional(44444444, "German", "Vazquez", fechap4, "099123321", true, "violencia de genero");

            // creacion de un paciente

            DateTime fechapa1 = new DateTime(1764, 6, 19);
            Paciente pa1 = new Paciente(12345678, "Jose", "Artigas", fechapa1, "098986989", true, "Paraguay 1212", 095878545, "Ansina", "SEM", "La Espanola");

            // creacion de un consultorio

            Consultorio co1 = new Consultorio(1, "18 de Julio y Rio Negro", 8, 20);

            // creacion de un horario
            DateTime fechaho1 = new DateTime(2018, 9, 1);
            Horario ho1 = new Horario(1, 9, fechaho1, co1.IdConsultorio,pr1.Ci);

            DateTime fechaho2 = new DateTime(2018, 9, 1);
            Horario ho2 = new Horario(2, 11, fechaho1, co1.IdConsultorio, pr1.Ci);

            //DateTime fechaho1 = new DateTime(2018, 9, 1);
            Horario ho3 = new Horario(3, 12, fechaho1, co1.IdConsultorio, pr2.Ci);

            //DateTime fechaho1 = new DateTime(2018, 9, 1);
            Horario ho4 = new Horario(4, 15, fechaho1, co1.IdConsultorio, pr3.Ci);

            //DateTime fechaho1 = new DateTime(2018, 9, 1);
            Horario ho5 = new Horario(5, 17, fechaho1, co1.IdConsultorio, pr4.Ci);

            Horario ho6 = new Horario(6, 20, fechaho1, co1.IdConsultorio, pr2.Ci);

            // creacion de diccionario horarios
            Horarios diccHorarios = new Horarios();

            diccHorarios.InsertarHorario(1, ho1);
            diccHorarios.InsertarHorario(2, ho2);
            diccHorarios.InsertarHorario(3, ho3);
            diccHorarios.InsertarHorario(4, ho4);
            diccHorarios.InsertarHorario(5, ho5);
            diccHorarios.InsertarHorario(6, ho6);

            // traer todos los horarios
            List<Horario> listaHorarios = new List<Horario>();
            listaHorarios = diccHorarios.ListarHorarios();

           

            void Horarios_disponibles_ocupados_por_Consultorio() {

                Console.WriteLine("Mostrar horarios libres para un consultorio en un dia particular");

                // creo una lista para saber los horarios en que esta ocupado un consultorio
                List<int> horariosOcupados = new List<int>();
                // recorro el diccionario de horarios buscando si mi consultorio se encuntra
                
                // VERIFICAR PREVIAMENTE QUE LA FECHA NO SEA ANTERIOR AL DIA DE HOY
                DateTime dia1 = new DateTime(2018, 9, 1);
                foreach (var horario in listaHorarios)
                {
                    // si lo encuentro algun horario que tenga mi idConsultorio, quiere decir que algun profesional lo creo, por lo 
                    // tanto no esta disponible, asi que lo agrego a mi lista de horarios ocupados
                    if (horario.IdConsultorio == co1.IdConsultorio)
                    {
                        if(horario.Dia == dia1)
                        {
                            horariosOcupados.Add(horario.Hora);
                        }
                        
                    }
                }
                Console.WriteLine("Muestro los horarios ocupados de mi consultorio:");
                foreach (var hora in horariosOcupados)
                {
                    Console.WriteLine("hora ocupada: {0}", hora.ToString());
                }


                Console.WriteLine("COMIENZA HORARIOS OCUPADOS");
                for (int i = co1.HoraInicio; i <= co1.HoraFin; i++)
                {
                    if (horariosOcupados.Contains(i))
                    {
                        Console.Write("ocupado");
                        Console.WriteLine(i);
                    }


                }

                Console.WriteLine("COMIENZA HORARIOS DISPONIBLES");
                for (int i = co1.HoraInicio; i <= co1.HoraFin; i++)
                {
                    if (!horariosOcupados.Contains(i))
                    {
                        Console.WriteLine("Libre: {0} hs", i);
                    }



                }








            }


            // Horarios_disponibles_ocupados_por_Consultorio();

            // conexion funcionando

            DAOProfesional daop = new DAOProfesional();

            DAOHorario daoh = new DAOHorario();

            DAOConsultorio daoc = new DAOConsultorio();

            if (daoc.Member(1))
                Console.Write("SI!");
            else
                Console.Write("NO!");

            

            VOConsultorio voc = new VOConsultorio();

            voc = daoc.Find(1);

            Console.WriteLine("Hora inicio: {0}", voc.HoraInicio);


            Console.WriteLine("Hora inicio: {0}", voc.HoraFin);

            Console.ReadLine();

            /*

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
