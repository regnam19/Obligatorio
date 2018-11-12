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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(78, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABM Persona";
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelCedula.Location = new System.Drawing.Point(0, 71);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(114, 17);
            this.labelCedula.TabIndex = 1;
            this.labelCedula.Text = "Cedula Identidad";
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(120, 71);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(98, 20);
            this.textBoxCedula.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonBuscar.Location = new System.Drawing.Point(342, 25);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCelular
            // 
            this.textBoxCelular.Location = new System.Drawing.Point(400, 106);
            this.textBoxCelular.Name = "textBoxCelular";
            this.textBoxCelular.Size = new System.Drawing.Size(98, 20);
            this.textBoxCelular.TabIndex = 5;
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelCelular.Location = new System.Drawing.Point(314, 106);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(52, 17);
            this.labelCelular.TabIndex = 4;
            this.labelCelular.Text = "Celular";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(120, 109);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(98, 20);
            this.textBoxApellido.TabIndex = 7;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelApellido.Location = new System.Drawing.Point(0, 109);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(58, 17);
            this.labelApellido.TabIndex = 6;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(400, 68);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(98, 20);
            this.textBoxNombre.TabIndex = 9;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelNombre.Location = new System.Drawing.Point(314, 68);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 8;
            this.labelNombre.Text = "Nombre";
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelFechaNacimiento.Location = new System.Drawing.Point(0, 152);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(121, 17);
            this.labelFechaNacimiento.TabIndex = 14;
            this.labelFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(400, 149);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(98, 20);
            this.textBoxDireccion.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(314, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Direccion";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(287, 179);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(172, 39);
            this.buttonIngresar.TabIndex = 16;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(53, 236);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(172, 39);
            this.buttonModificar.TabIndex = 17;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(287, 236);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(172, 39);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(120, 152);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(188, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 19;
            // 
            // checkBoxSi
            // 
            this.checkBoxSi.AutoSize = true;
            this.checkBoxSi.Location = new System.Drawing.Point(83, 178);
            this.checkBoxSi.Name = "checkBoxSi";
            this.checkBoxSi.Size = new System.Drawing.Size(35, 17);
            this.checkBoxSi.TabIndex = 20;
            this.checkBoxSi.Text = "Si";
            this.checkBoxSi.UseVisualStyleBackColor = true;
            // 
            // checkBoxNo
            // 
            this.checkBoxNo.AutoSize = true;
            this.checkBoxNo.Location = new System.Drawing.Point(83, 201);
            this.checkBoxNo.Name = "checkBoxNo";
            this.checkBoxNo.Size = new System.Drawing.Size(40, 17);
            this.checkBoxNo.TabIndex = 21;
            this.checkBoxNo.Text = "No";
            this.checkBoxNo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(0, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Habilitado";
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 332);
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
            this.Name = "Persona";
            this.Text = "Persona";
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
    }
}