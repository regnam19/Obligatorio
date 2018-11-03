using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Horarios
    {
        private Dictionary< long, Horario> diccHorarios;

        //operaciones del TAD diccionario 
        public Horarios()
        {
            diccHorarios = new Dictionary<long, Horario>();
        }

        public bool EsVacio()
        {
            return diccHorarios.Any();
        }

        public void InsertarHorario(long id, Horario h)
        {
            diccHorarios.Add(id, h);
        }

        public bool Member(long id)
        {
            return diccHorarios.ContainsKey(id);
        }

        public Horario Find(long id)
        {
            return diccHorarios[id];
        }

        public void BorrarHorarios(long id)
        {
            diccHorarios.Remove(id);
        }

        public void Destruir()
        {
            diccHorarios.Clear();
        }

        public List<Horario> ListarHorarios()
        {
            List<Horario> lista = new List<Horario>();
            foreach (var h in diccHorarios.Values)
            {
                lista.Add(h);
            }
            return lista;
        }


    }
}
