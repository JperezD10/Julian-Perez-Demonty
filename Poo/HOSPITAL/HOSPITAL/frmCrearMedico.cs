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
    
    public partial class frmCrearMedico : Form
    {
        Form1 Contexto;
        public frmCrearMedico(Form1 Contexto)
        {
            InitializeComponent();
            this.Contexto = Contexto;
        }

        private void BtnCrearBoton_Click(object sender, EventArgs e)
        {
            Contexto.Medico = new Medicos(TxtNombre.Text, TxtApellido.Text, int.Parse(TxtDni.Text));
            Contexto.Hospital.LlenarListaMedico(Contexto.Medico);
        }
    }
}
