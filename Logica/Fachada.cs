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
        DAOPersona daope = new DAOPersona();
        DAOPaciente daopa = new DAOPaciente();
        DAOAdmin daoad = new DAOAdmin();
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

        public Boolean esAdmin (long ci)
        {
            return daoad.member(ci);
        }
        public Boolean esPaciente (long ci)
        {
            return daopa.Member(ci);
        }
        public Boolean esProfesional (long ci)
        {
            return daop.Member(ci);
        }
         public void eliminarPersona(long ci)
        {
            daope.delete(ci); 
        }     
        
        public void ingresarPersona(long ci, String nombre, String apellido, String celular, String fechaNacimiento, String direccion, String contraseña, bool habilitado)
        {
            if (!daope.Member(ci))
                daope.insert(ci, nombre, apellido, celular, fechaNacimiento, direccion, contraseña, habilitado);
            else
                throw new Exception("Usuario ya existe");
        }
        public void ingresarPaciente(long ci, String contactoEmergencia, String celularEmergencia, String emergenciaMovil, String mutualista)
        {
            daopa.insert(ci, contactoEmergencia, celularEmergencia, emergenciaMovil, mutualista);
        }
        public void ingresarProfesional(long ci, String especialidad)
        {
            daop.insert(ci, especialidad);
        }
        public void ingresarAdmin(long ci)
        {
            daoad.insert(ci);
        }

        public void modificarPersona(long ci, String nombre, String apellido, String celular, String direccion, bool habilitado)
        {
            daope.update(ci, nombre, apellido, celular, direccion, habilitado);
        }

        public void modificarPaciente(long ci, String contactoEmergencia, String celularEmergencia, String emergenciaMovil, String mutualista)
        {
            daopa.update(ci, contactoEmergencia, celularEmergencia, emergenciaMovil, mutualista);
        }

        public void modificarProfesional(long ci, String especialidad)
        {
            daop.update(ci, especialidad);
        }
       

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

        public VOAdmin darAdmin(long ced)
        {
            return daoad.find(ced);
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
            return daoh.horasLibresProfesional(cedula);
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
