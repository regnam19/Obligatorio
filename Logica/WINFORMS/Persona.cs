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
        VOUsuario vou;

        private void button1_Click(object sender, EventArgs e)
        {
            vope = f.darPersona(Int64.Parse(textBoxCedula.Text));
            vopro = f.darProfesional(Int64.Parse(textBoxCedula.Text));
           // vou = f.darUsuario(Int64.Parse(textBoxCedula.Text));
            textBoxNombre.Text = vope.Nombre;
            textBoxApellido.Text = vope.Apellido;
            textBoxCelular.Text = vope.Celular;
            textBoxDireccion.Text = vope.Direccion;
            textBoxEspecialidad.Text = vopro.Especialidad;
            textBoxUsuarioProfesional.Text = vou.Usuario;
            textBoxContraseñaProfesional.Text = vou.Contraseña;
            
            
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

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (checkBoxSi.Equals("Si"))
                f.modificarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, textBoxDireccion.Text, true);
            else
                f.modificarPersona(Int64.Parse(textBoxCedula.Text), textBoxNombre.Text, textBoxApellido.Text, textBoxCelular.Text, textBoxDireccion.Text, false);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           // f.eliminarPersona(Int64.Parse(textBoxCedula.Text));
        }

        private void Persona_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxPaciente_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPaciente.Checked) {
                textBoxContactoEmergencia.Enabled = true;
                textBoxEmergenciaMovil.Enabled = true;
                textBoxMutualista.Enabled = true;
                textBoxUsuarioPaciente.Enabled = true;
                textBoxContraseñaPaciente.Enabled = true;
            }
            else
            {
                textBoxContactoEmergencia.Enabled = false;
                textBoxEmergenciaMovil.Enabled = false;
                textBoxMutualista.Enabled = false;
                textBoxUsuarioPaciente.Enabled = false;
                textBoxContraseñaPaciente.Enabled = false;
            }
        }

        private void checkBoxProfesional_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProfesional.Checked)
            {
                textBoxEspecialidad.Enabled = true;
                textBoxUsuarioProfesional.Enabled = true;
                textBoxContraseñaProfesional.Enabled = true;
            }
            else
            {
                textBoxEspecialidad.Enabled = false;
                textBoxUsuarioProfesional.Enabled = false;
                textBoxContraseñaProfesional.Enabled = false;
            }
        }

        private void checkBoxUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdmin.Checked)
            {
                textBoxUsuarioAdmin.Enabled = true;
                textBoxContraseñaAdmin.Enabled = true;
            }
            else
            {
                textBoxUsuarioAdmin.Enabled = false;
                textBoxContraseñaAdmin.Enabled = false;
            }
        }
    }
}
