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
    public partial class Productos : Form
    {
        MenuInicio contexto;
        public Productos(MenuInicio contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
        }
        BLL.Producto_BLL gestor = new BLL.Producto_BLL();
        BE.Producto temp;
        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            temp = new BE.Producto();
            temp._IDProducto = int.Parse(txtIDProducto.Text);
            temp._Descripcion = txtDescripcion.Text;
            temp._Stock = int.Parse(txtStock.Text);
            temp._PrecioU = int.Parse(txtPrecioU.Text);
            try
            {
                gestor.Agregar(temp);
                MessageBox.Show("agrega3");
            }
            catch(Exception)
            {
                MessageBox.Show("error al agregar");
            }
            txtDescripcion.Text = txtIDProducto.Text = txtPrecioU.Text = txtStock.Text = "";
            temp = null;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            temp = new BE.Producto();
            temp._IDProducto = int.Parse(txtIDProducto.Text);
            temp._Descripcion = txtDescripcion.Text;
            temp._Stock = int.Parse(txtStock.Text);
            temp._PrecioU = int.Parse(txtPrecioU.Text);
            try
            {
                gestor.Modificar(temp);
                MessageBox.Show("Modifica3");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar");
            }
            txtDescripcion.Text = txtIDProducto.Text = txtPrecioU.Text = txtStock.Text = "";
            temp = null;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            temp = new BE.Producto();
            temp._IDProducto = int.Parse(txtIDProducto.Text);
            try
            {
                gestor.Eliminar(temp);
                MessageBox.Show("Elimina3");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar");
            }
            txtDescripcion.Text = txtIDProducto.Text = txtPrecioU.Text = txtStock.Text = "";
            temp = null;
        }
        void ver()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestor.listar();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = (BE.Producto)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtIDProducto.Text = temp._IDProducto.ToString();
            txtDescripcion.Text = temp._Descripcion.ToString();
            txtStock.Text = temp._Stock.ToString();
            txtPrecioU.Text = temp._PrecioU.ToString();
        }
        void vermayores()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestor.Mayores();
        }
        private void btVer_Click(object sender, EventArgs e)
        {
            ver();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMayores_Click(object sender, EventArgs e)
        {
            vermayores();
        }
    }
}
