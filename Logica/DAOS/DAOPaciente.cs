using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DAOPaciente
    {
        Consultas consulta = new Consultas();
        VOPaciente vopa;

        public Boolean Member(long ci)
        {
            Boolean existe = false;
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.esPaciente(), myConnection);

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
        public VOPaciente Find(long ci)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.pacienteObtenerUno(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {

                long cedula = Convert.ToInt64(myReader["ci"]);
                String nombre = Convert.ToString(myReader["nombre"]);
                String apellido = Convert.ToString(myReader["apellido"]);
                DateTime fecha = Convert.ToDateTime(myReader["fechaNacimiento"]);
                String celular = Convert.ToString(myReader["celular"]);
                Boolean habilitado = Convert.ToBoolean(myReader["habilitado"]);
                String celularEmergenica = Convert.ToString(myReader["celularEmergencia"]);
                String contactoEmergencia = Convert.ToString(myReader["contactoEmergencia"]);
                String emergenciaMovil = Convert.ToString(myReader["emergenciaMovil"]);
                String mutualista = Convert.ToString(myReader["mutualista"]);
                vopa = new VOPaciente(cedula, nombre, apellido, fecha, celular, habilitado,celularEmergenica, contactoEmergencia, emergenciaMovil, mutualista);


            }
            myReader.Close();
            myConnection.Close();

            return vopa;
        }
        //hacer un vo para listar paciente
        
        public List<VOPaciente> listarPacientes()
        {
            List<VOPaciente> lista = new List<VOPaciente>();

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();


            SqlCommand myCommand = new SqlCommand(consulta.pacienteListar(), myConnection);

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                String nombre = Convert.ToString(myReader["nombre"]);
                String apellido = Convert.ToString(myReader["apellido"]);
                DateTime fecha = Convert.ToDateTime(myReader["fechaNacimiento"]);
                String contactoEmergencia = Convert.ToString(myReader["contactoEmergencia"]);
                String emergenciaMovil = Convert.ToString(myReader["emergenciaMovil"]);
                String mutualista = Convert.ToString(myReader["mutualista"]);
               

                lista.Add(vopa);

            }
            myReader.Close();
            myConnection.Close();

            return lista;
        }

        public void insert(long ci, String contactoEmergencia, String celularEmergencia, String emergenciaMovil, String mutualista)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.insertarPaciente(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);
            myCommand.Parameters.AddWithValue("@contactoEmergencia", contactoEmergencia);
            myCommand.Parameters.AddWithValue("@celularEmergencia", celularEmergencia);
            myCommand.Parameters.AddWithValue("@emergenciaMovil", emergenciaMovil);
            myCommand.Parameters.AddWithValue("@mutualista", mutualista);


            myCommand.ExecuteNonQuery();

            myConnection.Close();

        }
        public void update(long ci, String contactoEmergencia, String celularEmergencia, String emergenciaMovil, String mutualista)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.modificarPaciente(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);
            myCommand.Parameters.AddWithValue("@contactoEmergencia", contactoEmergencia);
            myCommand.Parameters.AddWithValue("@celularEmergencia", celularEmergencia);
            myCommand.Parameters.AddWithValue("@emergenciaMovil", emergenciaMovil);
            myCommand.Parameters.AddWithValue("@mutualista", mutualista);


            myCommand.ExecuteNonQuery();

            myConnection.Close();

        }
        /*
        public void delete(long ci)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.eliminarPersona(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);

            myCommand.ExecuteNonQuery();

            myConnection.Close();

        }*/
    }
}
