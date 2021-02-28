using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Café
{
    public partial class Cafeteria : Form
    {
        Starbucks cafeteria = new Starbucks();

        public Cafeteria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//generar maquina
        {
            if (cafeteria.contador < 6)
            {
                cafeteria.Maquina[cafeteria.contador] = new MaquinaCafe();
                cafeteria.Maquina[cafeteria.contador]._Capacidad = cafeteria.Maquina[cafeteria.contador]._CapacidadRestante = int.Parse(txtCapacidad.Text);
                cafeteria.Maquina[cafeteria.contador]._NombreMaquina = "Maquina" + " " + (cafeteria.contador + 1).ToString();

                if (rbArabigo.Checked)
                {
                    cafeteria.Maquina[cafeteria.contador]._TipoCafe = "Arabigo";
                    cafeteria.Maquina[cafeteria.contador]._PrecioCafe = 50f;
                }
                else
                {
                    cafeteria.Maquina[cafeteria.contador]._TipoCafe = "Robusto";
                    cafeteria.Maquina[cafeteria.contador]._PrecioCafe = 58f;
                }
            
                lbMaquinas.Items.Add(cafeteria.Maquina[cafeteria.contador]._NombreMaquina);
                txtCapacidad.Text = 0.ToString();
                cafeteria.contador++;
            }
            else
            {
                MessageBox.Show("Starbucks lleno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void Cafeteria_Load(object sender, EventArgs e)
        {
            rbArabigo.Select();
            txtCapacidad.Text = 0.ToString();

        }

        private void lbMaquinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbMaquinas.Items.Count > 0)
            {
                cmbTipoVaso.Items.Clear();
                lblPrecioxLt.Text = "$" +cafeteria.Maquina[lbMaquinas.SelectedIndex]._PrecioCafe.ToString();
                lblTipoCafe.Text = cafeteria.Maquina[lbMaquinas.SelectedIndex]._TipoCafe;
                lblCapacidad.Text = cafeteria.Maquina[lbMaquinas.SelectedIndex]._CapacidadRestante.ToString()+"Lt";
                lblTotalMaquina.Text = "$"+cafeteria.Maquina[lbMaquinas.SelectedIndex]._Total.ToString();
                txtTipoCafe.Text = cafeteria.Maquina[lbMaquinas.SelectedIndex]._TipoCafe;
                cmbTipoVaso.Items.Add("Chico");
                cmbTipoVaso.Items.Add("Mediano");
                cmbTipoVaso.Items.Add("Grande");
            }
        }

        private void cmbTipoVaso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbMaquinas.SelectedItem != null)
            {
                if (cmbTipoVaso.SelectedItem.Equals("Chico"))
                {
                    cafeteria.Maquina[lbMaquinas.SelectedIndex].vaso._TipoVaso = "Chico";
                    lblTamañoVaso.Text = (cafeteria.Maquina[lbMaquinas.SelectedIndex].vaso._TamañoVaso = 0.05f).ToString() + "Lt";

                }
                else if (cmbTipoVaso.SelectedItem.Equals("Mediano"))
                {
                    cafeteria.Maquina[lbMaquinas.SelectedIndex].vaso._TipoVaso = "Mediano";
                    lblTamañoVaso.Text = (cafeteria.Maquina[lbMaquinas.SelectedIndex].vaso._TamañoVaso = 0.1f).ToString() + "Lt";
                }
                else
                {
                    cafeteria.Maquina[lbMaquinas.SelectedIndex].vaso._TipoVaso = "Grande";
                    lblTamañoVaso.Text = (cafeteria.Maquina[lbMaquinas.SelectedIndex].vaso._TamañoVaso = 0.25f).ToString() + "Lt";
                }
            }
            
        }

        private void btnComprarCafe_Click(object sender, EventArgs e)
        {
            if(lbMaquinas.SelectedItem != null && cmbTipoVaso.SelectedItem != null)
            {
                if(cafeteria.Maquina[lbMaquinas.SelectedIndex]._CapacidadRestante > cafeteria.Maquina[lbMaquinas.SelectedIndex].vaso._TamañoVaso)
                {
                    MessageBox.Show("Compra efectuada." + Environment.NewLine + "Total:" + "$"+cafeteria.Maquina[lbMaquinas.SelectedIndex].comprarCafe() + Environment.NewLine +
                        "Disfrute su café.");
                    lblCapacidad.Text = cafeteria.Maquina[lbMaquinas.SelectedIndex]._CapacidadRestante.ToString()+"Lt";
                    lblTotalMaquina.Text = "$"+cafeteria.Maquina[lbMaquinas.SelectedIndex]._Total.ToString();
                }
                else
                {
                    MessageBox.Show("La maquina no tiene mas capacidad. Recargue.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una maquina y/o tipo de vaso.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(lbMaquinas.SelectedItem != null)
            {
                lblCapacidad.Text = cafeteria.Maquina[lbMaquinas.SelectedIndex].recargarMaquina().ToString() +"Lt";
            }
            else
            {
                MessageBox.Show("Debe seleccionar una maquina.");
            }
        }

        private void resumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resumen ventana = new Resumen(cafeteria);
            ventana.Show();
        }
    }
}
