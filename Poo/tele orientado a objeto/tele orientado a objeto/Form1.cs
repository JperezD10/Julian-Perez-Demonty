using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tele_orientado_a_objeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SMART tv = new SMART();
        private void Form1_Load(object sender, EventArgs e)
        {
            tv.ESTADO = true;
            txtcanal.ReadOnly = txtvolumen.ReadOnly = true;
            btbvolumen.Enabled = btsvolumen.Enabled = btscanal.Enabled = btbcanal.Enabled = false;
            tv.CANAL = 10;
            tv.VOLUMEN = 3;
            pctelevisor.Image = tele_orientado_a_objeto.Properties.Resources.haier_c800;
        }

        private void btEncendido_Click(object sender, EventArgs e)
        {
            tv.encendido();
            if (tv.ESTADO == false)
            {
                btEncendido.Text = "Apagar";
                txtcanal.Text = tv.CANAL.ToString();
                txtvolumen.Text = tv.VOLUMEN.ToString();
                txtcanal.ReadOnly = txtvolumen.ReadOnly = false;
                btbvolumen.Enabled = btsvolumen.Enabled = btscanal.Enabled = btbcanal.Enabled = true;
               pctelevisor.Image = tele_orientado_a_objeto.Properties.Resources.descarga;
            }
            else
            {
                btEncendido.Text = "Encender";
                txtcanal.Text = txtvolumen.Text = "";
                txtcanal.ReadOnly = txtvolumen.ReadOnly = true;
                pctelevisor.Image = tele_orientado_a_objeto.Properties.Resources.haier_c800;
                btbvolumen.Enabled = btsvolumen.Enabled = btscanal.Enabled = btbcanal.Enabled = false;
            }
        }

        private void btscanal_Click(object sender, EventArgs e) //canal para arriba
        {
            tv.CambioCanal = true;
            tv.Canal();
            txtcanal.Text = tv.CANAL.ToString();
        }

        private void btbcanal_Click(object sender, EventArgs e) //canal para abajo
        {
            tv.CambioCanal = false;
            tv.Canal();
            txtcanal.Text = tv.CANAL.ToString();
        }

        private void btsvolumen_Click(object sender, EventArgs e)
        {
            tv.CambiarVolumen = true;
           
            if (tv.VOLUMEN==50)
            {
                MessageBox.Show("sonido alto");
            }
            else
            {
                 tv.Volumen();
            }
            txtvolumen.Text = tv.VOLUMEN.ToString();
        }

        private void btbvolumen_Click(object sender, EventArgs e)
        {
            tv.CambiarVolumen = false;

            if (tv.VOLUMEN == 0)
            {
                MessageBox.Show("sonido bajo");
            }
            else
            {
                tv.Volumen();
            }
            txtvolumen.Text = tv.VOLUMEN.ToString();
        }
    }
}
