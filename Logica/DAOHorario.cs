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

        public List<int> horariosReservadorsDia(DateTime dia,int idConsultorio)
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
        

    }
}
