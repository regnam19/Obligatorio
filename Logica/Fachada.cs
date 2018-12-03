using Logica.DAOS;
using Logica.VO;
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
        DAOReserva daore = new DAOReserva();

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
            if (daope.Member(ci))
                return daope.find(ci);
            else
                throw new CedulaPersonaInvalida();
        }

        /*public VOUsuario darUsuario(long ci)
        {
            return daou.Find(ci);
        }*/

        public Boolean esAdmin (long ci)
        {
            if (daope.Member(ci))
                return daoad.member(ci);
            else
                throw new CedulaPersonaInvalida();
        }

        public Boolean esPaciente (long ci)
        {
            if (daope.Member(ci))
                return daopa.Member(ci);
             else
                throw new CedulaPersonaInvalida();
        }

        public Boolean esProfesional (long ci)
        {
            if (daope.Member(ci))
                return daop.Member(ci);
            else
                throw new CedulaPersonaInvalida();
        }

        public void eliminarPersona(long ci)
        {
            if (daope.Member(ci))
                daope.delete(ci);
            else
                throw new CedulaPersonaInvalida();
        }

        public void ingresarPersona(long ci, String nombre, String apellido, String celular, DateTime fechaNacimiento, String direccion, String contraseña, bool habilitado)
        {
            if (!daope.Member(ci))
                daope.insert(ci, nombre, apellido, celular, fechaNacimiento, direccion, contraseña, habilitado);
            else
                throw new CedulaPersonaInvalida();
        }

        public void ingresarPaciente(long ci, String contactoEmergencia, String celularEmergencia, String emergenciaMovil, String mutualista)
        {
            daopa.insert(ci, contactoEmergencia, celularEmergencia, emergenciaMovil, mutualista);
        }

        public void ingresarProfesional(long ci, String especialidad)
        {
            daop.insert(ci, especialidad);
        }

        public void ingresarConsultorio (String direccion, int fechaInicio, int fechaFin)
        {
                 daoc.insert(direccion, fechaInicio, fechaFin);
        }

        public void ingresarAdmin(long ci)
        {
            daoad.insert(ci);
        }

        public void modificarPersona(long ci, String nombre, String apellido, String celular, DateTime fechaNacimiento, String direccion, bool habilitado)
        {
            if (daope.Member(ci))
                daope.update(ci, nombre, apellido, celular, fechaNacimiento, direccion, habilitado);
            else
                throw new CedulaPersonaInvalida();
        }

        public void modificarPaciente(long ci, String contactoEmergencia, String celularEmergencia, String emergenciaMovil, String mutualista)
        {
            daopa.update(ci, contactoEmergencia, celularEmergencia, emergenciaMovil, mutualista);
        }

        public void modificarProfesional(long ci, String especialidad)
        {
            daop.update(ci, especialidad);
        }

        public void modificarConsultorio (long idConsultorio, String direccion, int fechaInicio, int fechaFin)
        {
            if (daoc.Member(idConsultorio))
                daoc.update(idConsultorio, direccion, fechaInicio, fechaFin);
            else
                throw new ConsultorioInvalido();
        }

        public void eliminarConsultorio (long idConsultorio)
        {
            if (daoc.Member(idConsultorio))
                daoc.delete(idConsultorio);
            else
                throw new ConsultorioInvalido();
        }

        public List<int> HorariosReservadosConsultorioDiaXProfesional(int idConsultorio, DateTime dia)
        {
            return daoh.horariosReservadosConsultorio(dia, idConsultorio);
        }
     
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

        public VOConsultorio darConsultorio (long idConsultorio)
        {
            if (daoc.Member(idConsultorio))
                return daoc.Find(idConsultorio);
            else
                throw new ConsultorioInvalido();
        }

       

        public List<int> HorariosLibresConsultorioDiaParaProfesional(int idConsultorio, DateTime dia)
        {
            List<int> horariosLibres = new List<int>();
            VOHorario voh = new VOHorario();

            List<int> horariosOcupados = new List<int>();

            horariosOcupados = daoh.horariosReservadosConsultorio(dia, idConsultorio);

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

        /*public List<VOHorarioDisponible> horasLibresProfesional (DateTime fecha, long cedula)
        {
            return daoh.horasLibresProfesional(cedula);
        }*/

        public List <VOHorarioDisponible> horasLibresProfesional(long cedula)
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

        // funciona trae reservas de paciente 
        public List<VOReservasPaciente> horasReservadasPaciente(long ciPaciente)
        {
            
            List<VOReservasPaciente> listaFinal = new List<VOReservasPaciente>();


            List<VOReserva> listaReserva = new List<VOReserva>();

            listaReserva = daore.reservasPaciente(ciPaciente);

            foreach(var reserva in listaReserva)
            {
                VOHorario voh = new VOHorario();
         
                voh = daoh.Find(reserva.IdHorario); 

                VOReservasPaciente vorp = new VOReservasPaciente();

                vorp.IdReserva = reserva.IdReserva;
                vorp.Hora = voh.Hora;
                vorp.Fecha = voh.Dia;
                vorp.Estado = reserva.Estado;
                vorp.NombreProfesional = daop.Find(voh.CiProfesional).Nombre;
                vorp.ApellidoProfesional = daop.Find(voh.CiProfesional).Apellido; ;
                vorp.DireccionConsultorio = daoc.Find(voh.IdConsultorio).Direccion;

                listaFinal.Add(vorp);
            }


            return listaFinal;
        }


        public void cancelarReservaPaciente(long idReserva)
        {
            daore.cancelarReservaPaciente(idReserva);
        }

        // trae las reservas que tiene para confirmar o cancelar un profesional en particular
        public List<VOReservaXconfirmar> reservasXconfirmar(long ciProfesional)
        {
            return daore.reservasXconfirmar(ciProfesional);
        }

        public List <VOReservasPaciente> historialReservaPaciente(long ciPaciente)
        {
            List<VOReservasPaciente> listaFinal = new List<VOReservasPaciente>();


            List<VOReserva> listaReserva = new List<VOReserva>();

            listaReserva = daore.historialRservasPaciente(ciPaciente);

            foreach (var reserva in listaReserva)
            {
                VOHorario voh = new VOHorario();

                voh = daoh.Find(reserva.IdHorario);

                VOReservasPaciente vorp = new VOReservasPaciente();

                vorp.IdReserva = reserva.IdReserva;
                vorp.Hora = voh.Hora;
                vorp.Fecha = voh.Dia;
                vorp.Estado = reserva.Estado;
                vorp.NombreProfesional = daop.Find(voh.CiProfesional).Nombre;
                vorp.ApellidoProfesional = daop.Find(voh.CiProfesional).Apellido; ;
                vorp.DireccionConsultorio = daoc.Find(voh.IdConsultorio).Direccion;

                listaFinal.Add(vorp);
            }


            return listaFinal;
        }

        // profesional acepta reserva
        public void aceptarReserva(long idReserva)
        {
            daore.aceptarReserva(idReserva);
        }

        // profeisonal rechaza reserva
        public void rechazarReserva(long idReserva)
        {
            daore.rechazarReserva(idReserva);
        }


        public List<VOConsultorio> listarConsultorios()
        {
            return daoc.listarConsultorios();
        }


        public List<int> horariosDisponiblesConsultorio(int idConsultorio, DateTime fecha)
        {
            List<int> reservados = new List<int>();
            List<int> disponibles = new List<int>();

            reservados = daoh.horariosReservadosConsultorio(fecha, idConsultorio);

            int horaInicio = daoc.Find(idConsultorio).HoraInicio;
            int horaFin = daoc.Find(idConsultorio).HoraFin;

            for(int i = horaInicio;i<horaFin;i++)
            {
                if (!reservados.Contains(i))
                    disponibles.Add(i);
            }
            return disponibles;
        }


        public void insertarHorario(VOInsertarHorario voih)
        {
            daoh.insertarHorarioProfesional(voih);
        }

        public List<VOPacienteXatender> pacientesXatender (long ciProfeisonal)
        {
            return daore.pacientesXatender(ciProfeisonal);
        }

        public List<VOPacienteXatender> pacientesAtendidos(long ciProfeisonal)
        {
            return daore.pacientesAtendido(ciProfeisonal);
        }

        public List<VOHorarioDisponible> listarHorariosLibresProfeisonal(long ciProfeisonal)
        {
            return daoh.horariosLibresProfesional(ciProfeisonal);
        }


    }

    
}
