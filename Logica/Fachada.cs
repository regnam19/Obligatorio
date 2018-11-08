using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Fachada
    {
        public Fachada() { }

        DAOHorario daoh = new DAOHorario();
        DAOConsultorio daoc = new DAOConsultorio();
        //prueba git
        //singleton
        private static Fachada instancia = null;
        
        public static Fachada GetInstancia()
        {
            if (instancia == null)
                instancia = new Fachada();
            return instancia;
        }

        //operaciones 
        public List<int> HorariosReservadosConsultorioDiaXProfesional(int idConsultorio, DateTime dia)
        {
            return daoh.horariosReservadosConsultorios(dia, idConsultorio);
        }

        public List<int> HorariosReservadosConsultorioDiaXPaciente(int idConsultorio, DateTime dia)
        {
            return daoh.horariosReservadosDiaXPaciente(dia, idConsultorio);
        }

        public List<int> HorariosLibresConsultorioDiaParaProfesional(int idConsultorio, DateTime dia)
        {
            List<int> horariosLibres = new List<int>();
            VOHorario voh = new VOHorario();

            List<int> horariosOcupados = new List<int>();

            horariosOcupados = daoh.horariosReservadosConsultorios(dia, idConsultorio);

            VOConsultorio voc = new VOConsultorio();

            voc = daoc.Find(idConsultorio);
 
            for(int i = voc.HoraInicio; i <=voc.HoraFin;i++)
            {
                if (!horariosOcupados.Contains(i))
                {
                    horariosLibres.Add(i);
                }
                
            }

            return horariosLibres;        }



        public List<int> HorariosLibresConsultorioDiaParaPaciente(int idConsultorio, DateTime dia)
        {
            List<int> horariosLibres = new List<int>();
            VOHorario voh = new VOHorario();

            //List<int> horariosLibres = new List<int>();

            horariosLibres = daoh.horariosLibresDiaXPaciente(dia, idConsultorio);

            return horariosLibres;       
        }

        public Boolean HorarioDisponible(int idConsultorio, DateTime dia, int hora)
        {
            return daoh.horarioDisponibleParaProfesional(idConsultorio, dia, hora);
        }

        // requerimiento 1
        public void reservaProfesional(VOHorarioInsertarPaciente vohip)
        {
            daoh.insertarHorarioPaciente(vohip);
        }


        // requerimiento 2
        public void cancelarHoraPaciente(long idHorario)
        {

        }
        
        // requerimiento 3
        public List<VOHorarioPaciente> horariosPaciente(long ciPaciente)
        {
           return  daoh.horariosPaciente(ciPaciente);
        }
    }
}
