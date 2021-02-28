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
    public partial class Ventas : Form
    {
        MenuInicio contexto;
        public Ventas(MenuInicio contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
        }
        BE.Venta temp;
        BE.Producto p;
        BLL.venta_BLL gestor = new BLL.venta_BLL();
        BLL.Producto_BLL producto = new BLL.Producto_BLL();
        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void ver()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = producto.listar();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            p = (BE.Producto)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtIDProducto.Text = p._IDProducto.ToString();
            txtPrecioUnitario.Text = p._PrecioU.ToString();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            temp = new BE.Venta();
            temp._IdVenta = int.Parse(txtIDVenta.Text);
            temp._IDSucursal = int.Parse(txtIDSucursal.Text);
            temp._IDProducto = int.Parse(txtIDProducto.Text);
            temp._Cantidad = int.Parse(txtCantidad.Text);
            temp._Precio = int.Parse(txtPrecioUnitario.Text);
            temp._Importe = int.Parse(txtCantidad.Text) * int.Parse(txtPrecioUnitario.Text);
            lblImporte.Text= temp._Importe.ToString();
            try
            {
                gestor.Agregar(temp);
                MessageBox.Show("venta realiza3");
            }
            catch (Exception)
            {
                MessageBox.Show("error al cargar venta");
            }
            temp = null;
        }

        private void btVer_Click(object sender, EventArgs e)
        {
            ver();
        }

        private void btMayores_Click(object sender, EventArgs e)
        {

        }
    }
}
