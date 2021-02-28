using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Instituto
{
    public partial class frmRegistro : Form
    {
        frmMenu contexto;
        Int32 edadComprobacion =0;
        public frmRegistro(frmMenu contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSexoAlumno.Items.Add("Hombre");
            cmbSexoAlumno.Items.Add("Mujer");
            lblNumeroLegajo.Text = (contexto.i + 1).ToString();
            timer1.Start();
            for(int j = 0; j < 7; j++)
            {
                cmbCursoAlumno.Items.Add(j + 1);
            }
            rbBecaCompleta.Select();
            
          
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            contexto.Show();
        }

        private void checkBeca()
        {
            if (rbBecaCompleta.Checked)
            {
                contexto.valorBecaCompleta += contexto.valor;
            }
            else if (rbMediaBeca.Checked)
            {
                contexto.valorBecaMedia += contexto.valor;
            }
            else
            {
                contexto.valorBecaRegular += contexto.valor;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                edadComprobacion = Int32.Parse(mskEdadAlumno.Text);
            }
            catch(Exception) { };

            if (cmbSexoAlumno.Text == "" || mskEdadAlumno.Text == "" || mskNombreAlumno.Text == "" || cmbCursoAlumno.Text == "")
            {
                MessageBox.Show("Los datos no estan completos.", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else if (edadComprobacion < 18)
            {
                MessageBox.Show("El alumno debe ser mayor de edad.", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                edadComprobacion = 0;
                contexto.nombreAlumno[contexto.i] = mskNombreAlumno.Text;
                contexto.legajoAlumno[contexto.i] = int.Parse(lblNumeroLegajo.Text);
                contexto.edadAlumno[contexto.i] = Int32.Parse(mskEdadAlumno.Text);
                contexto.totalEdad += contexto.edadAlumno[contexto.i];
                contexto.sexoAlumno[contexto.i] = (cmbSexoAlumno.SelectedItem).ToString();
                contexto.becaAlumno[contexto.i] = (lblValorBeca.Text).ToString();
                checkBeca();
                switch (cmbCursoAlumno.SelectedItem)
                {
                    case 1:
                        contexto.curso1[contexto.i] = int.Parse(lblNumeroLegajo.Text);
                        contexto.totalC1 += contexto.valor;
                        contexto.cantEdadC1++;
                        contexto.cantidadAlumnosC1 -= 1;
                        if (contexto.sexoAlumno[contexto.i] == "Mujer")
                        {
                            contexto.cantMujeresC1++;
                        }
                        break;
                    case 2:
                        contexto.curso2[contexto.i] = int.Parse(lblNumeroLegajo.Text);
                        contexto.totalC2 += contexto.valor;
                        contexto.cantEdadC2++;
                        contexto.cantidadAlumnosC2 -= 1;
                        if (contexto.sexoAlumno[contexto.i] == "Mujer")
                        {
                            contexto.cantMujeresC2++;
                        }
                        break;
                    case 3:
                        contexto.curso3[contexto.i] = int.Parse(lblNumeroLegajo.Text);
                        contexto.totalC3 += contexto.valor;
                        contexto.cantEdadC3++;
                        contexto.cantidadAlumnosC3 -= 1;
                        if (contexto.sexoAlumno[contexto.i] == "Mujer")
                        {
                            contexto.cantMujeresC3++;
                        }
                        break;
                    case 4:
                        contexto.curso4[contexto.i] = int.Parse(lblNumeroLegajo.Text);
                        contexto.totalC4 += contexto.valor;
                        contexto.cantEdadC4++;
                        contexto.cantidadAlumnosC4 -= 1;
                        if (contexto.sexoAlumno[contexto.i] == "Mujer")
                        {
                            contexto.cantMujeresC4++;
                        }
                        break;
                    case 5:
                        contexto.curso5[contexto.i] = int.Parse(lblNumeroLegajo.Text);
                        contexto.totalC5 += contexto.valor;
                        contexto.cantEdadC5++;
                        contexto.cantidadAlumnosC5 -= 1;
                        if (contexto.sexoAlumno[contexto.i] == "Mujer")
                        {
                            contexto.cantMujeresC5++;
                        }
                        break;
                    case 6:
                        contexto.curso6[contexto.i] = int.Parse(lblNumeroLegajo.Text);
                        contexto.totalC6 += contexto.valor;
                        contexto.cantEdadC6++;
                        contexto.cantidadAlumnosC6 -= 1;
                        if (contexto.sexoAlumno[contexto.i] == "Mujer")
                        {
                            contexto.cantMujeresC6++;
                        }
                        break;
                    case 7:
                        contexto.curso7[contexto.i] = int.Parse(lblNumeroLegajo.Text);
                        contexto.totalC7 += contexto.valor;
                        contexto.cantEdadC7++;
                        contexto.cantidadAlumnosC7 -= 1;
                        if (contexto.sexoAlumno[contexto.i] == "Mujer")
                        {
                            contexto.cantMujeresC7++;
                        }
                        break;
                }          
                contexto.i++;
                mskNombreAlumno.Text = mskEdadAlumno.Text = cmbSexoAlumno.Text = "";
                contexto.totalRecaudado += contexto.valor;
                MessageBox.Show("El alumno ha sido registrado correctamente.","Proceso registro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                timer1.Stop();
                this.Close();
                contexto.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongDateString();
        }

        private void rbBecaCompleta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBecaCompleta.Checked)
            {
                contexto.valor = 400;
                lblValorBeca.Text = "$" + (contexto.valor).ToString();
            }
            
        }

        private void rbMediaBeca_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMediaBeca.Checked)
            {
                contexto.valor = 1000;
                lblValorBeca.Text = "$" + (contexto.valor).ToString();
            }
           
        }

        private void rbBecaRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBecaRegular.Checked)
            {
                contexto.valor = 2000;
                lblValorBeca.Text = "$" + (contexto.valor).ToString();
            }
        }
    }
}