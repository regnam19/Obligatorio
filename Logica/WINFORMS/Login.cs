using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.WINFORMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Fachada f = new Fachada();
            Principal frmPrincipal = new Principal();
            if (f.esAdmin(Int64.Parse(textBoxUser.Text)))
            {
                 frmPrincipal.Show();
                 Hide();
            } 
                
          }

    }
}
