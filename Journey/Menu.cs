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
    public partial class Menu : Form
    {    
        private int xClick;
        private int yClick;

        WindowsAnimation windowsAnimation = new WindowsAnimation();
        
        BLL.Gestor_BLL gestor = new BLL.Gestor_BLL();
        BE.Factura factura;
        public Menu()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        void mouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left += (e.X - xClick); this.Top += (e.Y - yClick); }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            hidePanelListBox();
            panelHotelControl2.Hide();
            animacionAbrir();
            btnPanelUsuario.Text = panelPaqueteControl1.user = Properties.Settings.Default.nombreUsuario;
            btnPaquetes.PerformClick();
            
        }

        private void hidePanelListBox()
        {
            lbVuelos.Hide();
            panelVuelo.Hide();
        }

        private void animacionAbrir()
        {
            windowsAnimation.animacionAbrir(this.Handle,1000);          
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            animacionCerrar();
            Properties.Settings.Default.nombreUsuario = null;
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            windowsAnimation.animacionMinimizar(this.Handle);
            this.WindowState = FormWindowState.Minimized;
        }

        private void animacionCerrar()
        {
            windowsAnimation.animacionCerrar(this.Handle,200);
        }

        private void animacionAbrirPanel()
        {
            windowsAnimation.animacionDeslizarPanelUsuarioAbrir(panelMenuUsuario.Handle);
            panelMenuUsuario.Visible = true;
        }

        private void animacionCerrarPanel()
        {
            windowsAnimation.animacionDeslizarPanelUsuarioCerrar(panelMenuUsuario.Handle);
            panelMenuUsuario.Visible = false;
        }
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenuUsuario.Visible.Equals(false))
            {
                animacionAbrirPanel();
            }
            else
            {
                animacionCerrarPanel();
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void PbLogo_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!btnPaquetes.Font.Equals(DefaultFont) && !btnHoteles.Font.Equals(DefaultFont))
            {
                btnHoteles.Font = new Font(btnHoteles.Font, FontStyle.Regular);
                btnPaquetes.Font = new Font(btnPaquetes.Font, FontStyle.Regular);
                btnVuelos.Font = new Font(btnVuelos.Font, FontStyle.Bold);
                Properties.Settings.Default.opcionMenuSelected = "Vuelos";
                comprobarOpcionSelected(Properties.Settings.Default.opcionMenuSelected);
            }
           
        }

        private void showListaVuelos()
        {
            lbVuelos.Items.Clear();
            setMinValueNud();
            List<BE.Vuelo> listaVuelos = gestor.listarVuelos();           
            String[] datos = new string[2];
            foreach(BE.Vuelo vuelo in listaVuelos)
            {
                datos[0] = gestor.getCiudadNombre(vuelo.Id_ciudadOrigen);
                datos[1] = gestor.getCiudadNombre(vuelo.Id_ciudadDestino);
                lbVuelos.Items.Add(datos[0] + "  →  " + datos[1]);
            }
            lbVuelos.Show();
            panelVuelo.Show();           
        }

        private void BtnPaquetes_Click(object sender, EventArgs e)
        {
            if (!btnVuelos.Font.Equals(DefaultFont) && !btnHoteles.Font.Equals(DefaultFont))
            {
                btnHoteles.Font = new Font(btnHoteles.Font, FontStyle.Regular);
                btnVuelos.Font = new Font(btnVuelos.Font, FontStyle.Regular);
                btnPaquetes.Font = new Font(btnPaquetes.Font, FontStyle.Bold);
                Properties.Settings.Default.opcionMenuSelected = "Paquetes";
                comprobarOpcionSelected(Properties.Settings.Default.opcionMenuSelected);
            }
            
        }

        private void showListaHoteles()
        {
            panelHotelControl2.Show();
            panelHotelControl2.cleanListBox();
            List<BE.Hotel> listaHoteles = gestor.listarHoteles();
            panelHotelControl2.addHoteles(listaHoteles);
            panelHotelControl2.user = Properties.Settings.Default.nombreUsuario;
        }  

        private void cleanLabelsVuelo()
        {
            lblCiudadDestino.Text = lblCiudadOrigen.Text = lblFechaLlegada.Text = lblFechaSalida.Text = lblHoraLlegada.Text =
                lblHoraSalida.Text = lblPaisOrigen.Text = lblPrecio.Text = lblPaisDestino.Text = "-";
        }

        private void comprobarOpcionSelected(string selected)
        {
            if (selected.Equals("Vuelos"))
            {
                panelHotelControl2.Hide();
                showListaVuelos();
                panelPaqueteControl1.Hide();
                cleanLabelsVuelo();
                
                
            }
            else if (selected.Equals("Hoteles"))
            {
                hidePanelListBox();
                showListaHoteles();
                panelPaqueteControl1.Hide();
            }
            else
            {
                panelHotelControl2.Hide();
                hidePanelListBox();
                panelPaqueteControl1.Show();
                
            }
        }

        private void BtnHoteles_Click(object sender, EventArgs e)
        {
            if(!btnVuelos.Font.Equals(DefaultFont) && !btnPaquetes.Font.Equals(DefaultFont))
            {
                btnVuelos.Font = new Font(btnVuelos.Font, FontStyle.Regular);
                btnPaquetes.Font = new Font(btnPaquetes.Font, FontStyle.Regular);
                btnHoteles.Font = new Font(btnHoteles.Font, FontStyle.Bold);
                Properties.Settings.Default.opcionMenuSelected = "Hoteles";
                comprobarOpcionSelected(Properties.Settings.Default.opcionMenuSelected);
            }
        }

        private void BtnPanelUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            JourneyLogIn logIn = new JourneyLogIn();
            Properties.Settings.Default.nombreUsuario = null;
            animacionCerrar();
            this.Close();
            logIn.Show();
        }

        private void BtnCuenta_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            windowsAnimation.animacionCerrar(this.Handle, 350);
            cuenta.Show();
            this.Hide();
        }

        private void BtnSeguridad_Click(object sender, EventArgs e)
        {
            Seguridad seguridad = new Seguridad();
            windowsAnimation.animacionCerrar(this.Handle, 350);
            seguridad.Show();           
            this.Hide();
            
        }   

        private void BtnVuelos_Click(object sender, EventArgs e)
        {

        }

        private void LbVuelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadVuelos();
            
        }

        private string[] getStringLine()
        {
            string[] lines = new string[3];
            lines[0] = lbVuelos.SelectedItem.ToString();
            lines[1] = lines[0].Substring(0, lines[0].IndexOf("  →"));
            lines[2] = lines[0].Substring(lines[0].LastIndexOf("→  ") + 3);
            return lines;
        }
        private void loadVuelos()
        {
            try
            {
                if (!lbVuelos.SelectedItem.Equals(null))
                {
                    setMinValueNud();
                    String[] lines = getStringLine();
                    int[] datos = new int[2];
                    datos[0] = gestor.getCiudadID(lines[1]);
                    datos[1] = gestor.getCiudadID(lines[2]);
                    List<BE.Vuelo> listaVuelo = gestor.getVueloDatos(gestor.getVueloID(datos));
                    foreach (BE.Vuelo vuelo in listaVuelo)
                    {
                        lblCiudadOrigen.Text = lines[1];
                        lblCiudadDestino.Text = lines[2];
                        lblPaisOrigen.Text = gestor.getPaisNombre(gestor.getPaisID(lines[1]));
                        lblPaisDestino.Text = gestor.getPaisNombre(gestor.getPaisID(lines[2]));
                        lblFechaLlegada.Text = vuelo.FechaLlegada.ToString();
                        lblFechaSalida.Text = vuelo.FechaSalida.ToString();
                        lblHoraLlegada.Text = vuelo.HoraLlegada.ToString();
                        lblHoraSalida.Text = vuelo.HoraSalida.ToString();
                        lblPrecio.Text = vuelo.Precio.ToString();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            comprarVuelo();
        }

        private void setMinValueNud()
        {
            nudCantidad.Value = 1;
        }

        private void comprarVuelo()
        {
            try
            {
                if (!lbVuelos.SelectedItem.Equals(null))
                {
                    DialogResult dialogResult = MessageBox.Show("¿Desea comprar el vuelo?" + Environment.NewLine +
                        "Total: $"+ calcularTotal(), "Comprar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);
                    if (dialogResult.Equals(DialogResult.Yes))
                    {            
                        generarFactura();
                        MessageBox.Show("Compra realizada.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setMinValueNud();
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private int calcularTotal()
        {
            return int.Parse(lblPrecio.Text) * int.Parse(nudCantidad.Value.ToString());
        }
        private String generarFactura()
        {
            try
            {
                factura = new BE.Factura();
                factura.Id_factura = 0;
                factura.Id_cliente = gestor.getClientID(Properties.Settings.Default.nombreUsuario);           
                factura.FechaRealizacion = DateTime.Now.ToShortDateString();
                factura.HoraRealizacion = DateTime.Now.ToShortTimeString();             
                factura.Precio = calcularTotal();
                generarFacturaVuelo(factura);
                return "";
            }
            catch(Exception ex)
            {
                return ex.Message;

            }
        }


        private void generarFacturaVuelo(BE.Factura factura)
        {
            String[] lines = getStringLine();
            BE.FacturaVuelo facturaVuelo = new BE.FacturaVuelo();
            factura.Id_tipofactura = facturaVuelo.Id_tipofactura = 1;
            int[] datos = new int[2];
            String[] dateTime = new string[2];
            int id = 0;
            datos[0] = gestor.getCiudadID(lines[1]);
            datos[1] = gestor.getCiudadID(lines[2]);
            dateTime[0] = factura.FechaRealizacion;
            dateTime[1] = factura.HoraRealizacion;
            facturaVuelo.Id_facturavuelo = 0;
            facturaVuelo.Id_vuelo = gestor.getVueloID(datos);
            facturaVuelo.CantidadVuelos = int.Parse(nudCantidad.Value.ToString());
            gestor.generarFactura(factura);
            id = gestor.obtenerIDFactura(dateTime);
            facturaVuelo.Id_factura = id;
            gestor.generarFacturaVuelo(facturaVuelo);
            
        }

        private void NudCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            windowsAnimation.animacionCerrar(this.Handle, 350);
            factura.Show();
            this.Hide();
        }

        private void LblCiudadOrigen_Click(object sender, EventArgs e)
        {

        }

        private void LblCiudadDestino_Click(object sender, EventArgs e)
        {

        }

        private void LblPaisDestino_Click(object sender, EventArgs e)
        {

        }

        private void LblPaisOrigen_Click(object sender, EventArgs e)
        {

        }

        private void LblFechaSalida_Click(object sender, EventArgs e)
        {

        }

        private void LblFechaLlegada_Click(object sender, EventArgs e)
        {

        }

        private void PanelHotelControl1_Load(object sender, EventArgs e)
        {

        }

        private void BtnPanelUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
