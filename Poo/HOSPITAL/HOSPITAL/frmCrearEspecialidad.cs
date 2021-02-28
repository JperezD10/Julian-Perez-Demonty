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

namespace HOSPITAL
{
    public partial class frmCrearEspecialidad : Form
    {
        Form1 Contexto;
        public frmCrearEspecialidad(Form1 Contexto)
        {
            InitializeComponent();
            this.Contexto = Contexto;
        }

        private void frmCrearEspecialidad_Load(object sender, EventArgs e)
        {

        }

        private void BtnCrearEspecialidad_Click(object sender, EventArgs e)
        {
            Contexto.Especialidad = new Especialidades(TxtTipoEspecialidad.Text);
            Contexto.Hospital.LlenarListaEspecialidad(Contexto.Especialidad);
        }
    }
}
