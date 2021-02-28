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
    public partial class frmAgregarTrabajo : Form
    {
        Empresa empresa;
        public frmAgregarTrabajo(Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
        }

        private void frmAgregarTrabajo_Load(object sender, EventArgs e)
        {
            cargarEmpleadosNormal();
            panelArquitecto.Visible = panelCapataz.Visible = panelPeon.Visible= false;
          
        }

        public void cargarEmpleadosNormal()
        {
            cmbEmpleados.Items.Clear();
            cmbEmpleados.Text = "";
            foreach(Empleado single in empresa.empleados)
            {
                cmbEmpleados.Items.Add(single);
            }
        }

        public void cargarEmpleadosAlfabeticamente()
        {
            cmbEmpleados.Items.Clear();
            cmbEmpleados.Text = "";
            List<Empleado> lista = new List<Empleado>();
            foreach(Empleado emp in empresa.empleados)
            {
                lista.Add(emp);
            }
            lista.Sort();
            foreach (Empleado single in lista)
            {
                cmbEmpleados.Items.Add(single);
            }
        }

        private void btnSortLegajo_Click(object sender, EventArgs e)
        {
            cargarEmpleadosNormal();
        }

        private void btnSortAlfab_Click(object sender, EventArgs e)
        {
            cargarEmpleadosAlfabeticamente();
        }

        private void cmbEmpleados_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbEmpleados.SelectedItem != null)
            {
                Empleado emp = (Empleado)cmbEmpleados.SelectedItem;
                emp.obtenerPuesto += this.mostrarPuesto;
                emp.consultarPuesto();
               
            }
        }

        private void mostrarPuesto(PuestoTrabajo puesto)
        {
            lblPuesto.Text = puesto.NombrePuesto;
            if(puesto is Capataz)
            {
                panelCapataz.Visible = true;
                panelArquitecto.Visible = panelPeon.Visible = false;
            }else if(puesto is Peon)
            {
                panelPeon.Visible = true;
                panelArquitecto.Visible = panelCapataz.Visible = false;
            }else if(puesto is Arquitecto)
            {
                panelArquitecto.Visible = true;
                panelPeon.Visible = panelCapataz.Visible = false;
            }
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptarAsignarPeones_Click(object sender, EventArgs e)
        {
            Empleado emp = (Empleado)cmbEmpleados.SelectedItem;
            ((Capataz)emp.Puesto).CantPeones = int.Parse(peonesAsignadosNumericUpDown1.Value.ToString());

        }
    }
}
