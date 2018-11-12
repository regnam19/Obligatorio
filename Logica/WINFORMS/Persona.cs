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
    public partial class Persona : Form
    {
        public Persona()
        {
            InitializeComponent();
        }
        Fachada f = new Fachada();
        VOPersona vope;

        private void button1_Click(object sender, EventArgs e)
        {
            vope = f.darPersona(Int64.Parse(textBoxCedula.Text));
            textBoxNombre.Text = vope.Nombre;
           
            textBoxApellido.Text = vope.Apellido;
            textBoxCelular.Text = vope.Celular;
            textBoxDireccion.Text = vope.Direccion;
            //dateTimePickerFechaNacimiento = vope.FechaNac;
            if (vope.Habilitado)
            {
                checkBoxNo.Checked = false;
                checkBoxSi.Checked = true;
            }

            else
            {
                checkBoxNo.Checked = true;
                checkBoxSi.Checked = false;
            }
            
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (checkBoxSi.Equals("Si"))
                f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, textBoxDireccion.Text, true);
            else
                f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, textBoxDireccion.Text, false);
        }
    }
}
