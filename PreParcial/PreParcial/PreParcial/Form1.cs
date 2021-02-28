using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreParcial
{
    public partial class Form1 : Form
    {
        MenuInicio contexto;
        BE.Empleado temp;
        BLL.Empleado_BLL gestor = new BLL.Empleado_BLL();

        public Form1(MenuInicio contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPuesto.SelectedIndex = cmbSexo.SelectedIndex = 0;
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            temp = new BE.Empleado();
            temp._Nombre = txtNombre.Text;
            temp._Apellido = txtApellido.Text;
            if (cmbPuesto.SelectedIndex == 0)
            {
                temp._CodigoEmpleado = txtCodigo.Text + "GER";
            }
            else if (cmbPuesto.SelectedIndex == 1)
            {
                temp._CodigoEmpleado = txtCodigo.Text + "ADM";
            }
            else
            {
                temp._CodigoEmpleado = txtCodigo.Text + "LOG";
            }
            temp._Sexo = cmbSexo.Text;
            temp._Edad = int.Parse(txtEdad.Text);
            temp._Direccion = txtDireccion.Text;
            temp._Puesto = cmbPuesto.Text;
            try
            {
                gestor.Agregar(temp);
                MessageBox.Show("Agrega3");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            temp = null;
        }
    }
}
