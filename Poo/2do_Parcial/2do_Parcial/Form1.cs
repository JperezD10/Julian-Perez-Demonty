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

namespace _2do_Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Empresa Empresa = new Empresa();
        public Capataz Capataz = new Capataz();
        public Arquitecto Arquitecto = new Arquitecto();
        public Peon Peon = new Peon();
        public Empleado Empleado;

        private void BtnVerInfo_Click(object sender, EventArgs e)
        {
            Ver_Info VI = new Ver_Info(this);
            VI.ShowDialog();
        }

        private void BtnCrearEmpleado_Click(object sender, EventArgs e)
        {
            Crear_Empleado CE = new Crear_Empleado(this);
            CE.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
