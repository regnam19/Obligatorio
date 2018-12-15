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
            comboBoxHoraInicio.Visible = true;
            comboBoxHoraFin.Visible = true;

            textBoxId.Enabled = false;
            textBoxDireccion.Enabled = true;
            comboBoxHoraInicio.Enabled = true;
            comboBoxHoraFin.Enabled = true;

            if (textBoxDireccion.Text != String.Empty && (comboBoxHoraInicio.Text != String.Empty) && (comboBoxHoraFin.Text != String.Empty))
            {
                if (Int32.Parse(comboBoxHoraInicio.Text) < Int32.Parse(comboBoxHoraFin.Text))
                {
                    ws.ingresarConsultorio(textBoxDireccion.Text, Int32.Parse(comboBoxHoraInicio.Text), Int32.Parse(comboBoxHoraFin.Text));
                    limpiarTextBox();
                    MessageBox.Show("Consultorio agregado exitosamente", "ABMConsultorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                } else
                    MessageBox.Show("ERROR: Hora inicio es mayor a hora fin", "ABMConsultorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
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
            comboBoxHoraInicio.Visible = true;
            comboBoxHoraFin.Visible = true;
            buttonBuscar.Visible = true;

            textBoxId.Enabled = true;
            textBoxDireccion.Enabled = true;
            comboBoxHoraInicio.Enabled = true;
            comboBoxHoraFin.Enabled = true;

            if (textBoxId.Text != String.Empty && (textBoxDireccion.Text != String.Empty && (comboBoxHoraInicio.Text != String.Empty) && (comboBoxHoraFin.Text != String.Empty)))
                try
                {
                    if (ws.consultorioExiste(Int64.Parse(textBoxId.Text)))
                    {
                        ws.modificarConsultorio(Int64.Parse(textBoxId.Text), textBoxDireccion.Text, Int32.Parse(comboBoxHoraInicio.Text), Int32.Parse(comboBoxHoraFin.Text));
                        limpiarTextBox();
                        MessageBox.Show("Consultorio modificado exitosamente", "ABMConsultorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        limpiarTextBox();
                        MessageBox.Show("Id de Consultorio no existe", "ABMConsultorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
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
            comboBoxHoraInicio.Visible = true;
            comboBoxHoraFin.Visible = true;

            textBoxId.Enabled = true;
            textBoxDireccion.Enabled = false;
            comboBoxHoraInicio.Enabled = false;
            comboBoxHoraFin.Enabled = false;
            try
            {
                if (textBoxId.Text != String.Empty)
                {
                    if (ws.consultorioExiste(Int64.Parse(textBoxId.Text)))
                    {
                         ws.eliminarConsultorio(Int64.Parse(textBoxId.Text));
                         limpiarTextBox();
                         MessageBox.Show("Consultorio eliminado exitosamente", "ABMConsultorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        limpiarTextBox();
                        MessageBox.Show("Consultorio no existe", "ABMConsultorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }

                  
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
            comboBoxHoraInicio.Visible = true;
            comboBoxHoraFin.Visible = true;
            try
            {
                Fachada f = new Fachada();
                if (textBoxDireccion.Text != String.Empty)
                {
                    voc = f.darConsultorio(Int64.Parse(textBoxId.Text));
                    textBoxDireccion.Text = voc.Direccion;
                    comboBoxHoraFin.Text = voc.HoraFin.ToString();
                    comboBoxHoraInicio.Text = voc.HoraInicio.ToString();
                }
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
            comboBoxHoraInicio.Text = "";
            comboBoxHoraFin.Text = "";
        }

        private void comboBoxHoraInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxHoraFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
