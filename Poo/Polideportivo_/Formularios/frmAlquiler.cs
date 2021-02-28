using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Formularios
{
    public partial class frmAlquiler : Form
    {
        Contenedor contenedor;
        public frmAlquiler(Contenedor context)
        {
            InitializeComponent();
             contenedor = context;
        }

        private void frmAlquiler_Load(object sender, EventArgs e)
        {

        }

        private void cmbOpcionales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbOpcionales.SelectedIndex == 1)
            {
                lblValor.Text = (contenedor.canchas[cmbCancha.SelectedIndex].Valor + 100).ToString();
                panelArbitro.Enabled = panelArbitro.Visible = true;
            }
            else if(cmbOpcionales.SelectedIndex == 2)
            {
                lblValor.Text = (contenedor.canchas[cmbCancha.SelectedIndex].Valor + 100+90).ToString();
                panelArbitro.Enabled = panelArbitro.Visible = panelJuecesLinea.Visible = panelJuecesLinea.Enabled = true;
            }
            else {
                lblValor.Text = contenedor.canchas[cmbCancha.SelectedIndex].Valor.ToString();
                panelArbitro.Visible = false;
                panelJuecesLinea.Visible = false;
            }


            cmbTurno.Enabled = true;
            cmbTurno.Items.Clear();
            cmbTurno.Text = "";
            for(int i = 0 ; i < contenedor.canchas[cmbCancha.SelectedIndex].TurnosEstados.Length ; i++)
            {
                if (!contenedor.canchas[cmbCancha.SelectedIndex].TurnosEstados[i])
                {
                    cmbTurno.Items.Add(contenedor.canchas[cmbCancha.SelectedIndex].TurnosText[i]);
                }
            }

        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbOpcionales.SelectedIndex == 0)
            {
                btnAlquilar.Enabled = true;
            }else
            {
                btnAlquilar.Enabled = false;
            }
          
        }

        private void cmbArbitro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbArbitro.Items.Clear();
            String datos = "";
            foreach (Juez ju in contenedor.obtenerArbitros(cmbTurno.SelectedIndex))
            {
                datos = ju.NroLegajo + " - " + ju.Apellido.ToUpper() + ", " + ju.Nombre;
                if(cmbJuezLinea1.SelectedItem != null && datos == cmbJuezLinea1.SelectedItem.ToString())
                {
                    continue;
                }
                if (cmbJuezLinea2.SelectedItem != null && datos == cmbJuezLinea2.SelectedItem.ToString())
                {
                    continue;
                }

                cmbArbitro.Items.Add(datos);
                
            }
            if(cmbOpcionales.SelectedIndex == 2)
            {
                   panelJuecesLinea.Visible = panelJuecesLinea.Enabled = true;
             }

            if (cmbOpcionales.SelectedIndex == 1)
            {
                btnAlquilar.Enabled = true;
            }
            else
            {
                btnAlquilar.Enabled = false;
            }

        }



        private void cmbJuezLinea1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbOpcionales.SelectedIndex == 2)
            {
                cmbJuezLinea1.Items.Clear();
                
                String datos = "";
                foreach (Juez ju in contenedor.obtenerArbitros(cmbTurno.SelectedIndex))
                {
                    datos = ju.NroLegajo + " - " + ju.Apellido.ToUpper() + ", " + ju.Nombre;
                    if (cmbArbitro.SelectedItem != null && datos == cmbArbitro.SelectedItem.ToString())
                    {
                        continue;
                    }
                    if (cmbJuezLinea2.SelectedItem != null && datos == cmbJuezLinea2.SelectedItem.ToString())
                    {
                        continue;
                    }

                    cmbJuezLinea1.Items.Add(datos);
                }
            }
            if (cmbJuezLinea1.SelectedItem != null && cmbJuezLinea2 != null)
            {
                btnAlquilar.Enabled = true;
            }
            else
            {
                btnAlquilar.Enabled = false;
            }
        }

        private void cmbJuezLinea2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbOpcionales.SelectedIndex == 2)
            {
                cmbJuezLinea2.Items.Clear();
                
                String datos = "";
                foreach (Juez ju in contenedor.obtenerArbitros(cmbTurno.SelectedIndex))
                {
                    datos = ju.NroLegajo + " - " + ju.Apellido.ToUpper() + ", " + ju.Nombre;
                    if (cmbArbitro.SelectedItem != null && datos == cmbArbitro.SelectedItem.ToString())
                    {
                        continue;
                    }
                    if (cmbJuezLinea1.SelectedItem != null && datos == cmbJuezLinea1.SelectedItem.ToString())
                    {
                        continue;
                    }

                    cmbJuezLinea2.Items.Add(datos);
                }
            }

            if(cmbJuezLinea1.SelectedItem != null && cmbJuezLinea2 != null)
            {
                btnAlquilar.Enabled = true;
            }else
            {
                btnAlquilar.Enabled = false;
            }
        }

        private void resetCmbyPanel()
        {
            cmbOpcionales.Items.Clear();
            cmbOpcionales.Text = "";
            cmbArbitro.Items.Clear();
            cmbArbitro.Text = "";
            cmbJuezLinea1.Items.Clear();
            cmbJuezLinea1.Text = "";
            cmbJuezLinea2.Items.Clear();
            cmbJuezLinea2.Text = "";
            panelJuecesLinea.Visible = false;
            panelArbitro.Visible = false;
        }

        private void cmbCancha_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Cancha de Tenis
               Cancha de fútbol 5
               Cancha de fútbol 7
               Cancha de fútbol 11
               */
            lblValor.Text = contenedor.canchas[cmbCancha.SelectedIndex].Valor.ToString();
            resetCmbyPanel();
            cmbOpcionales.Enabled = true;
            cmbOpcionales.Items.Add("----------------------");
            switch (cmbCancha.SelectedIndex)
            {
                case 0:
                case 2:
                    cmbOpcionales.Items.Add(contenedor.canchas[cmbCancha.SelectedIndex].Opcional1Text);
                    break;
                case 3:
                    CanchaFutbol11 cancha = (CanchaFutbol11)contenedor.canchas[cmbCancha.SelectedIndex];
                    cmbOpcionales.Items.Add(cancha.Opcional1Text);
                    cmbOpcionales.Items.Add(cancha.Opcional2Text);
                    break;
            }
        }
    }
}
