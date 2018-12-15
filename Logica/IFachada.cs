using Logica.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IFachada
    {
        VOPersona darPersona(long ci);

        Boolean esAdmin(long ci);

        Boolean esPaciente(long ci);

        Boolean esProfesional(long ci);
        Boolean consultorioExiste(long id);
        void eliminarPersona(long ci);

        void ingresarPersona(long ci, String nombre, String apellido, String celular, DateTime fechaNacimiento, String direccion, String contraseña, bool habilitado);

        void ingresarPaciente(long ci, String contactoEmergencia, String celularEmergencia, String emergenciaMovil, String mutualista);

        void ingresarProfesional(long ci, String especialidad);

        void ingresarConsultorio(String direccion, int fechaInicio, int fechaFin);

        void ingresarAdmin(long ci);

        void modificarPersona(long ci, String nombre, String apellido, String celular, DateTime fechaNacimiento, String direccion, bool habilitado);

        void modificarPaciente(long ci, String contactoEmergencia, String celularEmergencia, String emergenciaMovil, String mutualista);

        void modificarProfesional(long ci, String especialidad);

        void modificarConsultorio(long idConsultorio, String direccion, int fechaInicio, int fechaFin);

        void eliminarConsultorio(long idConsultorio);

        VOProfesional darProfesional(long ced);

        VOPaciente darPaciente(long ced);

        VOAdmin darAdmin(long ced);

        VOConsultorio darConsultorio(long idConsultorio);
        

        List<int> HorariosReservadosConsultorioDiaXProfesional(int idConsultorio, DateTime dia);


        List<int> HorariosLibresConsultorioDiaParaProfesional(int idConsultorio, DateTime dia);

        List<int> HorariosLibresConsultorioDiaParaPaciente(int idConsultorio, DateTime dia);

        List<VOListarProfesional> listaProfesionales();

        List<VOPaciente> listarPacientes();

        Boolean HorarioDisponible(int idConsultorio, DateTime dia, int hora);

        List<VOHorarioDisponibleProfesional> horasLibresProfesional(long cedula);

        // requerimiento 1
        void reservaProfesional(VOHorarioInsertarPaciente vohip);

        // requerimiento 2
        void cancelarHoraPaciente(long idHorario);

        // requerimiento 3
        List<VOHorarioPaciente> horariosPaciente(long ciPaciente);

        // funciona trae reservas de paciente 
        List<VOReservasPaciente> horasReservadasPaciente(long ciPaciente);


        void cancelarReservaPaciente(long idReserva);

        // trae las reservas que tiene para confirmar o cancelar un profesional en particular
        List<VOReservaXconfirmar> reservasXconfirmar(long ciProfesional);

        List<VOReservasPaciente> historialReservaPaciente(long ciPaciente);

        // profesional acepta reserva
        void aceptarReserva(long idReserva);

        // profeisonal rechaza reserva
        void rechazarReserva(long idReserva);


        List<VOConsultorio> listarConsultorios();


        List<int> horariosDisponiblesConsultorio(int idConsultorio, DateTime fecha);


        void insertarHorario(VOInsertarHorario voih);

        List<VOPacienteXatender> pacientesXatender(long ciProfeisonal);

        List<VOPacienteXatender> pacientesAtendidos(long ciProfeisonal);

        List<VOHorarioDisponible> listarHorariosLibresProfeisonal(long ciProfeisonal);

        Boolean verificarUsuario(long ci, String pass);

        Boolean verificarProfesional(long ci);

        Boolean usuarioHabilitado(long ci);

        List<VOConsultorioReservado> consultorioReservado(long ci);

        void eliminarHorarioProfeisonal(long idHorario);
    }
}
