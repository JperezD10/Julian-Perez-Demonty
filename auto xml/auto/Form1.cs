using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BLL.Auto gestor = new BLL.Auto();
        private void btAgregar_Click(object sender, EventArgs e)
        {
            BE.Auto temp = new BE.Auto();
            temp._Patente = txtPatente.Text;
            temp._Modelo = txtModelo.Text;
            temp._Estado = comboBox1.Text;
            gestor.Agregar(temp);
            gestor.Generar();
            MessageBox.Show("carga3");
        }

        private void btXML_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
