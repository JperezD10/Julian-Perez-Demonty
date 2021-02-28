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
    public partial class Inscribir_Alumno : Form
    {
        Form1 Contexto;
        public Inscribir_Alumno(Form1 Contexto)
        {
            InitializeComponent();
            this.Contexto = Contexto;
        }

        void LlenarComboSalas()
        {
            foreach (Salas S in Contexto.Jardines.Salitas)
            {
                CmbSalas.Items.Add(S.Nombre);
            }
        }

        private void Inscribir_Alumno_Load(object sender, EventArgs e)
        {
            LlenarComboSalas();
            LblNroInscripcion.Text = Inscripcion.NumeroInscripcion.ToString();
            NupDEdad.Maximum = 36;
            NupDEdad.Minimum = 0;
        }



        private void BtnInscribir_Click(object sender, EventArgs e)
        {
             int Numero = Contexto.Jardines.CalcularSalon(int.Parse(NupDEdad.Text));

            if (Contexto.Jardines.Salitas[Numero].CantAlumnos+1 <= Contexto.Jardines.Salitas[Numero].Cupo)
            {
                string Turno="";
                bool Comedor,Hermanos;

                if (RbtnSi.Checked == true)
                {
                    Comedor = true;
                }
                else
                {
                    Comedor = false;
                }
                if (checkBoxMañana.Checked == true)
                {
                    Turno = "Mañana";
                }
                if(checkBoxTarde.Checked == true)
                {
                    Turno = "Tarde";
                }
                if(checkBoxMañana.Checked == true && checkBoxTarde.Checked == true)
                {
                    Turno = "Doble Jornada";
                }
                if (RbtnSiHermanos.Checked == true)
                {
                    Hermanos = true; 
                }
                else
                {
                    Hermanos = false;
                }
                Contexto.Inscripciones = new Inscripcion(TxtNombre.Text, TxtApellido.Text, int.Parse(NupDEdad.Text), Turno, Comedor,Hermanos);
                Contexto.Jardines.Salitas[Numero].Inscriptos.Add(Contexto.Inscripciones);
                Contexto.Jardines.Salitas[Numero].CantAlumnos++;

                Turno = "";
                TxtApellido.Enabled = NupDEdad.Enabled = groupBox1.Enabled = groupBox2.Enabled = groupBox3.Enabled= false;
                TxtApellido.Text = "";
                NupDEdad.Value = 0;
                CmbSalas.Text = "";
                Contexto.Inscripciones.Disponible += SalonDisponible;
                Contexto.Inscripciones.Lleno += SalonLleno;
                Contexto.Inscripciones.Evento(1);
            }
            else
            {
                Contexto.Inscripciones.Lleno += SalonLleno;
                Contexto.Inscripciones.Evento(2);
            }
        }

        private void SalonLleno(string Mensaje)
        {
            MessageBox.Show(Mensaje);
        }

        private void SalonDisponible(string Mensaje,int Num)
        {
            MessageBox.Show(Mensaje + "" + Num);
        }




     
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*          */
         
       private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            TxtApellido.Enabled = true;
        }

        private void CmbSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtNombre.Enabled = true;
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            NupDEdad.Enabled = true;
        }

        private void NupDEdad_ValueChanged(object sender, EventArgs e)
        {
            if (int.Parse(NupDEdad.Text) <= 9)
            {
                CmbSalas.Text = "Lactarios";
            }
            else if (int.Parse(NupDEdad.Text) > 9 && int.Parse(NupDEdad.Text) <= 16)
            {
                CmbSalas.Text = "Deambuladores"; ;
            }
            else if (int.Parse(NupDEdad.Text) > 16 && int.Parse(NupDEdad.Text) <= 24)
            {
                CmbSalas.Text = "Deambuladores II"; ;
            }
            else if (int.Parse(NupDEdad.Text) == 24)
            {
                CmbSalas.Text = "Sala de 2"; ;
            }
            else
            {
                CmbSalas.Text = "Sala de 3"; ;
            }
            groupBox1.Enabled = true;
        }

        private void RbtnSi_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
        }

        private void RBtnNo_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadTexto.SoloLetras(e);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidadTexto.SoloLetras(e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void RbtnSiHermanos_CheckedChanged(object sender, EventArgs e)
        {
            BtnInscribir.Enabled = true;
        }

        private void RbtnNoHermanos_CheckedChanged(object sender, EventArgs e)
        {
            BtnInscribir.Enabled = true;
        }
    }
}
