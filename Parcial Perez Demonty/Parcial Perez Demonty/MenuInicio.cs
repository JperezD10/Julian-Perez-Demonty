using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Perez_Demonty
{
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
        }

        private void btProductos_Click(object sender, EventArgs e)
        {
            Productos p = new Productos(this);
            p.ShowDialog();
        }

        private void btVentas_Click(object sender, EventArgs e)
        {
            Ventas v = new Ventas(this);
            v.ShowDialog();
        }

        private void btSucursal_Click(object sender, EventArgs e)
        {
            Sucursales s = new Sucursales(this);
            s.ShowDialog();
        }
    }
}
