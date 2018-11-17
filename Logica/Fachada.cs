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
        DAOProfesional daop = new DAOProfesional();
        DAOConsultorio daoc = new DAOConsultorio();
        DAOUsuario daou = new DAOUsuario();
        DAOPersona daope = new DAOPersona();
        DAOPaciente daopa = new DAOPaciente();
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

        public VOPersona darPersona(long ci)
        {
            return daope.find(ci);
        }

        /*public VOUsuario darUsuario(long ci)
        {
            return daou.Find(ci);
        }*/

        public String darRol (String user, String pass)
        {
            return daou.Rol(user, pass);

        }

        public void ingresarPersona(long ci, string nombre, string apellido, string celular, string direccion, bool habilitado)
        {
            daope.insert(ci, nombre, apellido, celular, direccion, habilitado);
        }

        public void modificarPersona(long ci, string nombre, string apellido, string celular, string direccion, bool habilitado)
        {
            daope.update(ci, nombre, apellido, celular, direccion, habilitado);
        }
       /* public void eliminarPersona(long ci)
        {
            if (!daop.Member(ci) && (!daopa.Member(ci)))
                daope.delete(ci);
            else if (!daoh.ProfesionalTieneHorario(ci) && (!daoh.PacienteTieneHorario(ci)))
            {
                if (daop.Member(ci))
                {
                    daop.delete(ci);
                    daope.delete(ci);
                }else
                {
                    daopa.delete(ci);
                    daope.delete(ci);
                }
                    
            } else
            {
                if (daop.Member(ci))
                {
                    daoh.deleteHorarioProfesional(ci);
                    daop.delete(ci);
                    daope.delete(ci);
                }
                else
                {
                    daoh.deleteHorarioPaciente(ci);
                    daopa.delete(ci);
                    daope.delete(ci);
                }
            }     
        }*/
        
        public List<int> HorariosReservadosConsultorioDiaXProfesional(int idConsultorio, DateTime dia)
        {
            return daoh.horariosReservadosConsultorios(dia, idConsultorio);
        }

        //FUNCIONA
        public VOProfesional darProfesional(long ced)
        {
            return daop.Find(ced);
        }

        public VOPaciente darPaciente(long ced)
        {
            return daopa.Find(ced);
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


        //FUNCIONA
        public List<VOListarProfesional> listaProfesionales()
        {
            return daop.listarProfesionales();
        }
        public List<VOPaciente> listarPacientes()
        {
            return daopa.listarPacientes();
        }

        public Boolean HorarioDisponible(int idConsultorio, DateTime dia, int hora)
        {
            return daoh.horarioDisponibleParaProfesional(idConsultorio, dia, hora);
        }

        public List<VOHorarioDisponible> horasLibresProfesional (DateTime fecha, long cedula)
        {
            return daoh.horasLibresProfesional(fecha, cedula);
        }

        // requerimiento 1
        public void reservaProfesional(VOHorarioInsertarPaciente vohip)
        {
            daoh.insertarHorarioPaciente(vohip);
        }


        // requerimiento 2
        public void cancelarHoraPaciente(long idHorario)
        {
            daoh.cancelarHoraPaciente(idHorario);
        }
        
        // requerimiento 3
        public List<VOHorarioPaciente> horariosPaciente(long ciPaciente)
        {
           return  daoh.horariosPaciente(ciPaciente);
        }
    }
}
