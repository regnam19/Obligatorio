using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Logica.WINFORMS
{
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Persona frmPersona = new Persona();
            //frmPersona.Show();
            //Hide();
            //this.Size = new Size(739, 600);
            groupBoxTipoPersona p = new groupBoxTipoPersona();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.content.Controls.Clear();
            this.content.Controls.Add(p);
            this.content.Tag = p;
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Size = new Size(482, 336);
            Consultorios c = new Consultorios();
            c.TopLevel = false;
            c.Dock = DockStyle.Fill;
            content.Controls.Clear();
            content.Controls.Add(c);
            this.content.Tag = c;
            c.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TituloYBtns_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        /*private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(739, 600);
            groupBoxTipoPersona p = new groupBoxTipoPersona();
            p.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(p);
            p.Show();
        }*/

        /* private void consultoriosToolStripMenuItem_Click(object sender, EventArgs e)
         {
             this.Size = new Size(482, 336);
             Consultorios c = new Consultorios();
             c.TopLevel = false;
             content.Controls.Clear();
             content.Controls.Add(c);
             c.Show();
         }*/

        /*private void volverARegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(482, 336);
            Registros r = new Registros();
            r.FormBorderStyle = FormBorderStyle.None;
            r.menuStrip1.Visible = false;
            r.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(r);
            r.Show();
        }*/

        /* private void salirToolStripMenuItem_Click(object sender, EventArgs e)
         {
             Application.Exit();
         }*/


    }
}
