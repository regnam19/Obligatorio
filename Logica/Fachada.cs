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

        public List<int> HorariosReservadosConsultorioDia(int idConsultorio, DateTime dia)
        {
            return daoh.horariosReservadorsDia(dia, idConsultorio);
        }

        public List<int> HorariosLibresConsultorioDia(int idConsultorio, DateTime dia)
        {
            List<int> horariosLibres = new List<int>();
            VOHorario voh = new VOHorario();

            List<int> horariosOcupados = new List<int>();

            horariosOcupados = daoh.horariosReservadorsDia(dia, idConsultorio);

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
    }
}
