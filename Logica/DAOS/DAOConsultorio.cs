using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DAOConsultorio
    {
        Consultas consulta = new Consultas();
        VOConsultorio voc = new VOConsultorio();

        public Boolean Member(long id)
        {

            Boolean existe = false;
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.consultorioObtener(), myConnection);

            myCommand.Parameters.AddWithValue("@id", id);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                existe = true;

            }
            myReader.Close();
            myConnection.Close();

            return existe;


        }

        public VOConsultorio Find(long id)
        {

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.consultorioObtener(), myConnection);

            myCommand.Parameters.AddWithValue("@id", id);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {

                int idc = Convert.ToInt32(myReader["idConsultorio"]);
                String direccion = Convert.ToString(myReader["direccion"]);
                int horaInicio = Convert.ToInt32(myReader["horaInicio"]);
                int horaFin = Convert.ToInt32(myReader["horaFin"]);
              
                voc = new VOConsultorio(idc, direccion, horaInicio, horaFin);


            }
            myReader.Close();
            myConnection.Close();

            return voc;
        }

        public void insert(String direccion, int horaInicio, int horaFin)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.insertarConsultorio(), myConnection);

            myCommand.Parameters.AddWithValue("@direccion", direccion);
            myCommand.Parameters.AddWithValue("@horaInicio", horaInicio);
            myCommand.Parameters.AddWithValue("@horaFin", horaFin);



            myCommand.ExecuteNonQuery();

            myConnection.Close();

        }

        public void update(long idConsultorio, String direccion, int horaInicio, int horaFin)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.modificarConsultorio(), myConnection);

            myCommand.Parameters.AddWithValue("@idConsultorio", idConsultorio);
            myCommand.Parameters.AddWithValue("@direccion", direccion);
            myCommand.Parameters.AddWithValue("@horaInicio", horaInicio);
            myCommand.Parameters.AddWithValue("@horaFin", horaFin);



            myCommand.ExecuteNonQuery();

            myConnection.Close();

        }

        public void delete(long idConsultorio)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.eliminarConsultorio(), myConnection);

            myCommand.Parameters.AddWithValue("@idConsultorio", idConsultorio);



            myCommand.ExecuteNonQuery();

            myConnection.Close();

        }


    }
}
