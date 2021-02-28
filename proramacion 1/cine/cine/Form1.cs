using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] fila1 = new int[5];
        int[] fila2 = new int[5];
        int[] fila3 = new int[5];
        int[] fila4 = new int[5];
        int[] fila5 = new int[5];
        int[] valorf1 = new int[5];
        int[] valorf2 = new int[5];
        int[] valorf3 = new int[5];
        int[] valorf4 = new int[5];
        int[] valorf5 = new int[5];
        int i, contadorocupados = 0, asientosdisponibles, total = 0;

        private void btvender_Click(object sender, EventArgs e)
        {
            if (cbcolumna.Text == "-")
            {
                MessageBox.Show("Asiento vendido", "Error");
                contadorocupados -= 1;
                asientosdisponibles += 1;
                progressBar1.Value -= 1;
                
            }
            contadorocupados += 1;
            asientosdisponibles -= 1;
            total += (int.Parse(txtvalor.Text));
            txttotal.Text = (total.ToString());
            txtdisponible.Text = (asientosdisponibles.ToString());
            txtocupado.Text = (contadorocupados.ToString());
            progressBar1.Value += 1;
            if (progressBar1.Value == 25)
            {
                MessageBox.Show("Se han vendido todos los asientos", "Error");
            }
            switch (cbfila.SelectedIndex)
            {
                case 0:
                    valorf1[cbcolumna.SelectedIndex] = 0;
                    switch (cbcolumna.SelectedIndex)
                    {
                        case 0:
                            textBox1.BackColor = Color.Red;
                            break;
                        case 1:
                            textBox2.BackColor = Color.Red;
                            break;
                        case 2:
                            textBox3.BackColor = Color.Red;
                            break;
                        case 3:
                            textBox4.BackColor = Color.Red;
                            break;
                        case 4:
                            textBox5.BackColor = Color.Red;
                            break;
                    }
                    cbcolumna.Items.Remove(fila1[cbcolumna.SelectedIndex]);
                    break;
                case 1:
                    valorf2[cbcolumna.SelectedIndex] = 0;
                    switch (cbcolumna.SelectedIndex)
                    {
                        case 0:
                            textBox6.BackColor = Color.Red;
                            break;
                        case 1:
                            textBox7.BackColor = Color.Red;
                            break;
                        case 2:
                            textBox8.BackColor = Color.Red;
                            break;
                        case 3:
                            textBox9.BackColor = Color.Red;
                            break;
                        case 4:
                            textBox10.BackColor = Color.Red;
                            break;
                    }
                    cbcolumna.Items.Remove(fila2[cbcolumna.SelectedIndex]);
                    break;
                case 2:
                    valorf3[cbcolumna.SelectedIndex] = 0;
                    switch (cbcolumna.SelectedIndex)
                    {
                        case 0:
                            textBox11.BackColor = Color.Red;
                            break;
                        case 1:
                            textBox12.BackColor = Color.Red;
                            break;
                        case 2:
                            textBox13.BackColor = Color.Red;
                            break;
                        case 3:
                            textBox14.BackColor = Color.Red;
                            break;
                        case 4:
                            textBox15.BackColor = Color.Red;
                            break;
                    }
                    cbcolumna.Items.Remove(fila3[cbcolumna.SelectedIndex]);
                    break;
                case 3:
                    valorf4[cbcolumna.SelectedIndex] = 0;
                    switch (cbcolumna.SelectedIndex)
                    {
                        case 0:
                            textBox16.BackColor = Color.Red;
                            break;
                        case 1:
                            textBox17.BackColor = Color.Red;
                            break;
                        case 2:
                            textBox18.BackColor = Color.Red;
                            break;
                        case 3:
                            textBox19.BackColor = Color.Red;
                            break;
                        case 4:
                            textBox20.BackColor = Color.Red;
                            break;
                    }
                    cbcolumna.Items.Remove(fila4[cbcolumna.SelectedIndex]);
                    break;
                case 4:
                    valorf5[cbcolumna.SelectedIndex] = 0;
                    switch (cbcolumna.SelectedIndex)
                    {
                        case 0:
                            textBox21.BackColor = Color.Red;
                            break;
                        case 1:
                            textBox22.BackColor = Color.Red;
                            break;
                        case 2:
                            textBox23.BackColor = Color.Red;
                            break;
                        case 3:
                            textBox24.BackColor = Color.Red;
                            break;
                        case 4:
                            textBox25.BackColor = Color.Red;
                            break;
                    }
                    cbcolumna.Items.Remove(fila5[cbcolumna.SelectedIndex]);
                    break;
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbcolumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbfila.SelectedIndex == 0)
            {
                txtvalor.Text = (valorf1[cbcolumna.SelectedIndex].ToString());
            }
            else if (cbfila.SelectedIndex == 1)
            {
                txtvalor.Text = (valorf2[cbcolumna.SelectedIndex].ToString());
            }
            else if (cbfila.SelectedIndex == 2)
            {
                txtvalor.Text = (valorf3[cbcolumna.SelectedIndex].ToString());
            }
            else if (cbfila.SelectedIndex == 3)
            {
                txtvalor.Text = (valorf4[cbcolumna.SelectedIndex].ToString());
            }
            else if (cbfila.SelectedIndex == 4)
            {
                txtvalor.Text = (valorf5[cbcolumna.SelectedIndex].ToString());
            }
        }

        private void cbfila_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i=0 ; i < 5; i++)
            {
                if (cbfila.SelectedIndex == 0)
                {
                    if (valorf1[i] != 0)
                    {
                        cbcolumna.Items.Add(fila1[i]);

                    }
                    else
                    {
                        cbcolumna.Items.Add("-");
                    }
                }
                else if (cbfila.SelectedIndex == 1)
                {
                    if (valorf2[i] != 0)
                    {
                        cbcolumna.Items.Add(fila2[i]);
                    }
                    else
                    {
                        cbcolumna.Items.Add("-");
                    }
                }
                else if (cbfila.SelectedIndex == 2)
                {
                    if (valorf3[i] != 0)
                    {
                        cbcolumna.Items.Add(fila3[i]);
                    }
                    else
                    {
                        cbcolumna.Items.Add("-");
                    }
                }
                else if (cbfila.SelectedIndex == 3)
                {
                    if (valorf4[i] != 0)
                    {
                        cbcolumna.Items.Add(fila4[i]);
                    }
                    else
                    {
                        cbcolumna.Items.Add("-");
                    }
                }
                else if (cbfila.SelectedIndex == 4)
                {
                    if (valorf5[i] != 0)
                    {
                        cbcolumna.Items.Add(fila5[i]);
                    }
                    else
                    {
                        cbcolumna.Items.Add("-");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (i = 0; i < 5; i++)
            {
                fila1[i] = i + 1;
                fila2[i] = i + 1;
                fila3[i] = i + 1;
                fila4[i] = i + 1;
                fila5[i] = i + 1;
                valorf1[i] = 200;
                valorf2[i] = 200;
                valorf3[i] = 200;
                valorf4[i] = 200;
                valorf5[i] = 200;
                cbfila.Items.Add(i + 1);

            }
            cbcolumna.SelectedIndex = cbfila.SelectedIndex = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 25;
            asientosdisponibles = 25;
            txtdisponible.Text = (asientosdisponibles.ToString());
            txtocupado.Text = (contadorocupados.ToString());
            txttotal.Text = (total.ToString());
        }
    }
}
