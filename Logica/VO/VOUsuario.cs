using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VOUsuario
    {
        public int IdUsuario { get; set; }
        public String Usuario { get; set; }
        public String Contraseña { get; set; }
        public String Rol { get; set; }


        public VOUsuario(int idUsuario, String usuario, String contraseña, String rol)
        {
            this.IdUsuario = idUsuario;
            this.Usuario = usuario;
            this.Contraseña = contraseña;
            this.Rol = rol;
        }

        public VOUsuario() { }
    }
}
