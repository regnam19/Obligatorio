using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Profesionales
    {
        private Dictionary<long, Profesional> diccProfesionales;

        //operaciones del TAD diccionario 
        public Profesionales()
        {
            diccProfesionales = new Dictionary<long, Profesional>();
        }

        public bool EsVacio()
        {
            return diccProfesionales.Any();
        }

        public void InsertarProfesional(long ci, Profesional p)
        {
            diccProfesionales.Add(ci, p);
        }

        public bool Member(long ci)
        {
            return diccProfesionales.ContainsKey(ci);
        }

        public Profesional Find(long ci)
        {
            return diccProfesionales[ci];
        }

        public void BorrarProfesional(long ci)
        {
            diccProfesionales.Remove(ci);
        }

        public void Destruir()
        {
            diccProfesionales.Clear();
        }

        /*
        public List<Profesional> ListarProfesionales()
        {
            List<Profesional> lista = new List<Profesional>();
            foreach (var p in diccProfesionales.Values)
            {
                lista.Add(p);
            }
            return lista;
        }
        */
   
    }
}
