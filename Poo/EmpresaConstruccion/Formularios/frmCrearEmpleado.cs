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
    public partial class frmCrearEmpleado : Form
    {
        Empresa empresa;
        public frmCrearEmpleado(Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
        }

        private void frmCrearEmpleado_Load(object sender, EventArgs e)
        {
            cargarPuestos();
            limpiar();
        }

        private void cargarPuestos()
        {
            cmbPuesto.Items.Add("Capataz");
            cmbPuesto.Items.Add("Peon");
            cmbPuesto.Items.Add("Arquitecto");
        }
        private void limpiar()
        {
            txtLegajo.Text = (empresa.empleados.Count() + 1).ToString();
            txtApellido.Text = "";
            txtNombre.Text = "";
            cmbPuesto.SelectedIndex = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int legajo = int.Parse(txtLegajo.Text);
            PuestoTrabajo puesto;
            switch (cmbPuesto.SelectedIndex)
            {
                case 0: puesto = new Capataz();
                    break;
                case 1: puesto = new Peon();
                    break;
                case 2: puesto = new Arquitecto();
                    break;
                default: puesto = new Peon();
                    break;
            }
            int edad = int.Parse(edadNumericUpDown.Value.ToString());
            empresa.empleados.Add(new Empleado(legajo,txtNombre.Text,txtApellido.Text,edad,puesto));
            limpiar();
        }
    }
}
