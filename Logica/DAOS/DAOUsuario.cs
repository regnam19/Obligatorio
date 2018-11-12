
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class DAOUsuario
    {
        Consultas consulta = new Consultas();
        VOUsuario vous = new VOUsuario();

        public String Rol(String user, String pass)
        {

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.esAdmin(), myConnection);

            myCommand.Parameters.AddWithValue("@usuario", user);
            myCommand.Parameters.AddWithValue("@contraseña", pass);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                String rol = Convert.ToString(myReader["rol"]);
                vous.Rol = rol;

            }
            myReader.Close();
            myConnection.Close();

            return vous.Rol;


        }
    }
}
