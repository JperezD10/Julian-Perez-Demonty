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
    public partial class Resumen : Form
    {
        Starbucks starbucks;

        public Resumen(Starbucks cafeteria)
        {
            InitializeComponent();
            starbucks = cafeteria;
        }

        private void Resumen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if(starbucks.Maquina[i] != null)
                {
                    cmbTipoMaquina.Items.Add(i + 1);
                }                
            }
            lblTotalGeneral.Text = "$"+starbucks.totalNegocio().ToString();
        }

        private void cmbTipoCafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipoMaquina.SelectedItem != null)
            {
                lblTotalPorMaquina.Text = "$"+starbucks.totalPorMaquina(int.Parse(cmbTipoMaquina.Text)).ToString();
            }
        }
    }
}
