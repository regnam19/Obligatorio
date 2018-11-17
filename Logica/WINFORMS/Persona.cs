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
        VOAdmin voad;


        
        private void button1_Click(object sender, EventArgs e)
        {
           


            if (textBoxCedula.Text != String.Empty)
            {
                vope = f.darPersona(Int64.Parse(textBoxCedula.Text));
                vopro = f.darProfesional(Int64.Parse(textBoxCedula.Text));
                vopa = f.darPaciente(Int64.Parse(textBoxCedula.Text));
                voad = f.darAdmin(Int64.Parse(textBoxCedula.Text));
                if (vope != null && (vopro != null))
                {
                    textBoxNombre.Text = vope.Nombre;
                    textBoxApellido.Text = vope.Apellido;
                    textBoxCelular.Text = vope.Celular;
                    textBoxDireccion.Text = vope.Direccion;
                    if (vope.Habilitado)
                        checkBoxSi.Checked = true;
                    else
                        checkBoxNo.Checked = true;
                    textBoxEspecialidad.Text = vopro.Especialidad;
                }
                else if (vope != null && (vopa != null))
                {
                    textBoxNombre.Text = vope.Nombre;
                    textBoxApellido.Text = vope.Apellido;
                    textBoxCelular.Text = vope.Celular;
                    textBoxDireccion.Text = vope.Direccion;
                    if (vope.Habilitado)
                        checkBoxSi.Checked = true;
                    else
                        checkBoxNo.Checked = true;
                    textBoxContactoEmergencia.Text = vopa.ContactoEmergencia;
                    textBoxCelularEmergencia.Text = vopa.CelularEmergencia;
                    textBoxMutualista.Text = vopa.Mutualista;
                    textBoxEmergenciaMovil.Text = vopa.EmergenciaMovil;
                }
                else
                {
                    textBoxNombre.Text = vope.Nombre;
                    textBoxApellido.Text = vope.Apellido;
                    textBoxCelular.Text = vope.Celular;
                    textBoxDireccion.Text = vope.Direccion;
                    if (vope.Habilitado)
                        checkBoxSi.Checked = true;
                    else
                        checkBoxNo.Checked = true;
                }
            }
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxSi.Checked)
                {
                    if (radioButtonPaciente.Checked)
                    {
                        f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, "2018-9-1", textBoxDireccion.Text, textBoxContraseñaPaciente.Text, true);
                        f.ingresarPaciente(Int64.Parse(textBoxCedula.Text), textBoxContactoEmergencia.Text, textBoxCelularEmergencia.Text, textBoxEmergenciaMovil.Text, textBoxMutualista.Text);
                        textBoxCedula.Text = "";
                        textBoxCelular.Text = "";
                        textBoxNombre.Text = "";
                        textBoxApellido.Text = "";
                        textBoxCelular.Text = "";
                        textBoxDireccion.Text = "";
                        textBoxContactoEmergencia.Text = "";
                        textBoxCelularEmergencia.Text = "";
                        textBoxMutualista.Text = "";
                        textBoxEmergenciaMovil.Text = "";
                        textBoxContraseñaAdmin.Text = "";
                        textBoxContraseñaPaciente.Text = "";
                        textBoxContraseñaAdmin.Text = "";
                        MessageBox.Show("Paciente ingresado correctamente", "My Application",MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                    else if (radioButton1.Checked)
                    {
                        f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, "2018-9-1", textBoxDireccion.Text, textBoxContraseñaProfesional.Text, true);
                        f.ingresarProfesional(Int64.Parse(textBoxCedula.Text), textBoxEspecialidad.Text);
                        textBoxCedula.Text = "";
                        textBoxCelular.Text = "";
                        textBoxNombre.Text = "";
                        textBoxApellido.Text = "";
                        textBoxCelular.Text = "";
                        textBoxDireccion.Text = "";
                        textBoxContactoEmergencia.Text = "";
                        textBoxCelularEmergencia.Text = "";
                        textBoxMutualista.Text = "";
                        textBoxEmergenciaMovil.Text = "";
                        textBoxContraseñaAdmin.Text = "";
                        textBoxContraseñaPaciente.Text = "";
                        textBoxContraseñaAdmin.Text = "";
                        MessageBox.Show("Profesional ingresado correctamente", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                    else if (radioButton2.Checked)
                    {
                        f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, "2018-9-1", textBoxDireccion.Text, textBoxContraseñaAdmin.Text, true);
                        f.ingresarAdmin(Int64.Parse(textBoxCedula.Text));
                        textBoxCedula.Text = "";
                        textBoxCelular.Text = "";
                        textBoxNombre.Text = "";
                        textBoxApellido.Text = "";
                        textBoxCelular.Text = "";
                        textBoxDireccion.Text = "";
                        textBoxContactoEmergencia.Text = "";
                        textBoxCelularEmergencia.Text = "";
                        textBoxMutualista.Text = "";
                        textBoxEmergenciaMovil.Text = "";
                        textBoxContraseñaAdmin.Text = "";
                        textBoxContraseñaPaciente.Text = "";
                        textBoxContraseñaAdmin.Text = "";
                        MessageBox.Show("Admin ingresado correctamente", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    if (radioButtonPaciente.Checked)
                    {
                        f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, "2018-9-1", textBoxDireccion.Text, textBoxContraseñaPaciente.Text, false);
                        f.ingresarPaciente(Int64.Parse(textBoxCedula.Text), textBoxContactoEmergencia.Text, textBoxCelularEmergencia.Text, textBoxEmergenciaMovil.Text, textBoxMutualista.Text);
                        textBoxCedula.Text = "";
                        textBoxCelular.Text = "";
                        textBoxNombre.Text = "";
                        textBoxApellido.Text = "";
                        textBoxCelular.Text = "";
                        textBoxDireccion.Text = "";
                        textBoxContactoEmergencia.Text = "";
                        textBoxCelularEmergencia.Text = "";
                        textBoxMutualista.Text = "";
                        textBoxEmergenciaMovil.Text = "";
                        textBoxContraseñaAdmin.Text = "";
                        textBoxContraseñaPaciente.Text = "";
                        textBoxContraseñaAdmin.Text = "";
                        MessageBox.Show("Paciente ingresado correctamente", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                    else if (radioButton1.Checked)
                    {
                        f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, "2018-9-1", textBoxDireccion.Text, textBoxContraseñaProfesional.Text, false);
                        f.ingresarProfesional(Int64.Parse(textBoxCedula.Text), textBoxEspecialidad.Text);
                        textBoxCedula.Text = "";
                        textBoxCelular.Text = "";
                        textBoxNombre.Text = "";
                        textBoxApellido.Text = "";
                        textBoxCelular.Text = "";
                        textBoxDireccion.Text = "";
                        textBoxContactoEmergencia.Text = "";
                        textBoxCelularEmergencia.Text = "";
                        textBoxMutualista.Text = "";
                        textBoxEmergenciaMovil.Text = "";
                        textBoxContraseñaAdmin.Text = "";
                        textBoxContraseñaPaciente.Text = "";
                        textBoxContraseñaAdmin.Text = "";
                        MessageBox.Show("Profesional ingresado correctamente", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                    else if (radioButton2.Checked)
                    {
                        f.ingresarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, "2018-9-1", textBoxDireccion.Text, textBoxContraseñaAdmin.Text, false);
                        f.ingresarAdmin(Int64.Parse(textBoxCedula.Text));
                        textBoxCedula.Text = "";
                        textBoxCelular.Text = "";
                        textBoxNombre.Text = "";
                        textBoxApellido.Text = "";
                        textBoxCelular.Text = "";
                        textBoxDireccion.Text = "";
                        textBoxContactoEmergencia.Text = "";
                        textBoxCelularEmergencia.Text = "";
                        textBoxMutualista.Text = "";
                        textBoxEmergenciaMovil.Text = "";
                        textBoxContraseñaAdmin.Text = "";
                        textBoxContraseñaPaciente.Text = "";
                        textBoxContraseñaAdmin.Text = "";
                        MessageBox.Show("Admin ingresado correctamente", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                    }

                }
            }
            catch
            {
                MessageBox.Show("The calculations are complete", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
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
                    textBoxCedula.Text = "";
                    textBoxCelular.Text = "";
                    textBoxNombre.Text = "";
                    textBoxApellido.Text = "";
                    textBoxCelular.Text = "";
                    textBoxDireccion.Text = "";
                    textBoxContactoEmergencia.Text = "";
                    textBoxCelularEmergencia.Text = "";
                    textBoxMutualista.Text = "";
                    textBoxEmergenciaMovil.Text = "";
                    textBoxContraseñaAdmin.Text = "";
                    textBoxContraseñaPaciente.Text = "";
                    textBoxContraseñaAdmin.Text = "";
                    MessageBox.Show("Paciente modificado correctamente", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else if (radioButton1.Checked)
                {
                    f.modificarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, textBoxDireccion.Text, true);
                    f.modificarProfesional(Int64.Parse(textBoxCedula.Text), textBoxEspecialidad.Text);
                    textBoxCedula.Text = "";
                    textBoxCelular.Text = "";
                    textBoxNombre.Text = "";
                    textBoxApellido.Text = "";
                    textBoxCelular.Text = "";
                    textBoxDireccion.Text = "";
                    textBoxContactoEmergencia.Text = "";
                    textBoxCelularEmergencia.Text = "";
                    textBoxMutualista.Text = "";
                    textBoxEmergenciaMovil.Text = "";
                    textBoxContraseñaAdmin.Text = "";
                    textBoxContraseñaPaciente.Text = "";
                    textBoxContraseñaAdmin.Text = "";
                    MessageBox.Show("Profesional modificado correctamente", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else if (radioButton2.Checked)
                {
                    f.modificarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, textBoxDireccion.Text, true);
                    textBoxCedula.Text = "";
                    textBoxCelular.Text = "";
                    textBoxNombre.Text = "";
                    textBoxApellido.Text = "";
                    textBoxCelular.Text = "";
                    textBoxDireccion.Text = "";
                    textBoxContactoEmergencia.Text = "";
                    textBoxCelularEmergencia.Text = "";
                    textBoxMutualista.Text = "";
                    textBoxEmergenciaMovil.Text = "";
                    textBoxContraseñaAdmin.Text = "";
                    textBoxContraseñaPaciente.Text = "";
                    textBoxContraseñaAdmin.Text = "";
                    MessageBox.Show("Admin modificado correctamente", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                if (radioButtonPaciente.Checked)
                {
                    f.modificarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, textBoxDireccion.Text, false);
                    f.modificarPaciente(Int64.Parse(textBoxCedula.Text), textBoxContactoEmergencia.Text, textBoxCelularEmergencia.Text, textBoxEmergenciaMovil.Text, textBoxMutualista.Text);
                    textBoxCedula.Text = "";
                    textBoxCelular.Text = "";
                    textBoxNombre.Text = "";
                    textBoxApellido.Text = "";
                    textBoxCelular.Text = "";
                    textBoxDireccion.Text = "";
                    textBoxContactoEmergencia.Text = "";
                    textBoxCelularEmergencia.Text = "";
                    textBoxMutualista.Text = "";
                    textBoxEmergenciaMovil.Text = "";
                    textBoxContraseñaAdmin.Text = "";
                    textBoxContraseñaPaciente.Text = "";
                    textBoxContraseñaAdmin.Text = "";
                    MessageBox.Show("Paciente modificado correctamente", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else if (radioButton1.Checked)
                {
                    f.modificarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, textBoxDireccion.Text, false);
                    f.modificarProfesional(Int64.Parse(textBoxCedula.Text), textBoxEspecialidad.Text);
                    textBoxCedula.Text = "";
                    textBoxCelular.Text = "";
                    textBoxNombre.Text = "";
                    textBoxApellido.Text = "";
                    textBoxCelular.Text = "";
                    textBoxDireccion.Text = "";
                    textBoxContactoEmergencia.Text = "";
                    textBoxCelularEmergencia.Text = "";
                    textBoxMutualista.Text = "";
                    textBoxEmergenciaMovil.Text = "";
                    textBoxContraseñaAdmin.Text = "";
                    textBoxContraseñaPaciente.Text = "";
                    textBoxContraseñaAdmin.Text = "";
                    MessageBox.Show("Profesional modificado correctamente", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else if (radioButton2.Checked)
                {
                    f.modificarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, textBoxDireccion.Text, false);
                    textBoxCedula.Text = "";
                    textBoxCelular.Text = "";
                    textBoxNombre.Text = "";
                    textBoxApellido.Text = "";
                    textBoxCelular.Text = "";
                    textBoxDireccion.Text = "";
                    textBoxContactoEmergencia.Text = "";
                    textBoxCelularEmergencia.Text = "";
                    textBoxMutualista.Text = "";
                    textBoxEmergenciaMovil.Text = "";
                    textBoxContraseñaAdmin.Text = "";
                    textBoxContraseñaPaciente.Text = "";
                    textBoxContraseñaAdmin.Text = "";
                    MessageBox.Show("Admin modificado correctamente", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           f.eliminarPersona(Int64.Parse(textBoxCedula.Text));
            textBoxCedula.Text = "";
            textBoxCelular.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxCelular.Text = "";
            textBoxDireccion.Text = "";
            textBoxContactoEmergencia.Text = "";
            textBoxCelularEmergencia.Text = "";
            textBoxMutualista.Text = "";
            textBoxEmergenciaMovil.Text = "";
            textBoxContraseñaAdmin.Text = "";
            textBoxContraseñaPaciente.Text = "";
            textBoxContraseñaAdmin.Text = "";
            MessageBox.Show("Persona eliminada correctamente", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
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
                textBoxContactoEmergencia.Text = "";
                textBoxCelularEmergencia.Text = "";
                textBoxMutualista.Text = "";
                textBoxEmergenciaMovil.Text = "";
                textBoxContraseñaAdmin.Text = "";
                textBoxContraseñaPaciente.Text = "";
                textBoxContraseñaAdmin.Text = "";
                textBoxEspecialidad.Enabled = true;
                textBoxContraseñaProfesional.Enabled = true;
            
            }
            else
            {
                textBoxEspecialidad.Text = "";
                textBoxContraseñaProfesional.Text = "";
                textBoxEspecialidad.Enabled = false;
                textBoxContraseñaProfesional.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBoxContactoEmergencia.Text = "";
                textBoxCelularEmergencia.Text = "";
                textBoxMutualista.Text = "";
                textBoxEmergenciaMovil.Text = "";
                textBoxContraseñaAdmin.Text = "";
                textBoxContraseñaPaciente.Text = "";
                textBoxContraseñaAdmin.Enabled = true;
            }
            else
            {

                textBoxContraseñaAdmin.Text = "";
                textBoxContraseñaAdmin.Enabled = false;
            }
        }

        private void textBoxCedula_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCedula.Text))
            {
                errorProviderPersona.SetError(textBoxCedula, "Debe ingresar una cédula");
            }
            else
            {
                errorProviderPersona.SetError(textBoxCedula, "");
            }
        }

        private void textBoxNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                errorProviderPersona.SetError(textBoxNombre, "Debe ingresar un nombre");
            }
            else
            {
                errorProviderPersona.SetError(textBoxNombre, "");
            }

        }

        private void textBoxApellido_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxApellido.Text))
            {
                errorProviderPersona.SetError(textBoxApellido, "Debe ingresar un apellido");
            }
            else
            {
                errorProviderPersona.SetError(textBoxApellido, "");
            }

        }

        private void textBoxCelular_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxCelular.Text))
            {
                errorProviderPersona.SetError(textBoxCelular, "Debe ingresar un celular");
            }
            else
            {
                errorProviderPersona.SetError(textBoxCelular, "");
            }

        }

        /*private void dateTimePickerFechaNacimiento_Validating(object sender)
        {

            if (string.IsNullOrEmpty(dateTimePickerFechaNacimiento.Text))
            {
                errorProviderPersona.SetError(dateTimePickerFechaNacimiento, "Debe ingresar una cédula");
            }
            else
            {
                errorProviderPersona.SetError(dateTimePickerFechaNacimiento, "");
            }

        }*/

        private void textBoxDireccion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxDireccion.Text))
            {
                errorProviderPersona.SetError(textBoxDireccion, "Debe ingresar una dirección");
            }
            else
            {
                errorProviderPersona.SetError(textBoxDireccion, "");
            }

        }

       
    }

}
