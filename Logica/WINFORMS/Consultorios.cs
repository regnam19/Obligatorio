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
    public partial class Consultorios : Form
    {
        public Consultorios()
        {
            InitializeComponent();
        }
        VOConsultorio voc = new VOConsultorio();
        Service1 ws = new Logica.wsObligatorioCliente.Service1();
       

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

            textBoxId.Enabled = false;
            textBoxDireccion.Enabled = true;
            textBoxHoraInicio.Enabled = true;
            textBoxHoraFin.Enabled = true;

            if (textBoxDireccion.Text != String.Empty && (textBoxHoraInicio.Text != String.Empty) && (textBoxHoraFin.Text != String.Empty))
            {
                ws.ingresarConsultorio(textBoxDireccion.Text, Int32.Parse(textBoxHoraInicio.Text), Int32.Parse(textBoxHoraFin.Text));
                limpiarTextBox();
                MessageBox.Show("Consultorio agregado exitosamente", "ABMConsultorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
              


        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            labelId.Visible = true;
            labelDireccion.Visible = true;
            labelHoraInicio.Visible = true;
            labelHoraFin.Visible = true;
            textBoxId.Visible = true;
            textBoxDireccion.Visible = true;
            textBoxHoraInicio.Visible = true;
            textBoxHoraFin.Visible = true;
            buttonBuscar.Visible = true;

            textBoxId.Enabled = true;
            textBoxDireccion.Enabled = true;
            textBoxHoraInicio.Enabled = true;
            textBoxHoraFin.Enabled = true;

            if (textBoxId.Text != String.Empty && (textBoxDireccion.Text != String.Empty && (textBoxHoraInicio.Text != String.Empty) && (textBoxHoraFin.Text != String.Empty)))
                try
            {
                ws.modificarConsultorio(Int64.Parse(textBoxId.Text), textBoxDireccion.Text, Int32.Parse(textBoxHoraInicio.Text), Int32.Parse(textBoxHoraFin.Text));
                limpiarTextBox();
                MessageBox.Show("Consultorio modificado exitosamente", "ABMConsultorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            catch (ConsultorioInvalido)
            {
                limpiarTextBox();
                MessageBox.Show("Id de Consultorio no existe", "ABMConsultorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
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
            try
            {
                if (textBoxId.Text != String.Empty)
                {
                    ws.eliminarConsultorio(Int64.Parse(textBoxId.Text));
                    limpiarTextBox();
                    MessageBox.Show("Consultorio eliminado exitosamente", "ABMConsultorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            } catch (ConsultorioInvalido)
            {
                limpiarTextBox();
                MessageBox.Show("Id de Consultorio no existe", "ABMConsultorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
           

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            labelDireccion.Visible = true;
            labelHoraInicio.Visible = true;
            labelHoraFin.Visible = true;

            textBoxDireccion.Visible = true;
            textBoxHoraInicio.Visible = true;
            textBoxHoraFin.Visible = true;
            try
            {
                Fachada f = new Fachada();
                voc = f.darConsultorio(Int64.Parse(textBoxId.Text));
                textBoxDireccion.Text = voc.Direccion;
                textBoxHoraFin.Text = voc.HoraFin.ToString();
                textBoxHoraInicio.Text = voc.HoraInicio.ToString();
            } catch (ConsultorioInvalido)
            {
                limpiarTextBox();
                MessageBox.Show("Id de Consultorio no existe", "ABMConsultorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
         }
        private void limpiarTextBox()
        {
            textBoxId.Text = "";
            textBoxDireccion.Text = "";
            textBoxHoraInicio.Text = "";
            textBoxHoraFin.Text = "";
        }

        private void textBoxHoraInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxHoraFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
