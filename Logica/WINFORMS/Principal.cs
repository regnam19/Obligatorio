﻿using System;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnRegisters_Click(object sender, EventArgs e)
        {
            Registros frmRegistros = new Registros();
            frmRegistros.Show();
            Hide();
        }
    }
}