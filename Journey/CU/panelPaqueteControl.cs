using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CU
{
    public partial class panelPaqueteControl : UserControl
    {
        BE.Paquete paquete = new BE.Paquete();
        DAL.Paquete_DAL MapperPaquete = new DAL.Paquete_DAL();
        DAL.Hotel_DAL MapperHotel = new DAL.Hotel_DAL();
        DAL.Vuelo_DAL MapperVuelo = new DAL.Vuelo_DAL();
        DAL.Cliente_DAL MapperCliente = new DAL.Cliente_DAL();
        DAL.Factura_DAL MapperFactura = new DAL.Factura_DAL();

        public string user;

        public panelPaqueteControl()
        {
            InitializeComponent();
        }

        private void NudAdultos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PanelPaqueteControl_Load(object sender, EventArgs e)
        {
            listarPaquetes();   
        }

        private void listarPaquetes()
        {
            string[] nombreVuelo = new string[2];
            string nombreHotel = "";
            List<BE.Paquete> listaPaquetes = MapperPaquete.listarPaquetes();
            foreach(BE.Paquete paquete in listaPaquetes)
            {
                List<BE.Vuelo> vuelos = MapperVuelo.getVueloDatos(paquete.Id_vuelo);
                foreach (BE.Vuelo vuelo in vuelos)
                {
                    nombreVuelo[0] = MapperVuelo.getCiudadNombre(vuelo.Id_ciudadOrigen);
                    nombreVuelo[1] = MapperVuelo.getCiudadNombre(vuelo.Id_ciudadDestino);
                }
                nombreHotel = MapperHotel.getHotelNombre(paquete.Id_hotel);
                lbPaquetes.Items.Add(nombreVuelo[0] + "→" + nombreVuelo[1] + "+" + nombreHotel);
            }
            
        }

        private void setMinDate()
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(int.Parse(lblCantidadDias.Text));
        }

        int[] datos = new int[2];
        private void LbPaquetes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!lbPaquetes.SelectedItem.Equals(0))
                {
                    int[] ciudad = new int[2];
                    string preline = lbPaquetes.SelectedItem.ToString();
                    string[] final = new string[2];
                    string hotel = "";
                    //int[] datos = new int[2];
                    string[] lines = preline.Split('+');
                    final[0] = lines[0].Substring(0, lines[0].IndexOf("→"));
                    final[1] = lines[0].Substring(preline.LastIndexOf("→")+1);
                    hotel = lines[1];//.Substring(preline.LastIndexOf("+ ") + 2);
                    lblVuelo.Text = final[0] + " → " + final[1];
                    lblHotel.Text = hotel;
                    ciudad[0] = MapperVuelo.getCiudadID(final[0]);
                    ciudad[1] = MapperVuelo.getCiudadID(final[1]);
                    DataTable dataTable = MapperVuelo.getVueloID(ciudad);
                    foreach(DataRow dataRow in dataTable.Rows)
                    {
                        datos[0] = int.Parse(dataRow["ID_Vuelo"].ToString());
                    }
                    datos[1] = MapperHotel.getIDHotel(hotel);
                    int idVuelo = MapperPaquete.getPaqueteID(datos);
                    lblPrecio.Text = MapperPaquete.getPaquetePrecio(idVuelo).ToString();
                    lblCantidadDias.Text = MapperPaquete.getCantidadDias(idVuelo).ToString();
                    dateTimePicker1.Value = DateTime.Today;
                    setMinDate();

                }
            }
            catch (Exception)
            {

            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            setMinDate();
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!lbPaquetes.SelectedItem.Equals(null))
                {
                    DialogResult dialogResult = MessageBox.Show("¿Desea comprar el paquete?" + Environment.NewLine +
                        "Total: $" + lblPrecio.Text, "Comprar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);
                    if (dialogResult.Equals(DialogResult.Yes))
                    {
                        generarFactura();
                        MessageBox.Show("Compra realizada.");
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

        private void generarFactura()
        {
            try
            {
                int idcliente = 0;
                String[] dateTimes = new string[2];

                BE.Factura factura = new BE.Factura();
                BE.FacturaPaquete facturaPaquete = new BE.FacturaPaquete();
                factura.Id_factura = 0;
                DataTable dataTable = MapperCliente.getClientID(user);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    idcliente = int.Parse(dataRow["ID_Cliente"].ToString());
                }
                factura.Id_cliente = idcliente;
                factura.FechaRealizacion = DateTime.Now.ToShortDateString();
                factura.HoraRealizacion = DateTime.Now.ToShortTimeString();
                factura.Precio = float.Parse(lblPrecio.Text);
                factura.Id_tipofactura = facturaPaquete.Id_tipofactura = 3;
                MapperFactura.generarFactura(factura);
                facturaPaquete.Id_facturapaquete = 0;
                dateTimes[0] = factura.FechaRealizacion;
                dateTimes[1] = factura.HoraRealizacion;
                facturaPaquete.Id_factura = MapperFactura.obtenerIDFactura(dateTimes);
                facturaPaquete.Id_paquete = MapperPaquete.getPaqueteID(datos);
                facturaPaquete.Cantidadmenores = int.Parse(nudMenores.Value.ToString());
                facturaPaquete.Cantidadadultos = int.Parse(nudAdultos.Value.ToString());
                facturaPaquete.Checkin = dateTimePicker1.Value;
                facturaPaquete.Checkout = dateTimePicker2.Value;
                MapperFactura.generarFacturaPaquete(facturaPaquete);
            }
            catch (Exception)
            {

            }
        }
    }
}
