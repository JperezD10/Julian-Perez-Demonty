﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreParcial
{
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
        }

        private void btEmpleado_Click(object sender, EventArgs e)
        {
            Form1 E = new Form1(this);
            E.ShowDialog();
        }
    }
}
