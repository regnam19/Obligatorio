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

        public List<int> horariosReservadorsDiaXProfesional(DateTime dia,int idConsultorio)
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
