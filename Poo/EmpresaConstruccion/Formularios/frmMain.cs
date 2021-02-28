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
    public partial class frmMain : Form
    {
        Empresa empresa;
        public frmMain()
        {
            InitializeComponent();
            empresa = new Empresa();
        }

        private void crearEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCrearEmpleado ventana = new frmCrearEmpleado(empresa);
            ventana.MdiParent = this;
            ventana.Show();

        }

        private void agregarTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarTrabajo ventana = new frmAgregarTrabajo(empresa);
            ventana.MdiParent = this;
            ventana.Show();

        }

        private void mostrarRecaudacionTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String mensaje ="La recaudacion total es : $"+ empresa.getRecaudacionTotal();
            MessageBox.Show(mensaje);
        }

        private void mostrarPagadoPorPuestoDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String mensaje = "Capataz: " + empresa.getRecaudacionCapataz();
            mensaje += "\nPeon: " + empresa.getRecaudacionPeon();
            mensaje += "\nArquitecto: " + empresa.getRecaudacionArquitecto();
            MessageBox.Show(mensaje);

        }

        private void mostrarSueldoPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSueldoPorEmpleado ventana = new frmSueldoPorEmpleado(empresa);
            ventana.MdiParent = this;
            ventana.Show();

        }

        private void mostrarCategoriaMasEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String mensaje = empresa.getCategoriaMayorEmpleados();
            MessageBox.Show(mensaje);
        }

        private void mostrarListaArquitectosMayores45AñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltro ventana = new frmFiltro(empresa);
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
