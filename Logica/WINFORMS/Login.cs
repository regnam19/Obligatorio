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
using System.Runtime.InteropServices;

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

            Registros frmRegistros = new Registros();
            if (textBoxUser.Text != String.Empty)
            {
                if (ws.esAdmin(Int64.Parse(textBoxUser.Text)))
                {
                    frmRegistros.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña correcta", "ABMAdmin", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }


    }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            if(textBoxUser.Text == "USUARIO")
            {
                textBoxUser.Text = "";
                textBoxUser.ForeColor = Color.LightGray;
            }
        }

        private void textBoxUser_Leave(object sender, EventArgs e)
        {
            if(textBoxUser.Text == "")
            {
                textBoxUser.Text = "USUARIO";
                textBoxUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
