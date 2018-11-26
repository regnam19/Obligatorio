using Logica.VO;
using Logica;
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

            // cambiar cambio pendiente error fecha dia 
            //DateTime dia = DateTime.Today;
            DateTime dia = new DateTime(2019, 01, 01);

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
                long idReserva = Convert.ToInt64(myReader["idReserva"]);
                long idHorario = Convert.ToInt64(myReader["idHorario"]);
                String estado = Convert.ToString(myReader["estado"]);

               
                VOReserva vor = new VOReserva(idReserva,idHorario,ciPaciente,estado);

                lista.Add(vor);
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
                long idReserva = Convert.ToInt64(myReader["idReserva"]);
                long idHorario = Convert.ToInt64(myReader["idHorario"]);
                String estado = Convert.ToString(myReader["estado"]);


                VOReserva vor = new VOReserva(idReserva, idHorario, ciPaciente, estado);

                lista.Add(vor);
            }

            myReader.Close();
            myConnection.Close();

            return lista;
        }

        public void cancelarReservaPaciente(long idReserva)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.cancelarReservaPaciente(), myConnection);

            myCommand.Parameters.AddWithValue("@idReserva", idReserva);

            myCommand.ExecuteNonQuery();

            myConnection.Close();
        }
     

        public List<VOReservaXconfirmar> reservasXconfirmar(long ciProfesional)
        {

             List<VOReservaXconfirmar> lista = new List<VOReservaXconfirmar>();

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.reservasXconfirmar(), myConnection);

            myCommand.Parameters.AddWithValue("@ciProfesional", ciProfesional);


            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                long idReserva = Convert.ToInt64(myReader["idReserva"]);
                int hora = Convert.ToInt32(myReader["hora"]);
                DateTime dia = Convert.ToDateTime(myReader["dia"]);
                String consultorio = Convert.ToString(myReader["direccion"]);
                String nombrePaciente = Convert.ToString(myReader["nombre"]);
                String apellidoPaciente = Convert.ToString(myReader["apellido"]);

                VOReservaXconfirmar vo = new VOReservaXconfirmar(idReserva, hora, dia, consultorio,nombrePaciente,apellidoPaciente);

                lista.Add(vo);
            }

            myReader.Close();
            myConnection.Close();


            return lista;

        }



    }


}
