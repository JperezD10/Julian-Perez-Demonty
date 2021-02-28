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
    public partial class frmVer : Form
    {
        Form1 contexto;
        public frmVer(Form1 Contexto)
        {
            InitializeComponent();
            this.contexto = Contexto;
        }

        private void frmVer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = contexto.empresas.Empleados;
            contexto.empresas.CalcularSueldo();
            lblCantPeones.Text = contexto.empresas.CantPeon.ToString();
            lblCantCapataces.Text = contexto.empresas.CantCapataz.ToString();
            lblCantArquitectos.Text = contexto.empresas.CantArquitecto.ToString();
            lblSueldoPeon.Text = contexto.empresas.SueldoPeon.ToString();
            lblSueldoCapataz.Text = contexto.empresas.SueldoCapataz.ToString();
            lblSueldoArquitecto.Text = contexto.empresas.Sueldoarquitecto.ToString();
            lblTotalEmpresa.Text = contexto.empresas.SueldoTotalEmpresa.ToString();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOrdernar_Click(object sender, EventArgs e)
        {
            contexto.empresas.Empleados.Sort();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = contexto.empresas.Empleados;
        }
    }
}
