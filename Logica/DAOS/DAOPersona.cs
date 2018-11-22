using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DAOPersona
    {
        Consultas consulta = new Consultas();
        VOPersona vope = new VOPersona();

        public Boolean Member(long ci)
        {
            Boolean existe = false;
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.buscarPersona(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);

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
                vope = new VOPersona(ci, nombre, apellido, celular, fechaNacimiento, direccion, habilitado);

            }
            return vope;
        }
        public void insert(long ci, String nombre, String apellido, String celular, DateTime fechaNacimiento, String direccion, String contraseña, bool habilitado)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.insertarPersona(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);
            myCommand.Parameters.AddWithValue("@nombre", nombre);
            myCommand.Parameters.AddWithValue("@apellido", apellido);
            myCommand.Parameters.AddWithValue("@celular", celular);
            myCommand.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
            myCommand.Parameters.AddWithValue("@direccion", direccion);
            myCommand.Parameters.AddWithValue("@contraseña", contraseña);
            myCommand.Parameters.AddWithValue("@habilitado", habilitado);


            myCommand.ExecuteNonQuery();

            myConnection.Close();
           
        }
        public void update(long ci, String nombre, String apellido, String celular, DateTime fechaNacimiento, String direccion, bool habilitado)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.modificarPersona(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);
            myCommand.Parameters.AddWithValue("@nombre", nombre);
            myCommand.Parameters.AddWithValue("@apellido", apellido);
            myCommand.Parameters.AddWithValue("@celular", celular);
            myCommand.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
            myCommand.Parameters.AddWithValue("@direccion", direccion);

            myCommand.Parameters.AddWithValue("@habilitado", habilitado);


            myCommand.ExecuteNonQuery();

            myConnection.Close();

        }
        public void delete(long ci)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.eliminarPersona(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);

            myCommand.ExecuteNonQuery();

            myConnection.Close();

        }
    }
}
