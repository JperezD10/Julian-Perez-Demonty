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
    public partial class frmCrearPciente : Form
    {
        Form1 Contexto;
        public frmCrearPciente(Form1 Contexto)
        {
            InitializeComponent();
            this.Contexto = Contexto;
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            Contexto.Paciente = new Pacientes(TxtNombre.Text,TxtApellido.Text,int.Parse(TxtDni.Text));

            Contexto.Hospital.LlenarListaPaciente(Contexto.Paciente);

        }
    }
}
