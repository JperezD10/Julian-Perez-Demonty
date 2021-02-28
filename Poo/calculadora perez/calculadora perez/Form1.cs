using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_perez
{
    public partial class Form1 : Form
    {
        int a, b, resultado;
        string tipo;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            txtvista.Text += "0";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            txtvista.Text += "2";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtvista.Text += "1";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtvista.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txtvista.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txtvista.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txtvista.Text += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txtvista.Text += "7";
        }
        void operacion()
        {
            a = int.Parse(txtvista.Text);
            txtvista.Clear();
        }
        private void btsuma_Click(object sender, EventArgs e)
        {
            operacion();
            tipo = "+";
        }

        private void btresta_Click(object sender, EventArgs e)
        {
            operacion();
            tipo = "-";
        }

        private void btmultiplicacion_Click(object sender, EventArgs e)
        {
            operacion();
            tipo = "*";
        }

        private void btdivision_Click(object sender, EventArgs e)
        {
            operacion();
            tipo = "/";
        }

        private void btigual_Click(object sender, EventArgs e)
        {
            b = int.Parse(txtvista.Text);
            condicion();
            txtvista.Text = resultado.ToString();
            a = resultado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txtvista.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txtvista.Text += "9";
        }
        int suma()
        {
            resultado = a + b;
            return resultado;
        }
        int resta()
        {
            resultado = a - b;
            return resultado;
        }
        int division()
        {
            
                resultado = a / b;
            return resultado;
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            txtvista.Text = "0";
        }

        int multiplicacion()
        {
            resultado = a * b;
            return resultado;
        }
        void condicion()
        {
            switch (tipo)
            {
                case "+":
                    suma();
                    break;
                case "-":
                    resta();
                    break;
                case "*":
                    multiplicacion();
                    break;
                case "/":
                    if (b != 0)
                    {
                        division();
                    }
                    else
                    {
                        MessageBox.Show("no se divide por 0 burro");
                    }
                    break;
            }
        }
    }
}
