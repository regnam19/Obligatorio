namespace Logica.WINFORMS
{
    partial class Consultorios
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
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelHoraInicio = new System.Windows.Forms.Label();
            this.labelHoraFin = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxHoraInicio = new System.Windows.Forms.TextBox();
            this.textBoxHoraFin = new System.Windows.Forms.TextBox();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABM Consultorio";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelDireccion.ForeColor = System.Drawing.Color.White;
            this.labelDireccion.Location = new System.Drawing.Point(98, 118);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(71, 17);
            this.labelDireccion.TabIndex = 1;
            this.labelDireccion.Text = "Dirección:";
            this.labelDireccion.Visible = false;
            // 
            // labelHoraInicio
            // 
            this.labelHoraInicio.AutoSize = true;
            this.labelHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelHoraInicio.ForeColor = System.Drawing.Color.White;
            this.labelHoraInicio.Location = new System.Drawing.Point(97, 155);
            this.labelHoraInicio.Name = "labelHoraInicio";
            this.labelHoraInicio.Size = new System.Drawing.Size(79, 17);
            this.labelHoraInicio.TabIndex = 2;
            this.labelHoraInicio.Text = "Hora Inicio:";
            this.labelHoraInicio.Visible = false;
            // 
            // labelHoraFin
            // 
            this.labelHoraFin.AutoSize = true;
            this.labelHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelHoraFin.ForeColor = System.Drawing.Color.White;
            this.labelHoraFin.Location = new System.Drawing.Point(97, 192);
            this.labelHoraFin.Name = "labelHoraFin";
            this.labelHoraFin.Size = new System.Drawing.Size(66, 17);
            this.labelHoraFin.TabIndex = 3;
            this.labelHoraFin.Text = "Hora Fin:";
            this.labelHoraFin.Visible = false;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(189, 118);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDireccion.TabIndex = 4;
            this.textBoxDireccion.Visible = false;
            // 
            // textBoxHoraInicio
            // 
            this.textBoxHoraInicio.Location = new System.Drawing.Point(189, 155);
            this.textBoxHoraInicio.MaxLength = 2;
            this.textBoxHoraInicio.Name = "textBoxHoraInicio";
            this.textBoxHoraInicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxHoraInicio.TabIndex = 5;
            this.textBoxHoraInicio.Visible = false;
            this.textBoxHoraInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHoraInicio_KeyPress);
            // 
            // textBoxHoraFin
            // 
            this.textBoxHoraFin.Location = new System.Drawing.Point(189, 192);
            this.textBoxHoraFin.MaxLength = 2;
            this.textBoxHoraFin.Name = "textBoxHoraFin";
            this.textBoxHoraFin.Size = new System.Drawing.Size(100, 20);
            this.textBoxHoraFin.TabIndex = 6;
            this.textBoxHoraFin.Visible = false;
            this.textBoxHoraFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHoraFin_KeyPress);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.buttonInsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(186)))), ((int)(((byte)(20)))));
            this.buttonInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.buttonInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertar.ForeColor = System.Drawing.Color.White;
            this.buttonInsertar.Location = new System.Drawing.Point(64, 66);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertar.TabIndex = 9;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.buttonModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(186)))), ((int)(((byte)(20)))));
            this.buttonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.ForeColor = System.Drawing.Color.White;
            this.buttonModificar.Location = new System.Drawing.Point(189, 66);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 10;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(309, 66);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 11;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.buttonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(186)))), ((int)(((byte)(20)))));
            this.buttonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Location = new System.Drawing.Point(309, 95);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 12;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Visible = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.content.Controls.Add(this.label1);
            this.content.Controls.Add(this.textBoxId);
            this.content.Controls.Add(this.buttonInsertar);
            this.content.Controls.Add(this.labelId);
            this.content.Controls.Add(this.buttonModificar);
            this.content.Controls.Add(this.textBoxHoraFin);
            this.content.Controls.Add(this.buttonBuscar);
            this.content.Controls.Add(this.textBoxHoraInicio);
            this.content.Controls.Add(this.textBoxDireccion);
            this.content.Controls.Add(this.buttonEliminar);
            this.content.Controls.Add(this.labelHoraFin);
            this.content.Controls.Add(this.labelDireccion);
            this.content.Controls.Add(this.labelHoraInicio);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(726, 457);
            this.content.TabIndex = 14;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(72, 95);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(44, 20);
            this.textBoxId.TabIndex = 8;
            this.textBoxId.Visible = false;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelId.ForeColor = System.Drawing.Color.White;
            this.labelId.Location = new System.Drawing.Point(43, 95);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(23, 17);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "Id:";
            this.labelId.Visible = false;
            // 
            // Consultorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 457);
            this.Controls.Add(this.content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultorios";
            this.Text = "Consultorio";
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelHoraInicio;
        private System.Windows.Forms.Label labelHoraFin;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxHoraInicio;
        private System.Windows.Forms.TextBox textBoxHoraFin;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
    }
}