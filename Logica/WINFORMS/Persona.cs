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
        VOProfesional vopro;
        VOPaciente vopa;


        private void button1_Click(object sender, EventArgs e)
        {
            vope = f.darPersona(Int64.Parse(textBoxCedula.Text));
            vopro = f.darProfesional(Int64.Parse(textBoxCedula.Text));
            vopa = f.darPaciente(Int64.Parse(textBoxCedula.Text));
            textBoxNombre.Text = vope.Nombre;
            textBoxApellido.Text = vope.Apellido;
            textBoxCelular.Text = vope.Celular;
            textBoxDireccion.Text = vope.Direccion;
            //textBoxEspecialidad.Text = vopro.Especialidad;
            /*textBoxContactoEmergencia.Text = vopa.ContactoEmergencia;
            textBoxCelularEmergencia.Text = vopa.CelularEmergencia;
            textBoxMutualista.Text = vopa.Mutualista;
            textBoxEmergenciaMovil.Text = vopa.EmergenciaMovil;
            //dateTimePickerFechaNacimiento = vope.FechaNac;*/
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
            if (checkBoxSi.Checked)
            {
                if (radioButtonPaciente.Checked)
                {
                    f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, "2018-9-1", textBoxDireccion.Text, textBoxContraseñaPaciente.Text, true);
                    f.ingresarPaciente(Int64.Parse(textBoxCedula.Text), textBoxContactoEmergencia.Text, textBoxCelularEmergencia.Text, textBoxEmergenciaMovil.Text, textBoxMutualista.Text);
                }
                else if (radioButton1.Checked)
                {
                    f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, "2018-9-1", textBoxDireccion.Text, textBoxContraseñaProfesional.Text, true);
                    f.ingresarProfesional(Int64.Parse(textBoxCedula.Text), textBoxEspecialidad.Text);
                }
                else if (radioButton2.Checked)
                {
                    f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, "2018-9-1", textBoxDireccion.Text, textBoxContraseñaAdmin.Text, true);
                    f.ingresarAdmin(Int64.Parse(textBoxCedula.Text));
                }
            }else
            {
                if (radioButtonPaciente.Checked)
                {
                    f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, "2018-9-1", textBoxDireccion.Text, textBoxContraseñaPaciente.Text, false);
                    f.ingresarPaciente(Int64.Parse(textBoxCedula.Text), textBoxContactoEmergencia.Text, textBoxCelularEmergencia.Text, textBoxEmergenciaMovil.Text, textBoxMutualista.Text);
                }
                else if (radioButton1.Checked)
                {
                    f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, "2018-9-1", textBoxDireccion.Text, textBoxContraseñaProfesional.Text, false);
                    f.ingresarProfesional(Int64.Parse(textBoxCedula.Text), textBoxEspecialidad.Text);
                }
                else if (radioButton2.Checked)
                {
                    f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, "2018-9-1", textBoxDireccion.Text, textBoxContraseñaAdmin.Text, false);
                    f.ingresarAdmin(Int64.Parse(textBoxCedula.Text));

                }

            }

          
           
           
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (checkBoxSi.Checked)
            {
                if (radioButtonPaciente.Checked)
                {
                    f.modificarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, textBoxDireccion.Text, true);
                    f.modificarPaciente(Int64.Parse(textBoxCedula.Text), textBoxContactoEmergencia.Text, textBoxCelularEmergencia.Text, textBoxEmergenciaMovil.Text, textBoxMutualista.Text);
                }
                else if (radioButton1.Checked)
                {
                    f.modificarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, textBoxDireccion.Text, true);
                    f.modificarProfesional(Int64.Parse(textBoxCedula.Text), textBoxEspecialidad.Text);
                }
                else if (radioButton2.Checked)
                {
                    f.modificarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, textBoxDireccion.Text, true);
                    
                }
            }
            else
            {
                if (radioButtonPaciente.Checked)
                {
                   // f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, textBoxDireccion.Text, textBoxContraseñaPaciente.Text, false);
                    f.ingresarPaciente(Int64.Parse(textBoxCedula.Text), textBoxContactoEmergencia.Text, textBoxCelularEmergencia.Text, textBoxEmergenciaMovil.Text, textBoxMutualista.Text);
                }
                else if (radioButton1.Checked)
                {
                    //f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, textBoxDireccion.Text, textBoxContraseñaProfesional.Text, false);
                    f.ingresarProfesional(Int64.Parse(textBoxCedula.Text), textBoxEspecialidad.Text);
                }
                else if (radioButton2.Checked)
                {
                   // f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, textBoxDireccion.Text, textBoxContraseñaAdmin.Text, false);
                    f.ingresarAdmin(Int64.Parse(textBoxCedula.Text));
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           // f.eliminarPersona(Int64.Parse(textBoxCedula.Text));
        }

        private void Persona_Load(object sender, EventArgs e)
        {

        }
     

        private void radioButtonPaciente_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButtonPaciente.Checked)
            {
                textBoxCelularEmergencia.Enabled = true;
                textBoxContactoEmergencia.Enabled = true;
                textBoxEmergenciaMovil.Enabled = true;
                textBoxMutualista.Enabled = true;
                textBoxContraseñaPaciente.Enabled = true;

            }
            else
            {
                textBoxCelularEmergencia.Enabled = false;
                textBoxContactoEmergencia.Enabled = false;
                textBoxEmergenciaMovil.Enabled = false;
                textBoxMutualista.Enabled = false;
                textBoxContraseñaPaciente.Enabled = false;

            }

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBoxEspecialidad.Enabled = true;
                textBoxContraseñaProfesional.Enabled = true;
            }
            else
            {
                textBoxEspecialidad.Enabled = false;
                textBoxContraseñaProfesional.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBoxContraseñaAdmin.Enabled = true;
            }
            else
            {
                textBoxContraseñaAdmin.Enabled = false;
            }
        }
    }
}
