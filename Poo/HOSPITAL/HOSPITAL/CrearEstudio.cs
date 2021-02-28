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
    public partial class CrearEstudio : Form
    {
        Form1 Contexto;
        public CrearEstudio(Form1 Contexto)
        {
            InitializeComponent();
            this.Contexto = Contexto;
        }


        private void CrearEstudio_Load(object sender, EventArgs e)
        {
            lblNumero.Text = Estudios.Numero.ToString();
            LlenarComboEstudios();
            LlenarComboPacientes();
        }

        void LlenarComboEstudios()
        {
            foreach (Especialidades F in Contexto.Hospital.Especialidad)
            {
                CmbEspecializacion.Items.Add(F.NombreEspecialdidad);
            }
        }

        void LlenarComboPacientes()
        {
            foreach (Pacientes P in Contexto.Hospital.Paciente)
            {
                CmbPaciente.Items.Add(P.Nombre + P.Apellido);
            }
        }



        private void BtnCrear_Click(object sender, EventArgs e)
        {

           
            bool Firma;
            string Nombre,Apellido,NombreDoctor="";
            double Costo;
            if (CBfIRMA.Checked)
            {
                Firma = true;
            }
            else
            {
                Firma = false;

            }

            Nombre = Contexto.Hospital.Paciente[CmbPaciente.SelectedIndex].Nombre;
            Apellido = Contexto.Hospital.Paciente[CmbPaciente.SelectedIndex].Apellido;
            Costo = Contexto.Hospital.AsignarMedico[CmbEspecializacion.SelectedIndex].Costo;
            Contexto.Estudio = new Estudios(Nombre,Apellido,CmbEspecializacion.Text,CmbMedico.Text,TxtReceta.Text,Firma,Costo,int.Parse(TxtFecha.Text));

            if (CBfIRMA.Checked == true)
            {
                Contexto.Hospital.Especialidad[CmbEspecializacion.SelectedIndex].Estudio.Add(Contexto.Estudio);
                Contexto.Hospital.Especialidad[CmbEspecializacion.SelectedIndex].CalcularTotal();
                Contexto.Estudio.FirmaOk += FirmaOk;
                Contexto.Estudio.Evento(1);
            }
            else
            {
                Contexto.Estudio.FaltaFirma+=FaltaFirma;
                Contexto.Estudio.Evento(0);
            }
            

        }

        private void FaltaFirma(string Mensaje)
        {
            MessageBox.Show(Mensaje);

        }
        private void FirmaOk(string Mensaje)
        {
            MessageBox.Show(Mensaje);
        }


        private void CBfIRMA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CmbEspecializacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbMedico.Items.Clear();

            for(int i=0;i < Contexto.Hospital.AsignarMedico.Count; i++)
            {
                if (CmbEspecializacion.Text == Contexto.Hospital.AsignarMedico[i].NombreEspecialdidad)
                {
                  CmbMedico.Items.Add(Contexto.Hospital.AsignarMedico[i].Nombre + Contexto.Hospital.AsignarMedico[i].Apellido);

                }
            }                                                 
            
        }
    }
}
