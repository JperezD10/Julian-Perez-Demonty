using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vectores
{
    public partial class Form1 : Form
    {
        int valor=0, resultado=0;
        public Form1()
        {
            InitializeComponent();
        }
        int[] vector = new int[26];
        int[] numero = new int[26];
        int i, contador = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cbasiento.SelectedItem.ToString()) >= 0 && int.Parse(cbasiento.SelectedItem.ToString()) <= 15)
            {
                txtvalor.Text = "50";
            }
            else
            {
                txtvalor.Text = "25";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (i = 1; i <= 25; i++) { 
                if(vector[i] == 0)
                {
                cbasiento.Items.Add(i);
                if (vector[i] == 1)
                {
                        contador++;
                }
                }
            }
            cbasiento.SelectedIndex = 1;
            txtdisponible.Text = (25 - contador).ToString();
            txtvendido.Text = contador.ToString();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 25;
            progressBar1.Value = contador;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btvender_Click(object sender, EventArgs e)
        {

            contador++;
           // vector[cbasiento.SelectedIndex] = 1;
            cbasiento.Items.Remove(cbasiento.SelectedIndex+contador);

            //contador++;
            try {
                cbasiento.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Se ha vendido todo");
            }
            txtdisponible.Text = (25 - contador).ToString();
            txtvendido.Text = contador.ToString();
            progressBar1.Value = contador;
            resultado +=valor = (int.Parse(txtvalor.Text));
            txtresultado.Text = resultado.ToString();
            

        }
    }
}
