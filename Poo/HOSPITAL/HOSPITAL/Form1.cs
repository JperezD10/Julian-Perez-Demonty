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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Hospital Hospital = new Hospital();
        public Especialidades Especialidad;
        public Medicos Medico;
        public Asignaciones Asignar;
        public Estudios Estudio;
        public Pacientes Paciente;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCrearEspecialidad_Click(object sender, EventArgs e)
        {
            frmCrearEspecialidad FC = new frmCrearEspecialidad(this);
            FC.ShowDialog();
        }

        private void BtnCrearMedico_Click(object sender, EventArgs e)
        {
            frmCrearMedico CM = new frmCrearMedico(this);
            CM.ShowDialog();
        }

        private void BtnAsignarMedico_Click(object sender, EventArgs e)
        {
            frmAsignarMedico FA = new frmAsignarMedico(this);
            FA.ShowDialog();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            frmVerInfo VI = new frmVerInfo(this);
            VI.ShowDialog();
        }

        private void BtnCrearEstudio_Click(object sender, EventArgs e)
        {
            CrearEstudio CE = new CrearEstudio(this);
            CE.ShowDialog();
        }

        private void BtnPaciente_Click(object sender, EventArgs e)
        {
            frmCrearPciente CP = new frmCrearPciente(this);
            CP.ShowDialog();

        }
    }
}
