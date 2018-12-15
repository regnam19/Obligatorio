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
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Persona frmPersona = new Persona();
            frmPersona.Show();
            Hide();*/
            this.Size = new Size(739, 600);
            groupBoxTipoPersona p = new groupBoxTipoPersona();
            p.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(p);
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(482, 336);
            Consultorios c = new Consultorios();
            c.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(c);
            c.Show();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(739, 600);
            groupBoxTipoPersona p = new groupBoxTipoPersona();
            p.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(p);
            p.Show();
        }

        private void consultoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(482, 336);
            Consultorios c = new Consultorios();
            c.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(c);
            c.Show();
        }

        private void volverARegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(482, 336);
            Registros r = new Registros();
            r.FormBorderStyle = FormBorderStyle.None;
            r.menuStrip1.Visible = false;
            r.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(r);
            r.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
