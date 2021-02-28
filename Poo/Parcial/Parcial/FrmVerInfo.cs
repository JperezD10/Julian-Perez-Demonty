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
    public partial class FrmVerInfo : Form
    {
        Form1 contexto;
        public FrmVerInfo(Form1 Contexto)
        {
            InitializeComponent();
            this.contexto = Contexto;
        }

        private void FrmVerInfo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = contexto.empresas.Empleados;
            contexto.empresas.CalcularEmpleados();
            LlenarEmpleadosMayores();
            lblCantidadPeon.Text = contexto.empresas.CantPeon.ToString();
            lblCantidadCapataz.Text = contexto.empresas.CantCapataz.ToString();
            lblCantidadArquitecto.Text = contexto.empresas.CantArquitecto.ToString();
            lblMayor.Text = contexto.empresas.MayorCantEmpleados;
            lblSueldoPeon.Text = contexto.empresas.SueldoPeon.ToString();
            lblSueldoCapataz.Text = contexto.empresas.SueldoCapataz.ToString();
            lblSueldoArquitecto.Text = contexto.empresas.SueldoArquitecto.ToString();
        }
     
        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOrdenar_Click(object sender, EventArgs e)
        {
            contexto.empresas.Empleados.Sort();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = contexto.empresas.Empleados;
        }
        void LlenarEmpleadosMayores()
        {
            int i = 0;
            foreach(Empleado E in contexto.empresas.Empleados)
            {
                if(E._Puesto=="Arquitecto" && E._Edad>=40)
                cmbMayores.Items.Add(contexto.empresas.Empleados[i]._Nombre + contexto.empresas.Empleados[i]._Apellido);
            }
            i++;
        }
    }
}
