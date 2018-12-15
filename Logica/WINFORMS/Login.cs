using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.wsObligatorioCliente;

namespace Logica.WINFORMS
{
    public partial class Login : Form
    {
        Service1 ws = new Logica.wsObligatorioCliente.Service1();

        public Login()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            Principal frmPrincipal = new Principal();
            if (ws.esAdmin(Int64.Parse(textBoxUser.Text)))
            {
                frmPrincipal.Show();
                Hide();
            }
            else
            {
                 MessageBox.Show("Usuario y/o contraseña correcta", "ABMAdmin", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }



    }

}
}
