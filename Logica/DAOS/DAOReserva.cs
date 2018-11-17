using Logica.VO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.DAOS
{
    public class DAOReserva
    {
        Consultas consulta = new Consultas();

        //devuelve horarios de un paciente
        public List<VOReserva> reservasPaciente(long ciPaciente)
        {
            List<VOReserva> lista = new List<VOReserva>();

            DateTime dia = DateTime.Today;

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.reservasPaciente(), myConnection);


            myCommand.Parameters.AddWithValue("@ciPaciente", ciPaciente);
            myCommand.Parameters.AddWithValue("@dia", dia);


            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {

                long idHorario = Convert.ToInt64(myReader["idHorario"]);
                String estado = Convert.ToString(myReader["estado"]);

                VOReserva vohd = new VOReserva(idHorario, ciPaciente, estado);

                lista.Add(vohd);
            }

            myReader.Close();
            myConnection.Close();


            return lista;
        }

        public void deleteReserva(long idReserva)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.eliminarReserva(), myConnection);

            myCommand.Parameters.AddWithValue("@idReserva", idReserva);

            myCommand.ExecuteNonQuery();

            myConnection.Close();
        }

        public List<VOReserva> historialRservasPaciente(long ciPaciente)
        {
            List<VOReserva> lista = new List<VOReserva>();

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.historialReservasPaciente(), myConnection);


            myCommand.Parameters.AddWithValue("@ciPaciente", ciPaciente);


            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {

                long idHorario = Convert.ToInt64(myReader["idHorario"]);
                String estado = Convert.ToString(myReader["estado"]);

                VOReserva vohd = new VOReserva(idHorario, ciPaciente, estado);

                lista.Add(vohd);
            }

            myReader.Close();
            myConnection.Close();


            return lista;
        }
    }
}
