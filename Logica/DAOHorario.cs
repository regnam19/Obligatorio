﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DAOHorario
    {
        Consultas consulta = new Consultas();
        VOHorario voh = new VOHorario();

        public Boolean Member(long idHorario)
        {
            Boolean existe = false;
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.memberHorario(), myConnection);

 
            myCommand.Parameters.AddWithValue("@id", idHorario);


            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();

            if (myReader.HasRows)
            {
                existe = true;
            }

            myReader.Close();
            myConnection.Close();

            return existe;

        }

        public VOHorario Find (long idHorario)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.findHorario(), myConnection);

            DateTime hoy = DateTime.Today;

            myCommand.Parameters.AddWithValue("@id", idHorario);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                int hora = Convert.ToInt32(myReader["hora"]);
                DateTime dia = Convert.ToDateTime(myReader["dia"]);
                int idConsultorio = Convert.ToInt32(myReader["idConsultorio"]);
                long ciProfesional = Convert.ToInt64(myReader["ciProfesional"]);
                String estado = Convert.ToString(myReader["estado"]);
                long ciPaciente = Convert.ToInt64(myReader["ciPaciente"]);
                VOHorario voh = new VOHorario(idHorario,hora,dia,idConsultorio,ciProfesional,estado,ciPaciente);


            }
            myReader.Close();
            myConnection.Close();

           
            return voh;

        }

        // sirve para ver los horarios que ya fueron reservados por profesionales
        public List<int> horariosReservadosConsultorios(DateTime dia,int idConsultorio)
        {
            List<int> horarios = new List<int>();

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.horarioDia(), myConnection);

            myCommand.Parameters.AddWithValue("@dia", dia);
            myCommand.Parameters.AddWithValue("@id", idConsultorio);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                int horario = Convert.ToInt32(myReader["hora"]);

                horarios.Add(horario);
            }
            myReader.Close();
            myConnection.Close();

            horarios.Sort();
            return horarios;
        }

        // trae todos los horarios que ya estan reservados o confirmados, para un dia y consultorio 
        // en particular (todos los no disponibles)
        // HAY QUE VER PARA QUE SIRVE
        public List<int> horariosReservadosDiaXPaciente(DateTime dia,int idConsultorio)
        {
            List<int> horarios = new List<int>();

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.horariosDiaPacienteReservado(), myConnection);

            myCommand.Parameters.AddWithValue("@dia", dia);
            myCommand.Parameters.AddWithValue("@id", idConsultorio);
            myCommand.Parameters.AddWithValue("@estado", "disponible");

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                int horario = Convert.ToInt32(myReader["hora"]);

                horarios.Add(horario);
            }
            myReader.Close();
            myConnection.Close();

            horarios.Sort();
            return horarios;
        }

        // trae los horarios que estan disponibles para los pacientes, en determinado dia en un consultorio
        public List<int> horariosLibresDiaXPaciente(DateTime dia,int idConsultorio)
        {
            List<int> horarios = new List<int>();

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.horariosDiaPacienteLibre(), myConnection);

            myCommand.Parameters.AddWithValue("@dia", dia);
            myCommand.Parameters.AddWithValue("@id", idConsultorio);
            myCommand.Parameters.AddWithValue("@estado", "disponible");

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                int horario = Convert.ToInt32(myReader["hora"]);

                horarios.Add(horario);
            }
            myReader.Close();
            myConnection.Close();

            horarios.Sort();
            return horarios;
        }
        // trae todos los horarios disponibles para los pacientes de hoy en adelante
        public List<VOHorario> horariosDisponiblePaciente()
        {
            List<VOHorario> horarios = new List<VOHorario>();

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.horariosDiaPacienteLibre(), myConnection);

            DateTime hoy = DateTime.Today;

            myCommand.Parameters.AddWithValue("@dia", hoy);
            myCommand.Parameters.AddWithValue("@estado", "disponible");

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                int horario = Convert.ToInt32(myReader["hora"]);

              
            }
            myReader.Close();
            myConnection.Close();

            horarios.Sort();
            return horarios;
    
        }

        // sirve para ver si una hora esta disponible para ser reservada por un profesional
        public Boolean horarioDisponibleParaProfesional(int idConsultorio,DateTime dia,int hora)
        {
            Boolean disponible = true;
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.horarioDia(), myConnection);

            myCommand.Parameters.AddWithValue("@dia", dia);
            myCommand.Parameters.AddWithValue("@id", idConsultorio);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                int horario = Convert.ToInt32(myReader["hora"]);
                if (horario == hora)
                    disponible = false;

            }
            myReader.Close();
            myConnection.Close();


            return disponible;
        }

        // sirve para ver si un horario en particular esta disponible para ser reservado por un paciente
        public Boolean horarioDisponibleParaPacientes(int idConsultorio,DateTime dia, int hora)
        {
            Boolean disponible = false;
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.horarioDiaPaciente(), myConnection);

            myCommand.Parameters.AddWithValue("@dia", dia);
            myCommand.Parameters.AddWithValue("@id", idConsultorio);
            myCommand.Parameters.AddWithValue("@estado", "disponible");
            myCommand.Parameters.AddWithValue("@hora", hora);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();

            if (myReader.HasRows)
            {
                disponible = true;
            }

            myReader.Close();
            myConnection.Close();

            return disponible;

        }


        // para requerimiento 1, tras los hroarios disponibles para un profesional en un dias
       public List<VOHorarioDisponible> horasLibresProfesional(DateTime dia,long ciProfesional)
        {
            List<VOHorarioDisponible> horarios = new List<VOHorarioDisponible>();

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.horariosLibresProfesional(), myConnection);


            myCommand.Parameters.AddWithValue("@ci", ciProfesional);
            myCommand.Parameters.AddWithValue("@dia", dia);
            myCommand.Parameters.AddWithValue("@estado", "disponible");

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {

                int hora = Convert.ToInt32(myReader["hora"]);
                long idHorario = Convert.ToInt64(myReader["idHorario"]);
                int idConsultorio = Convert.ToInt32(myReader["idConsultorio"]);

                VOHorarioDisponible vohd = new VOHorarioDisponible(idHorario, hora, idConsultorio);

                horarios.Add(vohd);
            }

            myReader.Close();
            myConnection.Close();


            return horarios;

        }

        // para requerimiento 1
        // asigna un paciente  a un horario y pone estado en reservado
        public void insertarHorarioPaciente(VOHorarioInsertarPaciente vho)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.insertarHorarioPaciente(), myConnection);
    
            myCommand.Parameters.AddWithValue("@idHorario", vho.IdHorario);
            myCommand.Parameters.AddWithValue("@ciPaciente", vho.CiPaciente);
            myCommand.Parameters.AddWithValue("@estado", "reservado");

            myCommand.ExecuteNonQuery();
        }

        // para requerimiento 2, trae los horarios reservados y confirmados de un paciente de la fecha de hoy en adelante
        public List<VOHorarioPaciente> horariosPaciente(long ciPaciente)
        {
            List<VOHorarioPaciente> horarios = new List<VOHorarioPaciente>();
            DateTime dia = DateTime.Today;


            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.listarHorariosPaciente(), myConnection);

            myCommand.Parameters.AddWithValue("@dia", dia);
            myCommand.Parameters.AddWithValue("@ciPaciente", ciPaciente);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                long idHorario = Convert.ToInt64(myReader["idHorario"]);
                int hora = Convert.ToInt32(myReader["hora"]);
                dia = Convert.ToDateTime(myReader["dia"]);
                int idConsultorio = Convert.ToInt32(myReader["idConsultorio"]);
                long ciProfesional = Convert.ToInt64(myReader["ciProfesional"]);
                String estado = Convert.ToString(myReader["estado"]);
                VOHorarioPaciente voh = new VOHorarioPaciente(idHorario, hora, dia, idConsultorio, ciProfesional, estado);

                horarios.Add(voh);

            }
            myReader.Close();
            myConnection.Close();

            return horarios;
        }
        

        
        
        
        /*
        public List<VOHorario> horariosProfesional(long ci)
        {
            // del dia de hoy en adelante
            List<VOHorario> horarios = new List<VOHorario>();

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.horarioDia(), myConnection);

            DateTime hoy = DateTime.Today;

            myCommand.Parameters.AddWithValue("@dia", hoy);
            myCommand.Parameters.AddWithValue("@ci", ci);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                //if 
                long idHorario = Convert.ToInt64(myReader["idHorario"]);
                int hora = Convert.ToInt32(myReader["hora"]);
                DateTime dia = Convert.ToDateTime(myReader["dia"]);
                int idConsultorio = Convert.ToInt32(myReader["idConsultorio"]);
                long ciProfesional = Convert.ToInt64(myReader["ciProfesional"]);

                horarios.Add(horario);
            }
            myReader.Close();
            myConnection.Close();

            horarios.Sort();

        }
        */
    }
}
