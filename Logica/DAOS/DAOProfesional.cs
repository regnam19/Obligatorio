﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DAOProfesional
    {
        Consultas consulta = new Consultas();
     
        VOProfesional vop;

        public Boolean Member(long ci)
        {
            Boolean existe = false;
            //String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(Conexion.MyConnection);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.profesionalObtenerUno(), myConnection);

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
        
        public VOProfesional Find(long ci)
        {
            //String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(Conexion.MyConnection);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.profesionalObtenerUno(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);
            myCommand.Parameters.AddWithValue("@ciProfesional", ci);

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
                String especialidad = Convert.ToString(myReader["especialidad"]);
                vop = new VOProfesional(cedula, nombre, apellido, fecha, celular, habilitado, especialidad);

     
            }
            myReader.Close();
            myConnection.Close();

            return vop;
        }

        public List<VOListarProfesional> listarProfesionales()
        {
            List<VOListarProfesional> lista = new List<VOListarProfesional>();

            //String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(Conexion.MyConnection);

            myConnection.Open();


            SqlCommand myCommand = new SqlCommand(consulta.profesionalListar (), myConnection);

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                String nombre = Convert.ToString(myReader["nombre"]);
                String apellido = Convert.ToString(myReader["apellido"]);
                DateTime fecha = Convert.ToDateTime(myReader["fechaNacimiento"]);
                String especialidad = Convert.ToString(myReader["especialidad"]);
                VOListarProfesional vop = new VOListarProfesional(nombre, apellido, fecha, especialidad);

                lista.Add(vop);

            }
            myReader.Close();
            myConnection.Close();

            return lista;
        }
    }
}