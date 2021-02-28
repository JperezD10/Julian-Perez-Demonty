using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Posible_parcial_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btPasajero_Click(object sender, EventArgs e)
        {
            Pasajeros p = new Pasajeros(this);
            p.ShowDialog();
        }

        private void btViaje_Click(object sender, EventArgs e)
        {
            frmVIaje v = new frmVIaje(this);
            v.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
