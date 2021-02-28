using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
namespace Formularios
{
    public partial class frmSueldoPorEmpleado : Form
    {
        Empresa empresa;
        public frmSueldoPorEmpleado(Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
        }

        private void frmSueldoPorEmpleado_Load(object sender, EventArgs e)
        {

            cargarEmpleadosNormal();
        }
        public void cargarEmpleadosNormal()
        {
            cmbEmpleado.Items.Clear();
            cmbEmpleado.Text = "";
            foreach (Empleado single in empresa.empleados)
            {
                cmbEmpleado.Items.Add(single);
            }
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empleado emp = (Empleado)cmbEmpleado.SelectedItem;

            lblTotal.Text = emp.Puesto.obtenerSueldo().ToString();
        }
    }
}
