﻿namespace Logica.WINFORMS
{
    partial class groupBoxTipoPersona
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
            this.TipoPersona = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonSi = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPersona)).BeginInit();
            this.TipoPersona.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABM Persona";
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelCedula.ForeColor = System.Drawing.Color.White;
            this.labelCedula.Location = new System.Drawing.Point(61, 68);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(114, 17);
            this.labelCedula.TabIndex = 1;
            this.labelCedula.Text = "Cedula Identidad";
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(181, 68);
            this.textBoxCedula.MaxLength = 8;
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(98, 20);
            this.textBoxCedula.TabIndex = 2;
            this.textBoxCedula.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCedula_Validating);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.buttonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(186)))), ((int)(((byte)(20)))));
            this.buttonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Location = new System.Drawing.Point(471, 25);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCelular
            // 
            this.textBoxCelular.Location = new System.Drawing.Point(529, 106);
            this.textBoxCelular.MaxLength = 9;
            this.textBoxCelular.Name = "textBoxCelular";
            this.textBoxCelular.Size = new System.Drawing.Size(98, 20);
            this.textBoxCelular.TabIndex = 5;
            this.textBoxCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCelular_KeyPress);
            this.textBoxCelular.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCelular_Validating);
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelCelular.ForeColor = System.Drawing.Color.White;
            this.labelCelular.Location = new System.Drawing.Point(443, 106);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(52, 17);
            this.labelCelular.TabIndex = 4;
            this.labelCelular.Text = "Celular";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(181, 106);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(98, 20);
            this.textBoxApellido.TabIndex = 7;
            this.textBoxApellido.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxApellido_Validating);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelApellido.ForeColor = System.Drawing.Color.White;
            this.labelApellido.Location = new System.Drawing.Point(61, 106);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(58, 17);
            this.labelApellido.TabIndex = 6;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(529, 68);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(98, 20);
            this.textBoxNombre.TabIndex = 9;
            this.textBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombre_Validating);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(443, 68);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 8;
            this.labelNombre.Text = "Nombre";
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(61, 149);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(121, 17);
            this.labelFechaNacimiento.TabIndex = 14;
            this.labelFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(529, 149);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(98, 20);
            this.textBoxDireccion.TabIndex = 13;
            this.textBoxDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDireccion_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(443, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Direccion";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.buttonIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(186)))), ((int)(((byte)(20)))));
            this.buttonIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.buttonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIngresar.ForeColor = System.Drawing.Color.White;
            this.buttonIngresar.Location = new System.Drawing.Point(473, 476);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(172, 39);
            this.buttonIngresar.TabIndex = 16;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.buttonModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(186)))), ((int)(((byte)(20)))));
            this.buttonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.ForeColor = System.Drawing.Color.White;
            this.buttonModificar.Location = new System.Drawing.Point(66, 476);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(172, 39);
            this.buttonModificar.TabIndex = 17;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(274, 476);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(172, 39);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(181, 149);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(188, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 19;
            // 
            // textBoxMutualista
            // 
            this.textBoxMutualista.Enabled = false;
            this.textBoxMutualista.Location = new System.Drawing.Point(156, 396);
            this.textBoxMutualista.Name = "textBoxMutualista";
            this.textBoxMutualista.Size = new System.Drawing.Size(100, 20);
            this.textBoxMutualista.TabIndex = 66;
            // 
            // textBoxEmergenciaMovil
            // 
            this.textBoxEmergenciaMovil.Enabled = false;
            this.textBoxEmergenciaMovil.Location = new System.Drawing.Point(156, 360);
            this.textBoxEmergenciaMovil.Name = "textBoxEmergenciaMovil";
            this.textBoxEmergenciaMovil.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmergenciaMovil.TabIndex = 65;
            // 
            // textBoxContactoEmergencia
            // 
            this.textBoxContactoEmergencia.Enabled = false;
            this.textBoxContactoEmergencia.Location = new System.Drawing.Point(156, 292);
            this.textBoxContactoEmergencia.MaxLength = 9;
            this.textBoxContactoEmergencia.Name = "textBoxContactoEmergencia";
            this.textBoxContactoEmergencia.Size = new System.Drawing.Size(100, 20);
            this.textBoxContactoEmergencia.TabIndex = 64;
            this.textBoxContactoEmergencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxContactoEmergencia_KeyPress);
            // 
            // textBoxEspecialidad
            // 
            this.textBoxEspecialidad.Enabled = false;
            this.textBoxEspecialidad.Location = new System.Drawing.Point(371, 292);
            this.textBoxEspecialidad.Name = "textBoxEspecialidad";
            this.textBoxEspecialidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxEspecialidad.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(280, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "Especialidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "Mutualista";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Contacto Emergencia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 53;
            this.label9.Text = "Emergencia Movil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(488, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(269, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Profesional";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(11, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 17);
            this.label11.TabIndex = 75;
            this.label11.Text = "Celular Emergencia";
            // 
            // textBoxCelularEmergencia
            // 
            this.textBoxCelularEmergencia.Enabled = false;
            this.textBoxCelularEmergencia.Location = new System.Drawing.Point(156, 327);
            this.textBoxCelularEmergencia.Name = "textBoxCelularEmergencia";
            this.textBoxCelularEmergencia.Size = new System.Drawing.Size(100, 20);
            this.textBoxCelularEmergencia.TabIndex = 76;
            this.textBoxCelularEmergencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCelularEmergencia_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(489, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 77;
            this.label12.Text = "Contraseña";
            // 
            // textBoxContraseñaProfesional
            // 
            this.textBoxContraseñaProfesional.Enabled = false;
            this.textBoxContraseñaProfesional.Location = new System.Drawing.Point(371, 324);
            this.textBoxContraseñaProfesional.Name = "textBoxContraseñaProfesional";
            this.textBoxContraseñaProfesional.Size = new System.Drawing.Size(100, 20);
            this.textBoxContraseñaProfesional.TabIndex = 80;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(280, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 17);
            this.label13.TabIndex = 79;
            this.label13.Text = "Contraseña";
            // 
            // textBoxContraseñaPaciente
            // 
            this.textBoxContraseñaPaciente.Enabled = false;
            this.textBoxContraseñaPaciente.Location = new System.Drawing.Point(156, 433);
            this.textBoxContraseñaPaciente.Name = "textBoxContraseñaPaciente";
            this.textBoxContraseñaPaciente.Size = new System.Drawing.Size(100, 20);
            this.textBoxContraseñaPaciente.TabIndex = 82;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 433);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 17);
            this.label14.TabIndex = 81;
            this.label14.Text = "Contraseña";
            // 
            // radioButtonPaciente
            // 
            this.radioButtonPaciente.AutoSize = true;
            this.radioButtonPaciente.Location = new System.Drawing.Point(124, 26);
            this.radioButtonPaciente.Name = "radioButtonPaciente";
            this.radioButtonPaciente.Size = new System.Drawing.Size(14, 13);
            this.radioButtonPaciente.TabIndex = 83;
            this.radioButtonPaciente.TabStop = true;
            this.radioButtonPaciente.UseVisualStyleBackColor = true;
            this.radioButtonPaciente.CheckedChanged += new System.EventHandler(this.radioButtonPaciente_CheckedChanged_1);
            // 
            // textBoxContraseñaAdmin
            // 
            this.textBoxContraseñaAdmin.Enabled = false;
            this.textBoxContraseñaAdmin.Location = new System.Drawing.Point(576, 292);
            this.textBoxContraseñaAdmin.Name = "textBoxContraseñaAdmin";
            this.textBoxContraseñaAdmin.Size = new System.Drawing.Size(100, 20);
            this.textBoxContraseñaAdmin.TabIndex = 86;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(366, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 87;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(556, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 88;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // errorProviderPersona
            // 
            this.errorProviderPersona.ContainerControl = this;
            // 
            // TipoPersona
            // 
            this.TipoPersona.Controls.Add(this.label4);
            this.TipoPersona.Controls.Add(this.radioButton2);
            this.TipoPersona.Controls.Add(this.label5);
            this.TipoPersona.Controls.Add(this.radioButton1);
            this.TipoPersona.Controls.Add(this.label6);
            this.TipoPersona.Controls.Add(this.radioButtonPaciente);
            this.TipoPersona.ForeColor = System.Drawing.Color.White;
            this.TipoPersona.Location = new System.Drawing.Point(35, 232);
            this.TipoPersona.Name = "TipoPersona";
            this.TipoPersona.Size = new System.Drawing.Size(661, 54);
            this.TipoPersona.TabIndex = 90;
            this.TipoPersona.TabStop = false;
            this.TipoPersona.Text = "TipoPersona";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNo);
            this.groupBox1.Controls.Add(this.radioButtonSi);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(54, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 59);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habilitado";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.ForeColor = System.Drawing.Color.White;
            this.radioButtonNo.Location = new System.Drawing.Point(97, 22);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNo.TabIndex = 1;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonSi
            // 
            this.radioButtonSi.AutoSize = true;
            this.radioButtonSi.ForeColor = System.Drawing.Color.White;
            this.radioButtonSi.Location = new System.Drawing.Point(32, 22);
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.Size = new System.Drawing.Size(34, 17);
            this.radioButtonSi.TabIndex = 0;
            this.radioButtonSi.TabStop = true;
            this.radioButtonSi.Text = "Si";
            this.radioButtonSi.UseVisualStyleBackColor = true;
            // 
            // groupBoxTipoPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(727, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TipoPersona);
            this.Controls.Add(this.textBoxContraseñaAdmin);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "groupBoxTipoPersona";
            this.Text = "Persona";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPersona)).EndInit();
            this.TipoPersona.ResumeLayout(false);
            this.TipoPersona.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox TipoPersona;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonSi;
    }
}