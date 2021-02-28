using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avion
{
    public partial class MenuPrincipal : Form
    {
        public bool[] asientosAltaVendidos = new bool[20];
        public bool[] asientosBajaVendidos = new bool[25];
        public float[] total = new float[2];
        

        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void cargarVectores()
        {
            for(int i = 0;i < asientosAltaVendidos.Length; i++)
            {
                asientosAltaVendidos[i] = false;
            }
            for(int j = 0; j < asientosBajaVendidos.Length; j++)
            {
                asientosBajaVendidos[j] = false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AdministrarAvion form = new AdministrarAvion(this);
            form.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consultas form = new Consultas(this);
            form.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
