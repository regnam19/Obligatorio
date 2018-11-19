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
    public partial class Consultorios : Form
    {
        public Consultorios()
        {
            InitializeComponent();
        }

        private void textBoxHoraFin_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            labelId.Visible = false;
            labelDireccion.Visible = true;
            labelHoraInicio.Visible = true;
            labelHoraFin.Visible = true;

            buttonBuscar.Visible = false;

            textBoxId.Visible = false;
            textBoxDireccion.Visible = true;
            textBoxHoraInicio.Visible = true;
            textBoxHoraFin.Visible = true;

            textBoxId.Enabled = true;
            textBoxDireccion.Enabled = true;
            textBoxHoraInicio.Enabled = true;
            textBoxHoraFin.Enabled = true;

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            labelId.Visible = true;
            textBoxId.Visible = true;

            buttonBuscar.Visible = true;

            textBoxId.Enabled = true;
            textBoxDireccion.Enabled = true;
            textBoxHoraInicio.Enabled = true;
            textBoxHoraFin.Enabled = true;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            labelId.Visible = true;
            labelDireccion.Visible = true;
            labelHoraInicio.Visible = true;
            labelHoraFin.Visible = true;

            buttonBuscar.Visible = true;

            textBoxId.Visible = true;
            textBoxDireccion.Visible = true;
            textBoxHoraInicio.Visible = true;
            textBoxHoraFin.Visible = true;

            textBoxId.Enabled = true;
            textBoxDireccion.Enabled = false;
            textBoxHoraInicio.Enabled = false;
            textBoxHoraFin.Enabled = false;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            labelDireccion.Visible = true;
            labelHoraInicio.Visible = true;
            labelHoraFin.Visible = true;

            textBoxDireccion.Visible = true;
            textBoxHoraInicio.Visible = true;
            textBoxHoraFin.Visible = true;

        }

    }
}
