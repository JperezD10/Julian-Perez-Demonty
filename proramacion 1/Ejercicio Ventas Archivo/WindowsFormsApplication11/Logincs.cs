using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Logincs : Form
    {
        public Logincs()
        {
            InitializeComponent();
        }
        public String nombreCliente;
        public int numeroVenta1, importeTotalFinal1;

        private void Logincs_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtNombreCliente.Text != "")
            {
                nombreCliente = txtNombreCliente.Text;
                Venta ventana = new Venta(this);
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe introducir un nombre");
            }
          
        }
    }
}
