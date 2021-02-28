using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool [] asientosalta = new bool[20];
        bool[] asientosBaja = new bool[25];
        int[] total = new int[2];
        int cantidadBaja = 25;
        int cantidadAlta = 20;
        private void Form1_Load(object sender, EventArgs e)
        {
            rbAlta.Checked=true;
            label4.Text = "3000";
            inicializar();
            
        }
        void inicializar()
        {
            for(int i=0; i<asientosalta.Length; i++)
            {
                asientosalta[i] = false;
            }
            for (int i = 0; i < asientosBaja.Length; i++)
            {
                asientosBaja[i] = false;
            }
        }
        void llenarcomboAlta()
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < asientosalta.Length; i++)
            {
                if (asientosalta[i] != true)
                {
                    comboBox1.Items.Add(i + 1);
                }
            }
        }
        void LlenarcomboBaja()
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < asientosBaja.Length; i++)
            {
                if (asientosBaja[i] != true)
                {
                    comboBox1.Items.Add(i + 1);
                }
            }
        }
        private void rbAlta_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "3000";
            llenarcomboAlta();
        }

        private void rbBaja_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "2500";
            LlenarcomboBaja();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbAlta.Checked)
            {
                if (comboBox1.Items.Count>=1)
                {
                    asientosalta[int.Parse(comboBox1.Text)-1] = true;
                    int posicionalta = int.Parse(comboBox1.Text) +1 ;
                    llenarcomboAlta();
                    total[0] += int.Parse(label4.Text);
                    comboBox1.Text = posicionalta.ToString();
                    lbltotalalta.Text = total[0].ToString();
                }
                else
                {
                    MessageBox.Show("planta llena");
                }
               
            }
            else
            {
                if (comboBox1.Items.Count > 0)
                {
                    asientosBaja[comboBox1.SelectedIndex] = true;
                    LlenarcomboBaja();
                    total[1] += int.Parse(label4.Text);
                    int posicionbaja = int.Parse(comboBox1.SelectedIndex.ToString()) + 1;
                    comboBox1.SelectedIndex = posicionbaja;
                    lbltotalbaja.Text = total[1].ToString();
                }
                else
                {
                    MessageBox.Show("planta llena");
                } 
            }
            
        }
    }
}
