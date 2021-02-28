using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duff
{
    public partial class Form1 : Form
    {
        Duff duff;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            duff = new Duff();
            llenarComboBarril();
            llenarTipoVaso();
            llenarTipoCerveza();
        }

        private void llenarComboBarril()
        {
           
            cmbSeleccionarBarril.Items.Clear();
            for(int j = 0;j<duff.barriles.Count;j++)
            {
                cmbSeleccionarBarril.Items.Add(j+1 + " - " + duff.barriles[j].cerveza.getNombre());
            }
        }

        private void llenarTipoVaso()
        {
            
            foreach(Vaso vaso in duff.vasos)
            {
                cmbTipoVaso.Items.Add(vaso.getNombre());
            }
        }

        private void llenarTipoCerveza()
        {
            foreach(Cerveza cerveza in duff.cervezas)
            {
                cmbGenerarTipoCerveza.Items.Add(cerveza.getNombre());
            }
        }

        private void btnGenerarBarril_Click(object sender, EventArgs e)
        {
            Barril barril = new Barril(float.Parse(txtCapacidadBarril.Text),duff.cervezas[cmbGenerarTipoCerveza.SelectedIndex]);
            duff.addBarril(barril);
            llenarComboBarril();
            txtCapacidadBarril.Clear();
            cmbGenerarTipoCerveza.Text = "";
            MessageBox.Show("barril generado");
        }

        private void cmbSeleccionarBarril_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbTipoVaso.Enabled = true;
            lblTipoCerveza.Text = "Tipo Cerveza: " + duff.barriles[cmbSeleccionarBarril.SelectedIndex].cerveza.getNombre();
        }

        private void cmbTipoVaso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            float precio = duff.barriles[cmbSeleccionarBarril.SelectedIndex].cerveza.getPrecio() * duff.vasos[cmbTipoVaso.SelectedIndex].getCapacidad();

            lblPrecio.Text = precio.ToString("C");
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            float precio = duff.barriles[cmbSeleccionarBarril.SelectedIndex].cerveza.getPrecio() * duff.vasos[cmbTipoVaso.SelectedIndex].getCapacidad();
            duff.comprar(precio);
            duff.barriles[cmbSeleccionarBarril.SelectedIndex].servirLitros( duff.vasos[cmbTipoVaso.SelectedIndex].getCapacidad());
            MessageBox.Show("BIEN!! LO COMPRASTE GATO");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El total es: " + duff.getTotal().ToString("C")+"\nEl que más vendió fue: "+duff.getMasVendio());
        }
    }
}
