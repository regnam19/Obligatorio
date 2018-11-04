using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Consultas
    {
        public String profesionalListar()
        {
            String consulta = "select * from profesional";

            return consulta;
        }

        public String profesionalObtenerUno()
        {
            String consulta = "Select * from profesional where ci=@ci";
            return consulta;
        }

        public String horarioDia()
        {
            String consulta = "Select * from horario where idConsultorio=@id and dia=@dia";
            return consulta;
        }

        public String horariosDiaPaciente()
        {
            String consulta = "select * from horario where dia = @dia and ciProfesional = @ci and estado = @estado and hora = @hora;
            return consulta;
        }

        public String consultorioObtener()
        {
            String consulta = "select * from consultorio where idConsultorio=@id";
            return consulta;
        }

        public String horariosLibreProfesional()
        {
            String consulta = "select * from horario where dia > @dia and ciProfesional = @ci";
            return consulta;
        }

    }
}
