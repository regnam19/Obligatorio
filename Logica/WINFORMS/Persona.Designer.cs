namespace Logica.WINFORMS
{
    partial class Persona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCedula = new System.Windows.Forms.Label();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxCelular = new System.Windows.Forms.TextBox();
            this.labelCelular = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.checkBoxSi = new System.Windows.Forms.CheckBox();
            this.checkBoxNo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMutualista = new System.Windows.Forms.TextBox();
            this.textBoxEmergenciaMovil = new System.Windows.Forms.TextBox();
            this.textBoxContactoEmergencia = new System.Windows.Forms.TextBox();
            this.textBoxEspecialidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCelularEmergencia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxContraseñaProfesional = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxContraseñaPaciente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.radioButtonPaciente = new System.Windows.Forms.RadioButton();
            this.textBoxContraseñaAdmin = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.errorProviderPersona = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(185, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABM Persona";
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelCedula.Location = new System.Drawing.Point(81, 84);
            this.labelCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(145, 22);
            this.labelCedula.TabIndex = 1;
            this.labelCedula.Text = "Cedula Identidad";
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(241, 84);
            this.textBoxCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(129, 22);
            this.textBoxCedula.TabIndex = 2;
            this.textBoxCedula.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCedula_Validating);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonBuscar.Location = new System.Drawing.Point(628, 31);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(100, 28);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCelular
            // 
            this.textBoxCelular.Location = new System.Drawing.Point(705, 130);
            this.textBoxCelular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCelular.Name = "textBoxCelular";
            this.textBoxCelular.Size = new System.Drawing.Size(129, 22);
            this.textBoxCelular.TabIndex = 5;
            this.textBoxCelular.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCelular_Validating);
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelCelular.Location = new System.Drawing.Point(591, 130);
            this.labelCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(67, 22);
            this.labelCelular.TabIndex = 4;
            this.labelCelular.Text = "Celular";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(241, 130);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(129, 22);
            this.textBoxApellido.TabIndex = 7;
            this.textBoxApellido.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxApellido_Validating);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelApellido.Location = new System.Drawing.Point(81, 130);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(74, 22);
            this.labelApellido.TabIndex = 6;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(705, 84);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(129, 22);
            this.textBoxNombre.TabIndex = 9;
            this.textBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombre_Validating);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelNombre.Location = new System.Drawing.Point(591, 84);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(73, 22);
            this.labelNombre.TabIndex = 8;
            this.labelNombre.Text = "Nombre";
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelFechaNacimiento.Location = new System.Drawing.Point(81, 183);
            this.labelFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(154, 22);
            this.labelFechaNacimiento.TabIndex = 14;
            this.labelFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(705, 183);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(129, 22);
            this.textBoxDireccion.TabIndex = 13;
            this.textBoxDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDireccion_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(591, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Direccion";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(631, 586);
            this.buttonIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(229, 48);
            this.buttonIngresar.TabIndex = 16;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(88, 586);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(229, 48);
            this.buttonModificar.TabIndex = 17;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(365, 586);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(229, 48);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(241, 183);
            this.dateTimePickerFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(249, 23);
            this.dateTimePickerFechaNacimiento.TabIndex = 19;
            this.dateTimePickerFechaNacimiento.ValueChanged += new System.EventHandler(this.dateTimePickerFechaNacimiento_ValueChanged);
            // 
            // checkBoxSi
            // 
            this.checkBoxSi.AutoSize = true;
            this.checkBoxSi.Location = new System.Drawing.Point(192, 215);
            this.checkBoxSi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxSi.Name = "checkBoxSi";
            this.checkBoxSi.Size = new System.Drawing.Size(42, 21);
            this.checkBoxSi.TabIndex = 20;
            this.checkBoxSi.Text = "Si";
            this.checkBoxSi.UseVisualStyleBackColor = true;
            // 
            // checkBoxNo
            // 
            this.checkBoxNo.AutoSize = true;
            this.checkBoxNo.Location = new System.Drawing.Point(192, 244);
            this.checkBoxNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxNo.Name = "checkBoxNo";
            this.checkBoxNo.Size = new System.Drawing.Size(48, 21);
            this.checkBoxNo.TabIndex = 21;
            this.checkBoxNo.Text = "No";
            this.checkBoxNo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(81, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Habilitado";
            // 
            // textBoxMutualista
            // 
            this.textBoxMutualista.Enabled = false;
            this.textBoxMutualista.Location = new System.Drawing.Point(208, 487);
            this.textBoxMutualista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMutualista.Name = "textBoxMutualista";
            this.textBoxMutualista.Size = new System.Drawing.Size(132, 22);
            this.textBoxMutualista.TabIndex = 66;
            // 
            // textBoxEmergenciaMovil
            // 
            this.textBoxEmergenciaMovil.Enabled = false;
            this.textBoxEmergenciaMovil.Location = new System.Drawing.Point(208, 443);
            this.textBoxEmergenciaMovil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmergenciaMovil.Name = "textBoxEmergenciaMovil";
            this.textBoxEmergenciaMovil.Size = new System.Drawing.Size(132, 22);
            this.textBoxEmergenciaMovil.TabIndex = 65;
            // 
            // textBoxContactoEmergencia
            // 
            this.textBoxContactoEmergencia.Enabled = false;
            this.textBoxContactoEmergencia.Location = new System.Drawing.Point(208, 359);
            this.textBoxContactoEmergencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxContactoEmergencia.Name = "textBoxContactoEmergencia";
            this.textBoxContactoEmergencia.Size = new System.Drawing.Size(132, 22);
            this.textBoxContactoEmergencia.TabIndex = 64;
            // 
            // textBoxEspecialidad
            // 
            this.textBoxEspecialidad.Enabled = false;
            this.textBoxEspecialidad.Location = new System.Drawing.Point(495, 359);
            this.textBoxEspecialidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEspecialidad.Name = "textBoxEspecialidad";
            this.textBoxEspecialidad.Size = new System.Drawing.Size(132, 22);
            this.textBoxEspecialidad.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.Location = new System.Drawing.Point(373, 359);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 22);
            this.label10.TabIndex = 56;
            this.label10.Text = "Especialidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(15, 491);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 55;
            this.label7.Text = "Mutualista";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(15, 359);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 22);
            this.label8.TabIndex = 54;
            this.label8.Text = "Contacto Emergencia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(15, 443);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 22);
            this.label9.TabIndex = 53;
            this.label9.Text = "Emergencia Movil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(677, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 51;
            this.label6.Text = "Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(84, 293);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 48;
            this.label5.Text = "Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(385, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 47;
            this.label4.Text = "Profesional";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label11.Location = new System.Drawing.Point(15, 402);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 22);
            this.label11.TabIndex = 75;
            this.label11.Text = "Celular Emergencia";
            // 
            // textBoxCelularEmergencia
            // 
            this.textBoxCelularEmergencia.Enabled = false;
            this.textBoxCelularEmergencia.Location = new System.Drawing.Point(208, 402);
            this.textBoxCelularEmergencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCelularEmergencia.Name = "textBoxCelularEmergencia";
            this.textBoxCelularEmergencia.Size = new System.Drawing.Size(132, 22);
            this.textBoxCelularEmergencia.TabIndex = 76;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.Location = new System.Drawing.Point(652, 359);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 22);
            this.label12.TabIndex = 77;
            this.label12.Text = "Contraseña";
            // 
            // textBoxContraseñaProfesional
            // 
            this.textBoxContraseñaProfesional.Enabled = false;
            this.textBoxContraseñaProfesional.Location = new System.Drawing.Point(495, 399);
            this.textBoxContraseñaProfesional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxContraseñaProfesional.Name = "textBoxContraseñaProfesional";
            this.textBoxContraseñaProfesional.Size = new System.Drawing.Size(132, 22);
            this.textBoxContraseñaProfesional.TabIndex = 80;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.Location = new System.Drawing.Point(373, 399);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 22);
            this.label13.TabIndex = 79;
            this.label13.Text = "Contraseña";
            // 
            // textBoxContraseñaPaciente
            // 
            this.textBoxContraseñaPaciente.Enabled = false;
            this.textBoxContraseñaPaciente.Location = new System.Drawing.Point(208, 533);
            this.textBoxContraseñaPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxContraseñaPaciente.Name = "textBoxContraseñaPaciente";
            this.textBoxContraseñaPaciente.Size = new System.Drawing.Size(132, 22);
            this.textBoxContraseñaPaciente.TabIndex = 82;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label14.Location = new System.Drawing.Point(16, 533);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 22);
            this.label14.TabIndex = 81;
            this.label14.Text = "Contraseña";
            // 
            // radioButtonPaciente
            // 
            this.radioButtonPaciente.AutoSize = true;
            this.radioButtonPaciente.Location = new System.Drawing.Point(192, 297);
            this.radioButtonPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonPaciente.Name = "radioButtonPaciente";
            this.radioButtonPaciente.Size = new System.Drawing.Size(17, 16);
            this.radioButtonPaciente.TabIndex = 83;
            this.radioButtonPaciente.TabStop = true;
            this.radioButtonPaciente.UseVisualStyleBackColor = true;
            this.radioButtonPaciente.CheckedChanged += new System.EventHandler(this.radioButtonPaciente_CheckedChanged_1);
            // 
            // textBoxContraseñaAdmin
            // 
            this.textBoxContraseñaAdmin.Enabled = false;
            this.textBoxContraseñaAdmin.Location = new System.Drawing.Point(768, 359);
            this.textBoxContraseñaAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxContraseñaAdmin.Name = "textBoxContraseñaAdmin";
            this.textBoxContraseñaAdmin.Size = new System.Drawing.Size(132, 22);
            this.textBoxContraseñaAdmin.TabIndex = 86;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(515, 295);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 87;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(768, 297);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 88;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // errorProviderPersona
            // 
            this.errorProviderPersona.ContainerControl = this;
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 677);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBoxContraseñaAdmin);
            this.Controls.Add(this.radioButtonPaciente);
            this.Controls.Add(this.textBoxContraseñaPaciente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxContraseñaProfesional);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxCelularEmergencia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxMutualista);
            this.Controls.Add(this.textBoxEmergenciaMovil);
            this.Controls.Add(this.textBoxContactoEmergencia);
            this.Controls.Add(this.textBoxEspecialidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxNo);
            this.Controls.Add(this.checkBoxSi);
            this.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.textBoxCelular);
            this.Controls.Add(this.labelCelular);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxCedula);
            this.Controls.Add(this.labelCedula);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Persona";
            this.Text = "Persona";
            this.Load += new System.EventHandler(this.Persona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxCelular;
        private System.Windows.Forms.Label labelCelular;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.CheckBox checkBoxSi;
        private System.Windows.Forms.CheckBox checkBoxNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMutualista;
        private System.Windows.Forms.TextBox textBoxEmergenciaMovil;
        private System.Windows.Forms.TextBox textBoxContactoEmergencia;
        private System.Windows.Forms.TextBox textBoxEspecialidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCelularEmergencia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxContraseñaProfesional;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxContraseñaPaciente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radioButtonPaciente;
        private System.Windows.Forms.TextBox textBoxContraseñaAdmin;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ErrorProvider errorProviderPersona;
    }
}