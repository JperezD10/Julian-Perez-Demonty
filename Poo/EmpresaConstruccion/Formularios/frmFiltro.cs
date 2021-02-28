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
    public partial class frmFiltro : Form
    {
        Empresa empresa;

        public frmFiltro(Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
        }

        private void frmFiltro_Load(object sender, EventArgs e)
        {
            cargarEmpleadosNormal();
        }

        public void cargarEmpleadosNormal()
        {
            cmbEmpleados.Items.Clear();
            cmbEmpleados.Text = "";
            foreach (Empleado single in empresa.empleados)
            {
                if(single.Puesto is Arquitecto && single.Edad  > 45)
                {
                    cmbEmpleados.Items.Add(single);
                }
                
            }
        }
    }
}
