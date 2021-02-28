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
    public partial class Consultas : Form
    {
        MenuPrincipal context;
        public Consultas(MenuPrincipal context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            context.Show();
            this.Close();
        }

        private void btnEstadoAlta_Click(object sender, EventArgs e)
        {
            string mensaje = "Planta ALTA\n\nAsientos Disponibles: ";
            string mensaje2 = "\n\nAsientos Ocupados: ";
            for (int i = 0; i < 20; i++)
            {
                if (!context.asientosAltaVendidos[i])
                {
                    mensaje += (i + 1) + ",";
                }
                else
                {
                    mensaje2 += (i + 1) + ",";
                }
            }
            MessageBox.Show(mensaje + mensaje2);
        }

        private void btnEstadoBaja_Click(object sender, EventArgs e)
        {
            string mensaje = "Planta BAJA\n\nAsientos Disponibles: ";
            string mensaje2 = "\n\nAsientos Ocupados: ";
            for (int i = 0; i < 25; i++)
            {
                if (!context.asientosBajaVendidos[i])
                {
                    mensaje += (i + 1) + ",";
                }
                else
                {
                    mensaje2 += (i + 1) + ",";
                }
            }
            MessageBox.Show(mensaje + mensaje2);
        }

        private void btnTotalRecaudado_Click(object sender, EventArgs e)
        {
            string mensaje = "Total recaudado Planta ALTA: $" + context.total[0];
            mensaje += "\n\nTotal recaudado Planta BAJA: $" + context.total[1];
            mensaje += "\n\nTOTAL GENERAl: $" + (context.total[1] + context.total[0]);
            MessageBox.Show(mensaje);
        }
    }
}
