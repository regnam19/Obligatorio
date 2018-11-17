using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Consultas
    {
        public String esAdmin()
        {
            String consulta = "select * from admin where ciAdmin=@usuario;";
            return consulta;
        }
        public String buscarPersona()
        {
            String consulta = "select nombre, apellido, celular, fechaNacimiento, direccion, habilitado, idUsuario from persona where ci=@ci";
            return consulta;
        }

        
        public String insertarPersona()
        {
            String consulta = "insert into persona (ci, nombre, apellido, celular, direccion, habilitado, contrasena) values (@ci, @nombre, @apellido, @celular, @direccion, @habilitado, @contrasena)";
            return consulta;
        }
        public String modificarPersona()
        {
            String consulta = "update persona set nombre = @nombre, apellido = @apellido, celular = @celular, direccion = @direccion, habilitado = @habilitado, contrasena = @contrasena where ci = @ci";
            return consulta;
        }
        public String eliminarPersona()
        {
            String consulta = "delete from persona where ci = @ci";
            return consulta;
        }
        public String eliminarProfesional()
        {
            String consulta = "delete from profesional where ciProfesional = @ci";
            return consulta;
        }
        public String eliminarPaciente()
        {
            String consulta = "delete from paciente where ciPaciente = @ci";
            return consulta;
        }

        //Chequear que no este reservado
        public String eliminarHorarioProfesional()
        {
            String consulta = "delete from horario where idHorario = @idHorario";
            return consulta;
        }
        public String eliminarReservaPaciente()
        {
            String consulta = "delete from reserva where idReserva =@idReserva";
            return consulta;
        }

        //FUNCIONA
        public String profesionalListar()
        {
            String consulta = "select p.nombre, p.apellido, p.fechaNacimiento, pr.especialidad  from persona p, profesional pr where p.ci = pr.ciProfesional";
            return consulta;
        }

        //FUNCIONA
        public String profesionalObtenerUno()
        {
            //String consulta = "Select * from profesional p, persona pe where p.ciProfesional = pe.ci and ciProfesional=@ci";
            String consulta = "select p.ci, p.nombre, p.apellido, p.celular, p.fechaNacimiento, p.direccion, p.habilitado, pr.especialidad from persona p, profesional pr where p.ci = pr.ciProfesional and p.ci = @ci ";
            return consulta;
        }
        // ver si es necesario
        
        public String pacienteObtenerUno()
        {
            String consulta = "Select * from paciente p, persona pe where p.ciPaciente= pe.ci and ciPaciente=@ci";
            return consulta;
        }
        public String pacienteListar()
        {
            String consulta = "select nombre, apellido, fechaNacimiento, contactoEmergencia, celularEmergencia, emergenciaMovil, mutualista  from paciente p, persona pe where pe.ci = p.ciPaciente";
            return consulta;
        }
       
        public String tieneHorarioProfesional()
        {
            String consulta = "select * from horario where ciProfesional = @ci ";
            return consulta;
        }
       
        public String horarioDia()
        {
            String consulta = "Select * from horario where idConsultorio=@id and dia=@dia";
            return consulta;
        }

        public String insertarHorario()
        {
            String consulta = "insert into horario (hora,dia,idConsultorio,ciProfesional) values(@hora,@dia,@idConsultorio,@ciProfesional);";
            return consulta;
        }
        
        public String horarioDiaPaciente()
        {
            String consulta = "Select * from horario where idConsultorio=@id and dia=@dia and estado = @estado and hora = @hora";
            return consulta;
        }
        // dado un dia y un consultorio mostrar todos los }
        
        public String horariosDiaPacienteLibre()
        {
            String consulta = "select * from horario where dia = @dia and idConsultorio = @id and estado = @estado";
            return consulta;
        }

        public String horariosDiaPacienteReservado()
        {
            String consulta = "select * from horario where dia = @dia and idConsultorio = @id and estado <> @estado";
            return consulta;
        }

        public String consultorioObtener()
        {
            String consulta = "select * from consultorio where idConsultorio=@id";
            return consulta;
        }

        public String horariosLibreProfesional()
        {
            String consulta = "select * from horario where dia > @dia and ciProfesional = @ci";
            return consulta;
        }

        public String horariosLibresPacienteTotales()
        {
            String consulta = "select * from horario where dia > @dia and estado = @estado";
            return consulta;
        }

        public String horariosLibresProfesional()
        {
            String consulta = "select hora, idHorario, idConsultorio from horario where ciProfesional = @ci and estado = @estado and dia=@dia order by idConsultorio, hora";
            return consulta;
        }

        public String memberHorario()
        {
            String consulta = "select idHorario from horario where idHorario = @id";
            return consulta;
        }

        public String findHorario()
        {
            String consulta = "select * from horario where idHorario = @id";
            return consulta;
        }
        
        //FUNCIONA
        public String insertarHorarioPaciente()
        {
            String consulta = "insert into reserva (idHorario,ciPaciente,estado) values (@idHorario, @ciPaciente, 0)";
            return consulta;
        }

        public String listarHorariosPaciente()
        {
            String consulta = "select * from horario where ciPaciente = @ciPaciente and dia > @dia";
            return consulta;
        }

        public String cancelarHorarioPaciente()
        {
            String consulta = "update  horario set ciPaciente = null ,estado = @estado where idHorario = @idHorario;";
            return consulta;
        }

        public String listarHorariosRservadosProfesional()
        {
            String consulta = "select * from horario where ciProfesional = @ciProfesional and date > @dia and estado = @estado";
            return consulta;
        }

        public String aceptarHorarioProfesional()
        {
            String consulta = "update horario set estado = @estado where idHorario = @idHorario";
            return consulta;
        }

        public String cancelarHorarioProfesional()
        {
            String consulta = "update horario set estado = @estado, ciPaciente = null where idHorario = @idHorario";
            return consulta;
        }

        public String obtenerIdHorario()
        {
            String consulta = "select top 1 idHorario from horario  order by idHorario desc; ";
            return consulta;
        }
        
       

        public String obtenerHorarioProfecional()
        {
            String consulta = "select idHorario, hora, dia, idConsultorio, ciPaciente from horario where ciProfesional = @ciProfesional and dia > @dia and estado = @estado order by dia,idConsultorio;";
            return consulta;
        }
    }
}
