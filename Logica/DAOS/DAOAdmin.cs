using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DAOAdmin
    {
        Consultas consulta = new Consultas();
        VOAdmin voad = new VOAdmin();

        public Boolean member(long ci)
        {
            bool esadmin = false;
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.esAdmin(), myConnection);

            myCommand.Parameters.AddWithValue("@usuario", ci);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
             
                     esadmin = true;

            }
            myReader.Close();
            myConnection.Close();

            return esadmin;
            
        }
        public void insert(long ci)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.insertarAdmin(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);



            myCommand.ExecuteNonQuery();

            myConnection.Close();

        }
        public void delete(long ci)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.eliminarAdmin(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);

            myCommand.ExecuteNonQuery();

            myConnection.Close();

        }
        public VOAdmin find(long ci)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.buscarPersona(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                String nombre = Convert.ToString(myReader["nombre"]);
                String apellido = Convert.ToString(myReader["apellido"]);
                DateTime fechaNacimiento = Convert.ToDateTime(myReader["fechaNacimiento"]);
                String celular = Convert.ToString(myReader["celular"]);
                String direccion = Convert.ToString(myReader["direccion"]);
                bool habilitado = Convert.ToBoolean(myReader["habilitado"]);
                voad = new VOAdmin(ci, nombre, apellido, fechaNacimiento,celular, direccion, habilitado);

            }
            return voad;
        }
        public Boolean ContraseñaCorrecta(String contraseña)
        {
            bool esadmin = false;
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.contraseñaCorrecta(), myConnection);

            myCommand.Parameters.AddWithValue("@contraseña", contraseña);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {

                esadmin = true;

            }
            myReader.Close();
            myConnection.Close();

            return esadmin;

        }
    }
}
