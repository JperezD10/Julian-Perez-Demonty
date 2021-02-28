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
    public partial class frmJuez : Form
    {

        Contenedor contenedor;
        public frmJuez(Contenedor context)
        {
            InitializeComponent();
            contenedor = context;
        }

        private void frmJuez_Load(object sender, EventArgs e)
        {
            lblNroLegajo.Text = Juez.Numero.ToString();
            
        }

        private void btnCrearJuez_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Replace(" ", "").Equals("") && !txtApellido.Text.Replace(" ", "").Equals(""))
            {
                Juez juez = new Juez(txtNombre.Text, txtApellido.Text);
                contenedor.addJuez(juez);
                MessageBox.Show("AGREGADO CORRECTAMENTE");

                resetTxt();
            }
            else
            {
                MessageBox.Show("ALGUN CAMPO ESTÁ VACIO");
            }

        }
        private void resetTxt()
        {
            lblNroLegajo.Text = Juez.Numero.ToString();
            txtNombre.Clear();
            txtApellido.Clear();
        }
    }
}
