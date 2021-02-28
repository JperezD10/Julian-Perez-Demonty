using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tele2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TELE t = new TELE();

        int Conteo=0;

        private void Form1_Load(object sender, EventArgs e)
        {
            t.ESTADO = false;
            LblApagado.Visible = true;
            LblEncendido.Visible = false;
            BtnCanMas.Visible = false;
            BtnCanMenos.Visible = false;
            BtnVolMas.Visible = false;
            BtnVolMenos.Visible = false;
            LblVol.Visible = false;
            LblCanales.Visible = false;
            BtnIr.Visible = false;
            Txtinternet.Visible = false;
            BtnSalir.Visible = false;

            TxtCanal.Visible = TxtVolumen.Visible = false;
            btnokcanal.Visible = false;
            btnokvol.Visible = false;
            Barra1.Visible = false;
            Barra2.Visible = false;
            Barra3.Visible = false;
            Barra4.Visible = false;
            Barra5.Visible = false;
            t.CANAL = 1;
            BtnMarca.Visible = false;
        }

        private void BtnEncendido_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
            t.encendido();
            if (t.ESTADO == false)
            {
                timer1.Enabled = false;
                LblApagado.Visible = true;
                LblEncendido.Visible = false;
                 LblApagado.Visible = true;
                BtnCanMas.Visible = false;
                BtnCanMenos.Visible = false;
                BtnVolMas.Visible = false;
                BtnVolMenos.Visible = false;
                LblVol.Visible = false;
                LblCanales.Visible = false;
                BtnIr.Visible = false;
                Txtinternet.Visible = false;
                BtnSalir.Visible = false;
                BtnMarca.Visible = false;
                TxtCanal.Visible = TxtVolumen.Visible = false;
                btnokcanal.Visible = false;
                btnokvol.Visible = false;
            }
            else 
            {
                timer1.Enabled = true;
                LblApagado.Visible = false;
                
                LblApagado.Visible = false;
                
                BtnCanMas.Visible = true;
                BtnCanMenos.Visible = true;
                BtnVolMas.Visible = true;
                BtnVolMenos.Visible = true;
                LblVol.Visible = true;
                LblCanales.Visible = true;
                BtnIr.Visible = true;
                Txtinternet.Visible = true;
                BtnSalir.Visible = true;
                Barra1.Visible = true;
                BtnMarca.Visible = true;
                TxtCanal.Visible = TxtVolumen.Visible = true;
                btnokcanal.Visible = true;
                btnokvol.Visible = true;



                
            }
        }
        
        private void BtnCanMas_Click(object sender, EventArgs e)
        {
            t.canalmasomenos = true;
            t.canales();
            TxtCanal.Text = t.CANAL.ToString();
            LblCanales.Text = t.CANAL.ToString();

        }

        private void BtnCanMenos_Click(object sender, EventArgs e)
        {
            t.canalmasomenos = false;
            t.canales();
            TxtCanal.Text = t.CANAL.ToString();
            LblCanales.Text = t.CANAL.ToString();
        }

        private void BtnVolMas_Click(object sender, EventArgs e)
        {
            t.Volmasomenos = true;
            t.Volumen();
            TxtVolumen.Text = t.VOLUMEN.ToString();
            LblVol.Text = t.VOLUMEN.ToString();
            if (t.VOLUMEN <10)
            {
                Barra1.Visible = true;
            }

            else if (t.VOLUMEN <=20)
            {
                Barra2.Visible = true;
            }
            else if (t.VOLUMEN <= 30)
            {
                Barra3.Visible = true;
            }
            else if (t.VOLUMEN <= 40)
            {
                Barra4.Visible = true;
            }
            else 
            {
                Barra5.Visible = true;
            }

        }

        private void BtnVolMenos_Click(object sender, EventArgs e)
        {
            t.Volmasomenos = false;
            t.Volumen();
            TxtVolumen.Text = t.VOLUMEN.ToString();
            LblVol.Text = t.VOLUMEN.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            webBrowser1.Navigate(t.url_());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
        }

        private void BtnIr_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Txtinternet.Text);
        }

        private void BtnMarca_Click(object sender, EventArgs e)
        {
            MessageBox.Show(t.Marcaa());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Conteo++;
          
            if ((Conteo % 2) == 0)
            {
                LblEncendido.Visible = true;
            }
            else
            {
                LblEncendido.Visible = false;
            }
        }

        private void btnokcanal_Click(object sender, EventArgs e)
        {

        }
    }
}
