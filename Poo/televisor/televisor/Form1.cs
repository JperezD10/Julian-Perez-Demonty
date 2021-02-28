using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace televisor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int volumen, canal, canalant, volumant;

        private void Form1_Load(object sender, EventArgs e)
        {
            canalant = 30;
            pictureBox1.Image = televisor.Properties.Resources.lg_tv_televisor_no_enciende_9999;
            btbvolumen.Enabled = btsvolumen.Enabled = btscanal.Enabled = btbcanal.Enabled = false;
        }
        
        private void btEncendido_Click(object sender, EventArgs e)
        {
            if (btEncendido.Text == "Encender")
            {
                btEncendido.Text = "Apagar";
                txtcanal.Text = txtvolumen.Text = "30";
                txtcanal.ReadOnly = txtvolumen.ReadOnly = false;
                btbvolumen.Enabled = btsvolumen.Enabled = btscanal.Enabled = btbcanal.Enabled = true;
                pictureBox1.Image = televisor.Properties.Resources.Sony_kdl_46ex521_presentacionbuena1;
            }
            else
            {
                btEncendido.Text = "Encender";
                txtcanal.ReadOnly = txtvolumen.ReadOnly = true;
                txtcanal.Text = txtvolumen.Text = "";
                pictureBox1.Image = televisor.Properties.Resources.lg_tv_televisor_no_enciende_9999;
                btbvolumen.Enabled = btsvolumen.Enabled = btscanal.Enabled = btbcanal.Enabled = false;
            }
        }

        private void btbcanal_Click(object sender, EventArgs e)
        {
            canal = int.Parse(txtcanal.Text);
            if (canal == 0)
            {
                canal = 99;
            }
            else
            {
                canal--;
            }
            
            txtcanal.Text = canal.ToString();
            canalant = int.Parse(txtcanal.Text);
        }

        private void btsvolumen_Click(object sender, EventArgs e)
        {
            if (volumen == 50)
            {
                MessageBox.Show("volumen al mango");
            }
            
            else if (volumen == 40)
            {
                MessageBox.Show("ojo con el volumen alto");
                volumen = int.Parse(txtvolumen.Text);
                volumen++;
            }
            else
            {
                volumen = int.Parse(txtvolumen.Text);
                volumen++;
            }
                
            txtvolumen.Text = volumen.ToString();
        }

        private void btbvolumen_Click(object sender, EventArgs e)
        {
            volumen = int.Parse(txtvolumen.Text);
            if (volumen == 0)
            {
                MessageBox.Show("no se puede bajar mas");
            }
            else
            {
            volumen--;
            txtvolumen.Text = volumen.ToString();
            }
        }

        private void txtcanal_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((int)e.KeyChar==(int)Keys.Enter)
            {
                if(int.Parse(txtcanal.Text)<=99 && int.Parse(txtcanal.Text) > 0)
                {
                txtcanal.Text = canalant.ToString();
                    canalant = int.Parse(txtcanal.Text);
                }
                else
                {
                MessageBox.Show("error de canal");
                    txtcanal.Text = canalant.ToString();
                }
            } 
            
        }

        private void btscanal_Click(object sender, EventArgs e)
        {
            canal = int.Parse(txtcanal.Text);
            if (canal == 99)
            {
                canal = 0;
            }
            else
            {
                canal++;
            }
            txtcanal.Text = canal.ToString();
            canalant= int.Parse(txtcanal.Text);
        }
        
    }
}
