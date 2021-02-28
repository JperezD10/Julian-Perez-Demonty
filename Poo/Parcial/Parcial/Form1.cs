using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASES;


namespace Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Empresa empresas = new Empresa();
        public Peon peones = new Peon();
        public Capataz capataces = new Capataz();
        public Arquitecto arquitectos = new Arquitecto();
        public Empleado Empleado;
        private void btCrear_Click(object sender, EventArgs e)
        {
            FrmCrearEmpleado c = new FrmCrearEmpleado(this);
            c.ShowDialog();
        }

        private void BtVer_Click(object sender, EventArgs e)
        {
            FrmVerInfo v = new FrmVerInfo(this);
            v.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
