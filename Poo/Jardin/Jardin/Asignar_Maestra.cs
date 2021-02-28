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

namespace Jardin
{
    public partial class Asignar_Maestra : Form
    {
        Form1 Contexto;
        public Asignar_Maestra(Form1 Contexto)
        {
            InitializeComponent();
            this.Contexto = Contexto;
        }

        private void Asignar_Maestra_Load(object sender, EventArgs e)
        {
            LlenarComboSalas();
            LblLegajo.Text = Maestra.NroLegajo.ToString();
        }

        void LlenarComboSalas()
        {
            foreach(Salas S in Contexto.Jardines.Salitas)
            {
                CmbSalas.Items.Add(S.Nombre);
            }
        }

        private void BtnAsignar_Click(object sender, EventArgs e)
        {
            bool Estado;


            if(Contexto.Jardines.Salitas[CmbSalas.SelectedIndex].CantMaestras+1 <= Contexto.Jardines.Salitas[CmbSalas.SelectedIndex].CupoMaestras)
            {
                if (RbtnSi.Checked == true)
                {
                    Estado = true;
                }
                else
                {
                    Estado = false;
                }
                Contexto.Maestras = new Maestra(TxtNombre.Text, TxtApellido.Text,Estado);
                Contexto.Jardines.Salitas[CmbSalas.SelectedIndex].Maestras.Add(Contexto.Maestras);
                Contexto.Jardines.Salitas[CmbSalas.SelectedIndex].CantMaestras++;
                LblLegajo.Text = Maestra.NroLegajo.ToString();
                TxtApellido.Enabled = TxtNombre.Enabled = BtnAsignar.Enabled = false;
                TxtApellido.Text = TxtNombre.Text = "";
            }
            else
            {
                MessageBox.Show("Cupo Lleno...");
            }
               




        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadTexto.SoloLetras(e);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadTexto.SoloLetras(e);
        }

        private void CmbSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtNombre.Enabled = true;
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            TxtApellido.Enabled = true;
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RbtnSi_CheckedChanged(object sender, EventArgs e)
        {
            BtnAsignar.Enabled = true;
        }

        private void RBtnNo_CheckedChanged(object sender, EventArgs e)
        {
            BtnAsignar.Enabled = true;
        }
    }
}
