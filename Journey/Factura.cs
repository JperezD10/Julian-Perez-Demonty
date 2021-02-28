using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journey
{
    public partial class Factura : Form
    {
        WindowsAnimation windowsAnimation = new WindowsAnimation();
        BLL.Gestor_BLL gestor = new BLL.Gestor_BLL();
        private int xClick;
        private int yClick;

        public Factura()
        {
            InitializeComponent();
        }

        void mouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left += (e.X - xClick); this.Top += (e.Y - yClick); }
        }
        private void Factura_Load(object sender, EventArgs e)
        {
            windowsAnimation.animacionAbrir(this.Handle, 350);
            lbFacturas.Items.Clear();
            loadFacturas();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            windowsAnimation.animacionCerrar(this.Handle, 350);
            menu.Show();
            this.Hide();
        }

        private void LblFechaLlegada_Click(object sender, EventArgs e)
        {

        }

        private void loadFacturas()
        {
            List<BE.Factura> listaFactura = gestor.getFacturas(Properties.Settings.Default.nombreUsuario);
            int contador = 0;
            foreach (BE.Factura factura in listaFactura)
            {             
                lbFacturas.Items.Add(++contador + " - " + factura.FechaRealizacion + " / " + factura.HoraRealizacion);
            }
        }

        private void Factura_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void LbFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            getFacturaDatos();
        }

        private void getFacturaDatos()
        {
            String[] datos = new string[2];
            string line = lbFacturas.SelectedItem.ToString();
            datos[0] = line.Substring(line.IndexOf("- ")+2, line.IndexOf(" /")-4);
            datos[1] = line.Substring(line.IndexOf("/ ") + 2);
            List<BE.Factura> listaFacturaDatos = gestor.getFacturaDatos(datos);
            foreach(BE.Factura factura in listaFacturaDatos)
            {
                lblTipoFactura.Text = gestor.getNombreTipoFactura(factura.Id_tipofactura);
                lblFechaRealizacion.Text = datos[0];
                lblHoraRealizacion.Text = datos[1];
                lblPrecioFactura.Text = factura.Precio.ToString();
            }
        }
    }
}
