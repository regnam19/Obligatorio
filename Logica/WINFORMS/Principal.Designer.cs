namespace Logica.WINFORMS
{
    partial class Principal
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
            this.lblRegisters = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblSections = new System.Windows.Forms.Label();
            this.lblSumary = new System.Windows.Forms.Label();
            this.btnSumary = new System.Windows.Forms.Button();
            this.btnSections = new System.Windows.Forms.Button();
            this.btnRegisters = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegisters
            // 
            this.lblRegisters.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisters.Location = new System.Drawing.Point(9, 20);
            this.lblRegisters.Name = "lblRegisters";
            this.lblRegisters.Size = new System.Drawing.Size(150, 23);
            this.lblRegisters.TabIndex = 4;
            this.lblRegisters.Text = "REGISTROS";
            this.lblRegisters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsers
            // 
            this.lblUsers.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(9, 228);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(150, 23);
            this.lblUsers.TabIndex = 5;
            this.lblUsers.Text = "USUARIOS";
            this.lblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSections
            // 
            this.lblSections.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSections.Location = new System.Drawing.Point(174, 20);
            this.lblSections.Name = "lblSections";
            this.lblSections.Size = new System.Drawing.Size(150, 23);
            this.lblSections.TabIndex = 6;
            this.lblSections.Text = "SECCIONES";
            this.lblSections.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSumary
            // 
            this.lblSumary.Enabled = false;
            this.lblSumary.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumary.Location = new System.Drawing.Point(174, 228);
            this.lblSumary.Name = "lblSumary";
            this.lblSumary.Size = new System.Drawing.Size(150, 23);
            this.lblSumary.TabIndex = 7;
            this.lblSumary.Text = "CALCULOS";
            this.lblSumary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSumary.Visible = false;
            // 
            // btnSumary
            // 
            this.btnSumary.Enabled = false;
            this.btnSumary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSumary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumary.Location = new System.Drawing.Point(177, 254);
            this.btnSumary.Name = "btnSumary";
            this.btnSumary.Size = new System.Drawing.Size(147, 151);
            this.btnSumary.TabIndex = 3;
            this.btnSumary.TabStop = false;
            this.btnSumary.UseVisualStyleBackColor = true;
            this.btnSumary.Visible = false;
            // 
            // btnSections
            // 
            this.btnSections.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSections.Location = new System.Drawing.Point(177, 46);
            this.btnSections.Name = "btnSections";
            this.btnSections.Size = new System.Drawing.Size(147, 151);
            this.btnSections.TabIndex = 2;
            this.btnSections.TabStop = false;
            this.btnSections.UseVisualStyleBackColor = true;
            // 
            // btnRegisters
            // 
            this.btnRegisters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegisters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisters.Location = new System.Drawing.Point(12, 46);
            this.btnRegisters.Name = "btnRegisters";
            this.btnRegisters.Size = new System.Drawing.Size(147, 151);
            this.btnRegisters.TabIndex = 1;
            this.btnRegisters.TabStop = false;
            this.btnRegisters.UseVisualStyleBackColor = true;
            this.btnRegisters.Click += new System.EventHandler(this.btnRegisters_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(12, 254);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(147, 151);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.TabStop = false;
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(339, 431);
            this.Controls.Add(this.lblSumary);
            this.Controls.Add(this.lblSections);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblRegisters);
            this.Controls.Add(this.btnSumary);
            this.Controls.Add(this.btnSections);
            this.Controls.Add(this.btnRegisters);
            this.Controls.Add(this.btnUsers);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnRegisters;
        private System.Windows.Forms.Button btnSections;
        private System.Windows.Forms.Button btnSumary;
        private System.Windows.Forms.Label lblRegisters;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblSections;
        private System.Windows.Forms.Label lblSumary;
    }
}