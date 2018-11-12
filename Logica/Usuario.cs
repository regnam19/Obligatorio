using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Usuario
    {
        private int idUsuario;
        private String usuario;
        private String contraseña;
        private String rol;

        public int IdUsuario { get { return this.idUsuario; } }
        public String NomUsuario {  get { return this.usuario; } }
        public String Contraseña { get { return this.contraseña; } }
        public String Rol { get { return this.rol; } }

        public Usuario(int idUsuario, String usuario, String contraseña, String rol)
        {
            this.idUsuario = idUsuario;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.rol = rol;

        }
    }
}
