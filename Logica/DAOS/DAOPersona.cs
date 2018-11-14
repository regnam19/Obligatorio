using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class DAOPersona
    {
        Consultas consulta = new Consultas();
        VOPersona vope = new VOPersona();

        public VOPersona find (long ci)
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
                String celular = Convert.ToString(myReader["celular"]);
                DateTime fechaNacimiento = Convert.ToDateTime(myReader["fechaNacimiento"]);
                String direccion = Convert.ToString(myReader["direccion"]);
                bool habilitado = Convert.ToBoolean(myReader["habilitado"]);
                int idUsuario = Convert.ToInt32(myReader["idUsuario"]);
                vope = new VOPersona(ci, nombre, apellido, celular, fechaNacimiento, direccion, habilitado, idUsuario);

            }
            return vope;
        }
        public void insert(long ci, string nombre, string apellido, string celular, string direccion, bool habilitado)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.insertarPersona(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);
            myCommand.Parameters.AddWithValue("@nombre", nombre);
            myCommand.Parameters.AddWithValue("@apellido", apellido);
            myCommand.Parameters.AddWithValue("@celular", celular);
           // myCommand.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
            myCommand.Parameters.AddWithValue("@direccion", direccion);
            myCommand.Parameters.AddWithValue("@habilitado", habilitado);


            myCommand.ExecuteNonQuery();

            myConnection.Close();
           
        }
        public void update(long ci, string nombre, string apellido, string celular, string direccion, bool habilitado)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.modificarPersona(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);
            myCommand.Parameters.AddWithValue("@nombre", nombre);
            myCommand.Parameters.AddWithValue("@apellido", apellido);
            myCommand.Parameters.AddWithValue("@celular", celular);
            // myCommand.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
            myCommand.Parameters.AddWithValue("@direccion", direccion);
            myCommand.Parameters.AddWithValue("@habilitado", habilitado);


            myCommand.ExecuteNonQuery();

            myConnection.Close();

        }
        public void delete(long ci)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            SqlCommand myCommand = new SqlCommand(consulta.eliminarPersona(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);

            myCommand.ExecuteNonQuery();

            myConnection.Close();

        }
    }
}
