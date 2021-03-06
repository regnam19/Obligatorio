﻿using System;
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
        public String esProfesional()
        {
            String consulta = "select * from profesional where ciProfesional =@ci";
            return consulta;
        }
        public String esPaciente()
        {
            String consulta = "select * from paciente where ciPaciente =@ci";
            return consulta;
        }
        public String consultorioExiste()
        {
            String consulta = "select * from consultorio where idConsultorio =@idConsultorio;";
            return consulta;
        }
        public String buscarPersona()
        {
            String consulta = "select nombre, apellido, celular, fechaNacimiento, direccion, habilitado from persona where ci=@ci";
            return consulta;
        }
        public String eliminarAdmin()
        {
            String consulta = "delete from admin where ciAdmin = @ci";
            return consulta;
        }
        public String insertarPaciente()
        {
            String consulta = "insert into paciente (ciPaciente, contactoEmergencia,  celularEmergencia, emergenciaMovil, mutualista) values (@ci,  @contactoEmergencia, @celularEmergencia, @emergenciaMovil, @mutualista)";
            return consulta;
        }
        public String modificarPaciente()
        {
            String consulta = "update paciente set contactoEmergencia = @contactoEmergencia, celularEmergencia = @celularEmergencia, emergenciaMovil = @emergenciaMovil, mutualista = @mutualista where ciPaciente = @ci";
            return consulta;
        }
        public String insertarProfesional()
        {
            String consulta = "insert into profesional (ciProfesional, especialidad) values (@ci,  @especialidad)";
            return consulta;
        }
        public String modificarProfesional()
        {
            String consulta = "update profesional set especialidad = @especialidad where ciProfesional = @ci";
            return consulta;
        }
        public String insertarAdmin()
        {
            String consulta = "insert into admin (ciAdmin) values (@ci)";
            return consulta;
        }
       
        public String insertarPersona()
        {
            String consulta = "insert into persona (ci, nombre, apellido, celular, fechaNacimiento, direccion, habilitado, contrasena) values (@ci, @nombre, @apellido, @celular, @fechaNacimiento, @direccion, @habilitado, @contraseña)";
            return consulta;
        }
        public String modificarPersona()
        {
            String consulta = "update persona set nombre = @nombre, apellido = @apellido, celular = @celular, fechaNacimiento = @fechaNacimiento, direccion = @direccion, habilitado = @habilitado where ci = @ci";
            return consulta;
        }
        public String eliminarPersona()
        {
            String consulta = "update persona set habilitado = 0 where ci = @ci";
            return consulta;
        }
        public String insertarConsultorio()
        {
            String consulta = "insert into consultorio (direccion, horaInicio, horaFin) values (@direccion,  @horaInicio, @horaFin)";
            return consulta;
        }
        public String modificarConsultorio()
        {
            String consulta = "update consultorio set direccion = @direccion , horaInicio = @horaInicio, horaFin = @horaFin where idConsultorio = @idConsultorio";
            return consulta;
        }
        public String eliminarConsultorio()
        {
            String consulta = "delete from consultorio where idConsultorio = @idConsultorio";
            return consulta;
        }
        public String consultorioObtener()
        {
            String consulta = "select * from consultorio where idConsultorio=@id";
            return consulta;
        }
        public String consultorioTieneHorarios()
        {
            String consulta = "select * from horario where idConsultorio=@idConsultorio";
            return consulta;
        }
        public String contraseñaCorrecta()
        {
            String consulta = "select * from persona where contrasena=@contraseña";
            return consulta;
        }
        /* public String eliminarProfesional()
         {
             String consulta = "delete from profesional where ciProfesional = @ci";
             return consulta;
         }
         public String eliminarPaciente()
         {
             String consulta = "delete from paciente where ciPaciente = @ci";
             return consulta;
         }*/
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
            String consulta = "select p.ci, p.nombre, p.apellido, p.fechaNacimiento, pr.especialidad  from persona p, profesional pr where p.ci = pr.ciProfesional";
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
            String consulta = "Select * from horario where idConsultorio=@id and dia=@dia ";
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

      
       

        public String horariosLibresPacienteTotales()
        {
            String consulta = "select * from horario where dia > @dia and estado = @estado";
            return consulta;
        }

        public String horariosLibresProfesional()
        {
            String consulta = "select idHorario,hora,dia,idConsultorio  from horario where ciProfesional = @ciProfesional and dia > @dia and idHorario not in (select idHorario from reserva) order by dia,idConsultorio,hora";
            return consulta;
        }

        public String reservasPaciente()
        {
            String consulta = "select r.idreserva,r.idHorario,r.estado from reserva r , horario h where r.idhorario = h.idHorario and h.dia > @dia and r.ciPaciente = @ciPaciente";
            return consulta;
        }

        public String memberHorario()
        {
            String consulta = "select idHorario from horario where idHorario = @id";
            return consulta;
        }

        public String historialReservasPaciente()
        {
            String consulta = "select r.idreserva,r.idHorario,r.estado from reserva r , horario h where r.idhorario = h.idHorario and r.ciPaciente = @ciPaciente";
            return consulta;
        }

        public String eliminarReserva()
        {
            String consulta = "delete from reserva where idReserva = @idReserva;";
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
            String consulta = "insert into reserva (idHorario,ciPaciente,estado) values (@idHorario, @ciPaciente, 'reservado')";
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

        public String cancelarReservaPaciente()
        {
            String consulta = "delete from reserva where idReserva = @idReserva";
            return consulta;
        }

        public String reservasXconfirmar()
        {
            String consulta = "select h.hora, h.dia, c.direccion, r.idReserva,  pe.nombre, pe.apellido from horario h left join reserva r on r.idHorario = h.idHorario left join consultorio c on c.idConsultorio = h.idConsultorio left join persona pe on pe.ci = r.ciPaciente where r.estado = 'reservado' and h.ciProfesional = @ciProfesional order by h.dia;";
            return consulta;
        }

        public String aceptarReserva()
        {
            String consulta = "update reserva set estado='confirmado' where idReserva=@idReserva;";
            return consulta;
        }

        public String rechazarReserva()
        {
            String consulta = "delete from reserva where idReserva = @idReserva;";
            return consulta;
        }

        public String consultorios()
        {
            String consulta = "select * from consultorio";
            return consulta;
        }

        public String pacientesParaAtender()
        {
            String consulta = " select h.hora, h.dia, c.direccion,  pe.nombre, pe.apellido from horario h left join reserva r on r.idHorario = h.idHorario left join consultorio c on c.idConsultorio = h.idConsultorio left join persona pe on pe.ci = r.ciPaciente where r.estado = 'confirmado' and h.ciProfesional = @ciProfesional and h.dia >= @dia order by h.dia; ";
            return consulta;
        }

        public String pacientesAtendido()
        {
            String consulta = " select h.hora, h.dia, c.direccion,  pe.nombre, pe.apellido from horario h left join reserva r on r.idHorario = h.idHorario left join consultorio c on c.idConsultorio = h.idConsultorio left join persona pe on pe.ci = r.ciPaciente where r.estado = 'confirmado' and h.ciProfesional = @ciProfesional and h.dia < @dia order by h.dia;";
            return consulta;
        }

        public String horasLibresProfesional()
        {
            String consulta = "select h.hora, h.dia, c.direccion from horario h left join consultorio c on c.idConsultorio = h.idConsultorio where h.ciProfesional = @ciProfesional and h.dia >= @dia order by dia; ";
            return consulta;
        }

        public String verificarContrasena()
        {
            String consulta = "select ci, contrasena from persona where ci=@ci ";
            return consulta;
        }

        public String consultorioReservado()
        {
            String consulta = "select h.idHorario, h.dia,h.hora, c.direccion from horario h left join reserva r on h.idHorario = r.idHorario left join consultorio c on h.idConsultorio = c.idConsultorio where r.idHorario is null and h.ciProfesional=@ci order by h.dia";
            return consulta;
        }

        public String eliminarConsultorioReservado()
        {
            String consulta = "delete from horario  where idHorario = @idHorario;";
            return consulta;
        }

    }
}
