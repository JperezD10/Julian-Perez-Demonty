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
    public partial class AdministrarAvion : Form
    {
        MenuPrincipal context;
        public AdministrarAvion(MenuPrincipal context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void AdministrarAvion_Load(object sender, EventArgs e)
        {
            progressBarEstado.Minimum = 0;

        }
        private bool actualizarAsientos(int cantAsientos)
        {
            bool flagDisponible = false;
            comboBoxAsientos.Items.Clear();
            comboBoxAsientos.Text = "";
            int cantAlta = 20, cantBaja = 25;
            for(int i = 0; i < cantAsientos; i++)
            {
                if(cantAsientos == 20 && !context.asientosAltaVendidos[i])
                {
                    progressBarEstado.Maximum = 20;
                    comboBoxAsientos.Items.Add(i+1);
                    flagDisponible = true;
                    cantAlta--;
                    progressBarEstado.Value = cantAlta;
                }
                else if(cantAsientos == 25 && !context.asientosBajaVendidos[i]) {
                    progressBarEstado.Maximum = 25;
                    comboBoxAsientos.Items.Add(i+1);
                    flagDisponible = true;
                    cantBaja--;
                    progressBarEstado.Value = cantBaja;
                }
            }
            try
            {
            comboBoxAsientos.SelectedIndex = 0;
            }
            catch
            {
                
                progressBarEstado.Value = progressBarEstado.Maximum;
            }

           
            return flagDisponible;
        }
        private void rbPlantaAlta_CheckedChanged(object sender, EventArgs e)
        {
            
            bool flagDisp = false;
            if (rbPlantaAlta.Checked)
            {
                flagDisp = actualizarAsientos(20);
                lblPrecio.Text = 3000 + "";
                

            }else if (rbPlantaBaja.Checked)
            {
                flagDisp =  actualizarAsientos(25);
                lblPrecio.Text = 2500 + "";
                
            }
          
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            context.Show();
            this.Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if(comboBoxAsientos.Items.Count > 0) { 
                int posicion = int.Parse(comboBoxAsientos.SelectedItem.ToString())-1;
                if (rbPlantaAlta.Checked)
                {
                    context.asientosAltaVendidos[posicion] = true;
                    context.total[0] += 3000;
                }
                else
                {
                    context.asientosBajaVendidos[posicion] = true;
                    context.total[1] += 2500;
                }
                int cant = rbPlantaAlta.Checked ? 20 : 25;
                if (!actualizarAsientos(cant)) MessageBox.Show("ESA PLANTA ESTÁ LLENA");
            }
            else {
                MessageBox.Show("ESA PLANTA ESTÁ LLENA");
            }
        }
    }
}
