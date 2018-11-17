using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DAOHorario
    {
        VOHorario voh = new VOHorario();

        public void deleteHorarioProfesional(long ci)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.eliminarHorarioProfesional(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);

            myCommand.ExecuteNonQuery();

            myConnection.Close();

        }
        public void deleteHorarioPaciente(long ci)
        {
           /* String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.eliminarHorarioPaciente(), myConnection);

            myCommand.Parameters.AddWithValue("@ci", ci);

            myCommand.ExecuteNonQuery();

            myConnection.Close();
            */
        }
        public Boolean Member(long idHorario)
        {
            Boolean existe = false;
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.memberHorario(), myConnection);

 
            myCommand.Parameters.AddWithValue("@id", idHorario);


            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();

            if (myReader.HasRows)
            {
                existe = true;
            }

            myReader.Close();
            myConnection.Close();

            return existe;

        }

        public Boolean ProfesionalTieneHorario(long ci)
        {
            Boolean existe = false;
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.tieneHorarioProfesional(), myConnection);

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

        /*public Boolean PacienteTieneHorario(long ci)
        {
            Boolean existe = false;
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.tieneHorarioPaciente(), myConnection);

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
        }*/

        public VOHorario Find (long idHorario)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.findHorario(), myConnection);

            DateTime hoy = DateTime.Today;

            myCommand.Parameters.AddWithValue("@id", idHorario);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                int hora = Convert.ToInt32(myReader["hora"]);
                DateTime dia = Convert.ToDateTime(myReader["dia"]);
                int idConsultorio = Convert.ToInt32(myReader["idConsultorio"]);
                long ciProfesional = Convert.ToInt64(myReader["ciProfesional"]);
                String estado = Convert.ToString(myReader["estado"]);
                long ciPaciente = Convert.ToInt64(myReader["ciPaciente"]);
                VOHorario voh = new VOHorario(idHorario,hora,dia,idConsultorio,ciProfesional,estado,ciPaciente);


            }
            myReader.Close();
            myConnection.Close();

           
            return voh;

        }

        // sirve para ver los horarios que ya fueron reservados por profesionales
        public List<int> horariosReservadosConsultorios(DateTime dia,int idConsultorio)
        {
            List<int> horarios = new List<int>();

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.horarioDia(), myConnection);

            myCommand.Parameters.AddWithValue("@dia", dia);
            myCommand.Parameters.AddWithValue("@id", idConsultorio);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                int horario = Convert.ToInt32(myReader["hora"]);

                horarios.Add(horario);
            }
            myReader.Close();
            myConnection.Close();

            horarios.Sort();
            return horarios;
        }



        // trae todos los horarios que ya estan reservados o confirmados, para un dia y consultorio 
        // en particular (todos los no disponibles)
        // HAY QUE VER PARA QUE SIRVE
        public List<int> horariosReservadosDiaXPaciente(DateTime dia,int idConsultorio)
        {
            List<int> horarios = new List<int>();

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.horariosDiaPacienteReservado(), myConnection);

            myCommand.Parameters.AddWithValue("@dia", dia);
            myCommand.Parameters.AddWithValue("@id", idConsultorio);
            myCommand.Parameters.AddWithValue("@estado", "disponible");

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                int horario = Convert.ToInt32(myReader["hora"]);

                horarios.Add(horario);
            }
            myReader.Close();
            myConnection.Close();

            horarios.Sort();
            return horarios;
        }

        // trae los horarios que estan disponibles para los pacientes, en determinado dia en un consultorio
        public List<int> horariosLibresDiaXPaciente(DateTime dia,int idConsultorio)
        {
            List<int> horarios = new List<int>();

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.horariosDiaPacienteLibre(), myConnection);

            myCommand.Parameters.AddWithValue("@dia", dia);
            myCommand.Parameters.AddWithValue("@id", idConsultorio);
            myCommand.Parameters.AddWithValue("@estado", "disponible");

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                int horario = Convert.ToInt32(myReader["hora"]);

                horarios.Add(horario);
            }
            myReader.Close();
            myConnection.Close();

            horarios.Sort();
            return horarios;
        }
        
        // trae todos los horarios disponibles para los pacientes de hoy en adelante
        public List<VOHorario> horariosDisponiblePaciente()
        {
            List<VOHorario> horarios = new List<VOHorario>();

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.horariosDiaPacienteLibre(), myConnection);

            DateTime hoy = DateTime.Today;

            myCommand.Parameters.AddWithValue("@dia", hoy);
            myCommand.Parameters.AddWithValue("@estado", "disponible");

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                int horario = Convert.ToInt32(myReader["hora"]);

              
            }
            myReader.Close();
            myConnection.Close();

            horarios.Sort();
            return horarios;
    
        }

        // sirve para ver si una hora esta disponible para ser reservada por un profesional
        public Boolean horarioDisponibleParaProfesional(int idConsultorio,DateTime dia,int hora)
        {
            Boolean disponible = true;
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.horarioDia(), myConnection);

            myCommand.Parameters.AddWithValue("@dia", dia);
            myCommand.Parameters.AddWithValue("@id", idConsultorio);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                int horario = Convert.ToInt32(myReader["hora"]);
                if (horario == hora)
                    disponible = false;

            }
            myReader.Close();
            myConnection.Close();


            return disponible;
        }

        // sirve para ver si un horario en particular esta disponible para ser reservado por un paciente
        public Boolean horarioDisponibleParaPacientes(int idConsultorio,DateTime dia, int hora)
        {
            Boolean disponible = false;
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.horarioDiaPaciente(), myConnection);

            myCommand.Parameters.AddWithValue("@dia", dia);
            myCommand.Parameters.AddWithValue("@id", idConsultorio);
            myCommand.Parameters.AddWithValue("@estado", "disponible");
            myCommand.Parameters.AddWithValue("@hora", hora);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();

            if (myReader.HasRows)
            {
                disponible = true;
            }

            myReader.Close();
            myConnection.Close();

            return disponible;

        }


        // para requerimiento 1, tras los hroarios disponibles para un profesional en un dia
       public List<VOHorarioDisponible> horasLibresProfesional(long ciProfesional)
        {
            List<VOHorarioDisponible> horarios = new List<VOHorarioDisponible>();

            DateTime dia = DateTime.Today;

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.horariosLibresProfesional(), myConnection);


            myCommand.Parameters.AddWithValue("@ci", ciProfesional);
            myCommand.Parameters.AddWithValue("@dia", dia);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {

                int hora = Convert.ToInt32(myReader["hora"]);
                long idHorario = Convert.ToInt64(myReader["idHorario"]);
                int idConsultorio = Convert.ToInt32(myReader["idConsultorio"]);
                dia = Convert.ToDateTime(myReader["dia"]);

                VOHorarioDisponible vohd = new VOHorarioDisponible(idHorario, hora, idConsultorio,dia);

                horarios.Add(vohd);
            }

            myReader.Close();
            myConnection.Close();


            return horarios;

        }

        // para requerimiento 1
        // asigna un paciente  a un horario y pone estado en reservado
        //FUNCIONA
        public void insertarHorarioPaciente(VOHorarioInsertarPaciente vho)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.insertarHorarioPaciente(), myConnection);
    
            myCommand.Parameters.AddWithValue("@idHorario", vho.IdHorario);
            myCommand.Parameters.AddWithValue("@ciPaciente", vho.CiPaciente);
            myCommand.Parameters.AddWithValue("@estado", "reservado");

            myCommand.ExecuteNonQuery();

            myConnection.Close();
        }

        // para requerimiento 3, trae los horarios reservados y confirmados de un paciente de la fecha de hoy en adelante
        public List<VOHorarioPaciente> horariosPaciente(long ciPaciente)
        {
            List<VOHorarioPaciente> horarios = new List<VOHorarioPaciente>();
            DateTime dia = DateTime.Today;


            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.listarHorariosPaciente(), myConnection);

            myCommand.Parameters.AddWithValue("@dia", dia);
            myCommand.Parameters.AddWithValue("@ciPaciente", ciPaciente);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                long idHorario = Convert.ToInt64(myReader["idHorario"]);
                int hora = Convert.ToInt32(myReader["hora"]);
                dia = Convert.ToDateTime(myReader["dia"]);
                int idConsultorio = Convert.ToInt32(myReader["idConsultorio"]);
                long ciProfesional = Convert.ToInt64(myReader["ciProfesional"]);
                String estado = Convert.ToString(myReader["estado"]);
                VOHorarioPaciente voh = new VOHorarioPaciente(idHorario, hora, dia, idConsultorio, ciProfesional, estado);

                horarios.Add(voh);

            }
            myReader.Close();
            myConnection.Close();

            return horarios;
        }
        
        // para requerimiento 2, pone un horario en disponible y ciPaciente en null
        public void cancelarHoraPaciente(long idHorario)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.cancelarHorarioPaciente(), myConnection);

            myCommand.Parameters.AddWithValue("@idHorario", idHorario);
            myCommand.Parameters.AddWithValue("@estado", "disponible");

            myCommand.ExecuteNonQuery();

            myConnection.Close();
        }
        
        // para requerimiento 4 trae todos los horarios que tenga en estado reservado un profesional
        public List<VOHorarioReservadoProfesional> horariosReservadosProfesional(long ciProfesional)
        {
            List<VOHorarioReservadoProfesional> horarios = new List<VOHorarioReservadoProfesional>();

            DateTime dia = DateTime.Today;


            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.listarHorariosRservadosProfesional(), myConnection);

            myCommand.Parameters.AddWithValue("@dia", dia);
            myCommand.Parameters.AddWithValue("@ciProfesional", ciProfesional);
            myCommand.Parameters.AddWithValue("@estado","reservado");

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                long idHorario = Convert.ToInt64(myReader["idHorario"]);
                int hora = Convert.ToInt32(myReader["hora"]);
                dia = Convert.ToDateTime(myReader["dia"]);
                int idConsultorio = Convert.ToInt32(myReader["idConsultorio"]);
                long ciPaciente = Convert.ToInt64(myReader["ciPaciente"]);
                String estado = Convert.ToString(myReader["estado"]);
                VOHorarioReservadoProfesional voh = new VOHorarioReservadoProfesional(idHorario, hora, dia, idConsultorio, estado, ciPaciente);

                horarios.Add(voh);

            }
            myReader.Close();
            myConnection.Close();


            return horarios; 
        }
        
        // para requerimiento 4, se le pasa un horario y un estado y cambia el estado a ese horario
        public void aceptarCancelarHorarioProfesional(long idHorario, Boolean confirmado)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            if (confirmado)
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(consulta.aceptarHorarioProfesional(), myConnection);

                myCommand.Parameters.AddWithValue("@idHorario", idHorario);
                myCommand.Parameters.AddWithValue("@estado", "confirmado");

                myCommand.ExecuteNonQuery();

                myConnection.Close();

            }
            else
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(consulta.cancelarHorarioProfesional(), myConnection);

                myCommand.Parameters.AddWithValue("@idHorario", idHorario);
                myCommand.Parameters.AddWithValue("@estado", "disponible");

                myCommand.ExecuteNonQuery();

                myConnection.Close();
            }
           
        }
        

        // para requerimiento 5
        public void insertarHorarioProfesional(VOInsertarHorario voih)
        {

            long idHorario = this.obtenerIdHorario();

            //String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();


           
            SqlCommand myCommand = new SqlCommand(consulta.insertarHorario(), myConnection);

            myCommand.Parameters.AddWithValue("@idHorario", idHorario);
            myCommand.Parameters.AddWithValue("@hora", voih.Hora);
            myCommand.Parameters.AddWithValue("@dia", voih.Dia);
            myCommand.Parameters.AddWithValue("@idConsultorio", voih.IdConsultorio);
            myCommand.Parameters.AddWithValue("@ciProfesional", voih.Profesional);
            myCommand.Parameters.AddWithValue("@estado", "disponible");
            
            myCommand.ExecuteNonQuery();

            myConnection.Close();
        }

        // para requerimiento 5
        public long obtenerIdHorario()
        {
            long idHorario = 0;

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.obtenerIdHorario(), myConnection);

         

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                idHorario = Convert.ToInt64(myReader["idHorario"]) + 1;


            }

            myReader.Close();
            myConnection.Close();

            return idHorario;
        }


        // para requerimiento 6, se le pasa una cedula de un profesional y devuelve los horarios confirmados
        public List<VOHorarioProfesional> listarHorariosProfesional(long ciProfesional)
        {
            List<VOHorarioProfesional> horarios = new List<VOHorarioProfesional>();

            //String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            //DateTime dia = DateTime.Today;

            DateTime dia = new DateTime(2018, 1, 1);
            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.obtenerHorarioProfecional(), myConnection);

            myCommand.Parameters.AddWithValue("@dia", dia);
            myCommand.Parameters.AddWithValue("@ciProfesional", ciProfesional);
            myCommand.Parameters.AddWithValue("@estado", "confirmado");

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                long idHorario = Convert.ToInt64(myReader["idHorario"]);
                int hora = Convert.ToInt32(myReader["hora"]);
                dia = Convert.ToDateTime(myReader["dia"]);
                int idConsultorio = Convert.ToInt32(myReader["idConsultorio"]);
                long ciPaciente = Convert.ToInt64(myReader["ciPaciente"]);

                VOHorarioProfesional vo = new VOHorarioProfesional(idHorario, hora, dia, idConsultorio, ciPaciente);
                horarios.Add(vo);
            }
            myReader.Close();
            myConnection.Close();

            return horarios;
        }

        /*
        public List<VOHorario> horariosProfesional(long ci)
        {
            // del dia de hoy en adelante
            List<VOHorario> horarios = new List<VOHorario>();

            String connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            SqlCommand myCommand = new SqlCommand(consulta.horarioDia(), myConnection);

            DateTime hoy = DateTime.Today;

            myCommand.Parameters.AddWithValue("@dia", hoy);
            myCommand.Parameters.AddWithValue("@ci", ci);

            myCommand.ExecuteNonQuery();

            SqlDataReader myReader = myCommand.ExecuteReader();


            while (myReader.Read())
            {
                //if 
                long idHorario = Convert.ToInt64(myReader["idHorario"]);
                int hora = Convert.ToInt32(myReader["hora"]);
                DateTime dia = Convert.ToDateTime(myReader["dia"]);
                int idConsultorio = Convert.ToInt32(myReader["idConsultorio"]);
                long ciProfesional = Convert.ToInt64(myReader["ciProfesional"]);

                horarios.Add(horario);
            }
            myReader.Close();
            myConnection.Close();

            horarios.Sort();

        }
        */
    }
}
