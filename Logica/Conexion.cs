using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Conexion
    {
        private static string myConnection = "Data Source=.; Initial Catalog = obligatorio; Integrated Security = true";

        public static string MyConnection
        {
            get { return MyConnection; }
        }
    }
}

