using System;
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

        // sirve para ver los horarios que ya fueron reservados por profesionales
        public List<int> horariosReservadosDiaXProfesional(DateTime dia,int idConsultorio)
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
                Console.WriteLine("Entro IF");
                disponible = true;
            }

            myReader.Close();
            myConnection.Close();

            return disponible;

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
