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
    public partial class Sucursales : Form
    {
        MenuInicio contexto;
        public Sucursales(MenuInicio contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
        }
        BLL.Sucursal_BLL gestor = new BLL.Sucursal_BLL();
        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            BE.Sucursal sucursal = new BE.Sucursal();
            sucursal._IDSucursal = int.Parse(txtIDSucursal.Text);
            sucursal._Direccion = txtDireccion.Text;
            try
            {
                gestor.Agregar(sucursal);
                MessageBox.Show("sucursal agrega3");
            }
            catch (Exception)
            {
                MessageBox.Show("error al agregar");
            }
            txtDireccion.Text = txtIDSucursal.Text = "";
            sucursal = null;
        }
    }
}
