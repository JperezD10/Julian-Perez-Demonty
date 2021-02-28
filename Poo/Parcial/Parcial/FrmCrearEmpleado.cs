using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASES;

namespace Parcial
{
    public partial class FrmCrearEmpleado : Form
    {
        Form1 contexto;
        public FrmCrearEmpleado(Form1 Contexto)
        {
            InitializeComponent();
            this.contexto = Contexto;
        }

        private void FrmCrearEmpleado_Load(object sender, EventArgs e)
        {
            cmbPuesto.SelectedIndex = 0;
            lblPeones.Enabled = lblProyectos.Enabled = txtPeonACargo.Enabled = txtProyectos.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCrearEmpleado_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtEdad.Text) >= 18)
            {
                float sueldo = 0;
                if (cmbPuesto.SelectedIndex == 0)
                {
                    contexto.peones._HorasTrabajadas = int.Parse(txtHoras.Text);
                    contexto.peones.CalcularSueldo();
                    sueldo = contexto.peones.CalcularSueldo();
                }
                else if (cmbPuesto.SelectedIndex == 1)
                {
                    contexto.capataces._PeonesACargo = int.Parse(txtPeonACargo.Text);
                    contexto.capataces.CalcularSueldo();
                    sueldo = contexto.capataces.CalcularSueldo();
                }
                else
                {
                    contexto.arquitectos._CantidadDeProyectos = int.Parse(txtProyectos.Text);
                    contexto.arquitectos.CalcularSueldo();
                    sueldo = contexto.arquitectos.CalcularSueldo();
                }
                contexto.Empleado = new Empleado(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), cmbPuesto.Text, sueldo);
                contexto.empresas.Empleados.Add(contexto.Empleado);
                txtApellido.Text = txtNombre.Text = txtHoras.Text = txtEdad.Text = "";
                cmbPuesto.SelectedIndex = 0;
                contexto.empresas.Creados += Creado;
                contexto.empresas.evento(1);
                
            }
            else
            {
                txtApellido.Text = txtNombre.Text = txtHoras.Text = txtEdad.Text = "";
                cmbPuesto.SelectedIndex = 0;
                contexto.empresas.NoCreados += NoCreado;
                contexto.empresas.evento(2);
            }
            
        }
        void Creado(string Mensaje)
        {
            MessageBox.Show(Mensaje);
        }
        void NoCreado(string Mensaje)
        {
            MessageBox.Show(Mensaje);
        }
        private void cmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPuesto.SelectedIndex == 0)
            {
                lblPeones.Enabled = lblProyectos.Enabled = txtPeonACargo.Enabled = txtProyectos.Enabled = false;
                lblHoras.Enabled = txtHoras.Enabled = true;
            }
            else if (cmbPuesto.SelectedIndex == 1)
            {
                lblHoras.Enabled = lblProyectos.Enabled = txtHoras.Enabled = txtProyectos.Enabled = false;
                lblPeones.Enabled = txtPeonACargo.Enabled = true;
            }
            else
            {
                lblHoras.Enabled = lblPeones.Enabled = txtHoras.Enabled = txtPeonACargo.Enabled = false;
                lblProyectos.Enabled = txtProyectos.Enabled = true;
            }
        }
    }
}
