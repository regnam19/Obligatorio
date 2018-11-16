﻿using System;
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

        public Boolean esAdmin(long ci)
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
    }
}
