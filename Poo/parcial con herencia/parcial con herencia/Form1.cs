using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial_con_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Empleado empleados;
        public Empresa empresas = new Empresa();
        private void Form1_Load(object sender, EventArgs e)
        {
            lblCargo.Enabled = lblProyectos.Enabled = txtCargo.Enabled = txtProyecto.Enabled = false;
            lblID.Text = "1";
        }

        private void btVer_Click(object sender, EventArgs e)
        {
            frmVer v = new frmVer(this);
            v.ShowDialog();
        }
        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtEdad.Text) >= 18)
            {
                if (cmbPuesto.SelectedIndex == 0)
                {
                    empleados = new Peon(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), cmbPuesto.Text, int.Parse(txtHoras.Text));
                    ((Peon)empleados).CalcularSueldo(int.Parse(txtHoras.Text));

                }
                else if (cmbPuesto.SelectedIndex == 1)
                {
                    empleados = new Capataz(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), cmbPuesto.Text, int.Parse(txtCargo.Text));
                    ((Capataz)empleados).CalcularSueldo(int.Parse(txtCargo.Text));
                }
                else
                {
                    empleados = new Arquitecto(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), cmbPuesto.Text, int.Parse(txtProyecto.Text));
                    ((Arquitecto)empleados).CalcularSueldo(int.Parse(txtProyecto.Text));
                }
                empresas.Empleados.Add(empleados);
                lblID.Text = (empleados._ID + 1).ToString();
            }
            else
            {
                empresas.NoCreado += NoCreado;
                empresas.evento();
            }
        }
        void NoCreado(string menssaje)
        {
            MessageBox.Show(menssaje);
        }
        private void cmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPuesto.SelectedIndex == 0)
            {
                lblCargo.Enabled = lblProyectos.Enabled = txtCargo.Enabled = txtProyecto.Enabled = false;
                lblHoras.Enabled = txtHoras.Enabled = true;
            }
            else if (cmbPuesto.SelectedIndex == 1)
            {
                lblHoras.Enabled = txtHoras.Enabled = lblProyectos.Enabled = txtProyecto.Enabled = false;
                lblCargo.Enabled = txtCargo.Enabled = true;
            }
            else
            {
                lblHoras.Enabled = lblCargo.Enabled = txtHoras.Enabled = txtCargo.Enabled = txtCargo.Enabled = false;
                lblProyectos.Enabled = txtProyecto.Enabled = true;
            }
        }
    }
}
