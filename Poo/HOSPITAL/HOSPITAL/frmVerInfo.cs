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
    public partial class frmVerInfo : Form
    {
        Form1 Contexto;
        public frmVerInfo(Form1 Contexto)
        {
            InitializeComponent();
            this.Contexto = Contexto;
        }

        private void frmVerInfo_Load(object sender, EventArgs e)
        {
            LlenarComboEspecialidades();
            LblGananciaTotal.Text = Especialidades.GananciaTotal.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbDatos.SelectedIndex;

            switch (i)
            {
                case 0:
                    dataGridView1.DataSource = Contexto.Hospital.Medico;
                    break;
                case 1:
                    dataGridView1.DataSource = Contexto.Hospital.Especialidad;
                    break;
                case 2:
                    dataGridView1.DataSource = Contexto.Hospital.AsignarMedico;
                    break;
                case 3:
                    dataGridView1.DataSource = Contexto.Hospital.Paciente;
                    break;

            }
            
        }

        void LlenarComboEspecialidades()
        {
            foreach (Especialidades H in Contexto.Hospital.Especialidad)
            {
                CmbEspecialidades.Items.Add(H.NombreEspecialdidad);
            }

        }

        private void CmbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = CmbEspecialidades.SelectedIndex;

            dataGridView2.DataSource = Contexto.Hospital.Especialidad[CmbEspecialidades.SelectedIndex].Estudio;

        }

        private void BtnFecha_Click(object sender, EventArgs e)
        {
            try
            {
            int i = CmbEspecialidades.SelectedIndex;

            Estudios.i = 0;

            Contexto.Hospital.Especialidad[CmbEspecialidades.SelectedIndex].Estudio.Sort();

            dataGridView2.DataSource = Contexto.Hospital.Especialidad[CmbEspecialidades.SelectedIndex].Estudio;
            }
            catch
            {

            }

        }

        private void BtnNombre_Click(object sender, EventArgs e)
        {
            try
            {
                int i = CmbEspecialidades.SelectedIndex;

                Estudios.i = 1;

                Contexto.Hospital.Especialidad[CmbEspecialidades.SelectedIndex].Estudio.Sort();

                dataGridView2.DataSource = Contexto.Hospital.Especialidad[CmbEspecialidades.SelectedIndex].Estudio;
            }
            catch
            {

            }

        }
    }
}
