using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        Stack<string> file = new Stack<string>();
        int numerofile = 15,maxFile=0;
        String ultimoDato;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumeroPila.Text = (numerofile.ToString());          
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if(txtValor.Text != "" && maxFile !=15)
            {
                file.Push(txtValor.Text);
                ultimoDato = txtValor.Text.ToString();
                maxFile++;
                progressBar1.Value += 1;
                txtValor.Clear();
                MessageBox.Show("Se agrego a la pila: " + ultimoDato);
                txtValor.Focus();
                lbResumen.Items.Add(maxFile+"_" + ultimoDato);
            }
            else if (maxFile == 15 || progressBar1.Value ==15)
            {
                MessageBox.Show("La pila esta llena", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Texto vacio","Advertencia",MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (maxFile != 0)
            {
                file.Pop();
                progressBar1.Value -= 1;          
                MessageBox.Show("Se quito: " + maxFile +"_"+ultimoDato);
                maxFile--;
                lbResumen.Items.RemoveAt(maxFile);
            }
            else
            {
                MessageBox.Show("Pila vacia", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
           
        }
    }
}
