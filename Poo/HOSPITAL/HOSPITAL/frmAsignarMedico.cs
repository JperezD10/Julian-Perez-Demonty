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
    public partial class frmAsignarMedico : Form
    {
        Form1 Contexto;
        public frmAsignarMedico(Form1 Contexto)
        {
            InitializeComponent();
            this.Contexto = Contexto;
        }

        private void frmAsignarMedico_Load(object sender, EventArgs e)
        {
            LlenarComboMedicos();
            LlenarComboEspecialidades();

        }

        void LlenarComboEspecialidades()
        {
            foreach(Especialidades H in Contexto.Hospital.Especialidad)
            {
                CmbEspecialidad.Items.Add(H.NombreEspecialdidad);
            }

        }

        void LlenarComboMedicos()
        {
            foreach (Medicos H in Contexto.Hospital.Medico)
            {
                CmbMedicos.Items.Add(H.Nombre + " " + H.Apellido);
            }

        }

        private void BtnAsignar_Click(object sender, EventArgs e)
        {
            string Nombre,Apellido,Especialidad = "";
            double Costo=0;

            Nombre = Contexto.Hospital.Medico[CmbMedicos.SelectedIndex].Nombre;
            Apellido = Contexto.Hospital.Medico[CmbMedicos.SelectedIndex].Apellido;
            Especialidad = Contexto.Hospital.Especialidad[CmbEspecialidad.SelectedIndex].NombreEspecialdidad;
            
            Contexto.Hospital.Medico[CmbMedicos.SelectedIndex].CantEspecializaciones++;

            Contexto.Hospital.Medico[CmbMedicos.SelectedIndex].CalcularCosto();
            Costo = Contexto.Hospital.Medico[CmbMedicos.SelectedIndex].Costo;
            Contexto.Asignar = new Asignaciones(Nombre,Apellido,Especialidad, Costo);
            Contexto.Hospital.LlenarListaAsignarMedico(Contexto.Asignar);
            
           
        }
    }
}
