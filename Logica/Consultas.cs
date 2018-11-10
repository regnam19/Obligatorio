using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Consultas
    {
        public String profesionalListar()
        {
            String consulta = "select nombre, apellido, fechaNacimiento, especialidad from profesional where habilitado=1";
            return consulta;
        }

        public String profesionalObtenerUno()
        {
            String consulta = "Select * from profesional where ci=@ci";
            return consulta;
        }

        public String horarioDia()
        {
            String consulta = "Select * from horario where idConsultorio=@id and dia=@dia";
            return consulta;
        }

        public String horarioDiaPaciente()
        {
            String consulta = "Select * from horario where idConsultorio=@id and dia=@dia and estado = @estado and hora = @hora";
            return consulta;
        }

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

        public String insertarHorarioPaciente()
        {
            String consulta = "update horario set ciPaciente = @ciPaciente, estado = @estado where idHorario = @idHorario";
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

        public String insertarHorario()
        {
            String consulta = "insert into horario (idHorario,hora,dia,idConsultorio,ciProfesional,estado) values(@idHorario,@hora,@dia,@idConsultorio,@ciProfesional,@estado);";
            return consulta;
        }

        public String obtenerHorarioProfecional()
        {
            String consulta = "select idHorario, hora, dia, idConsultorio, ciPaciente from horario where ciProfesional = @ciProfesional and dia > @dia and estado = @estado order by dia,idConsultorio;";
            return consulta;
        }
    }
}
