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
    public partial class panelHotelControl : UserControl
    {

        DAL.PaisCiudad_DAL MapperPaisCiudad = new DAL.PaisCiudad_DAL();
        DAL.Hotel_DAL MapperHotel = new DAL.Hotel_DAL();
        DAL.Cliente_DAL MapperCliente = new DAL.Cliente_DAL();
        DAL.Factura_DAL MapperFactura = new DAL.Factura_DAL();
        public panelHotelControl()
        {
            InitializeComponent();
        }

        public string Nombre { get => lblNombre.Text; set => lblNombre.Text = value; }
        public string Telefono { get => lblTelefono.Text; set => lblTelefono.Text = value; }
        public string Ciudad { get => lblCiudad.Text; set => lblCiudad.Text = value; }
        public string Categoria { get => lblCategoria.Text; set => lblCategoria.Text = value; }
        public string Direccion { get => lblDireccion.Text; set => lblDireccion.Text = value; }
        public string Precio { get => lblPrecio.Text; set => lblPrecio.Text = value; }
       

        public string user;

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void PanelHotelControl_Load(object sender, EventArgs e)
        {
            setMinDate();
        }

        private void setMinDate()
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
        }
        public void cleanListBox()
        {
            lbHoteles.Items.Clear();
        }

        public void addHoteles(List<BE.Hotel> lista)
        {
            foreach(BE.Hotel hotel in lista)
            {
                lbHoteles.Items.Add(hotel.Nombre);
            }
            
        }

        private void LbHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            List<BE.Hotel> listaHotel = MapperHotel.getHotelDatos(lbHoteles.SelectedItem.ToString());
            setHotelDatos(listaHotel);
        }

        public void setHotelDatos(List<BE.Hotel> lista)
        {
            string nombreCiudad = "", nombrePais = "";
            int paisID = 0;
            foreach (BE.Hotel hotel in lista)
            {
                lblNombre.Text = lbHoteles.SelectedItem.ToString();
                lblTelefono.Text = hotel.Telefono.ToString();
                
                DataTable dataTable = MapperPaisCiudad.getCiudadNombre(hotel.Id_Ciudad);
                
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    nombreCiudad = dataRow["NombreCiudad"].ToString();
                }
                DataTable dataTable1 = MapperPaisCiudad.getPaisID(nombreCiudad);
                foreach(DataRow dataRow in dataTable1.Rows)
                {
                    paisID = int.Parse(dataRow["ID_Pais"].ToString());
                }
                DataTable dataTable2 = MapperPaisCiudad.getPaisNombre(paisID);
                foreach(DataRow dataRow in dataTable2.Rows)
                {
                    nombrePais = dataRow["Nombre"].ToString();
                }
                lblCiudad.Text = nombreCiudad;
                lblPais.Text = nombrePais;
                lblCategoria.Text = hotel.Id_CategoriaHotel.ToString() + " Estrellas";
                lblDireccion.Text = hotel.Direccion;
                lblPrecio.Text = hotel.Precio.ToString();
            }
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!lbHoteles.SelectedItem.ToString().Equals(null))
                {
                    DialogResult dialogResult = MessageBox.Show("¿Desea comprar la estadia?" + Environment.NewLine +
                        "Total: $" + calcularTotal(), "Comprar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);
                    if (dialogResult.Equals(DialogResult.Yes))
                    {
                        generarFactura();
                        MessageBox.Show("Compra realizada.");
                        dateTimePicker1.Value = DateTime.Today;
                        setMinDate();
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

        private double calcularTotal()
        {
            DateTime dateTime = dateTimePicker1.Value;
            DateTime dateTime1 = dateTimePicker2.Value;
            return (int.Parse(lblPrecio.Text) * (dateTime1 - dateTime).TotalDays);
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {         
            setMinDate();
        }

        private String generarFactura()
        {
            try
            {
                int idcliente = 0;
                String[] dateTimes = new String[2];
                BE.Factura factura = new BE.Factura();
                BE.FacturaHotel facturaHotel = new BE.FacturaHotel();
                factura.Id_factura = 0;
                DataTable dataTable = MapperCliente.getClientID(user);
                foreach(DataRow dataRow in dataTable.Rows)
                {
                    idcliente = int.Parse(dataRow["ID_Cliente"].ToString());
                }
                factura.Id_cliente = idcliente;
                factura.FechaRealizacion = DateTime.Now.ToShortDateString();
                factura.HoraRealizacion = DateTime.Now.ToShortTimeString();
                factura.Precio = float.Parse(calcularTotal().ToString());
                factura.Id_tipofactura = facturaHotel.Id_tipofactura = 2;
                MapperFactura.generarFactura(factura);
                facturaHotel.Id_facturahotel = 0;            
                dateTimes[0] = factura.FechaRealizacion;
                dateTimes[1] = factura.HoraRealizacion;              
                facturaHotel.Id_factura = MapperFactura.obtenerIDFactura(dateTimes);
                facturaHotel.Id_hotel = MapperHotel.getIDHotel(lbHoteles.SelectedItem.ToString());
                facturaHotel.Checkin = dateTimePicker1.Value;
                facturaHotel.Checkout = dateTimePicker2.Value;
                MapperFactura.generarFacturaHotel(facturaHotel);            
            }
            catch (Exception)
            {

            }
            return "";
        }
    }
}
