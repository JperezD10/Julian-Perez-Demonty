using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Posible_parcial_2
{
    public partial class frmVIaje : Form
    {
        Form1 f;
        public frmVIaje(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }
        BLL.Pasajeros_BLL gestorPasajeros = new BLL.Pasajeros_BLL();
        BLL.Vehiculo_BLL gestoVehiculo = new BLL.Vehiculo_BLL();
        BLL.Viaje_BLL gestorViaje = new BLL.Viaje_BLL();
        BE.Viaje temp;
        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void limpiarTXT()
        {
            txtDestino.Clear();
            txtKilometro.Clear();
            txtPasajero.Clear();
            txtVehiculo.Clear();
        }
        private void frmVIaje_Load(object sender, EventArgs e)
        {
            listar();
            gestorViaje.Generar();
            lblCantViajes.Text = gestorViaje.CantViajes(temp).ToString();
        }
        void listar()
        {
            GrillaPasajeros.DataSource = GrillaAutos.DataSource= null;
            GrillaPasajeros.DataSource = gestorPasajeros.Listar();
            GrillaAutos.DataSource = gestoVehiculo.Listar();
        }
        private void brAgregar_Click(object sender, EventArgs e)
        {
            temp = new BE.Viaje();
            temp._IDviaje = 0;
            temp._IDVehiculo = int.Parse(txtVehiculo.Text);
            temp._IDPasajero = int.Parse(txtPasajero.Text);
            temp._Kilometro = int.Parse(txtKilometro.Text);
            temp._Destino = txtDestino.Text;
            temp._Precio = int.Parse(txtKilometro.Text) * 40;
            temp.FECHAVIAJE = dateTimePicker1.Value;
            gestorViaje.Agregar(temp);
            gestorViaje.Generar();
            MessageBox.Show("viaje pedi3 \n Te sale esto prro: "+temp._Precio.ToString());
            limpiarTXT();
            lblCantViajes.Text = gestorViaje.CantViajes(temp).ToString();
        }

        private void GrillaPasajeros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.Pasajeros pasajeros = (BE.Pasajeros)GrillaPasajeros.Rows[e.RowIndex].DataBoundItem;
            txtPasajero.Text = pasajeros._IDPasajero.ToString();
        }

        private void GrillaAutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.Vehiculos vehiculos= (BE.Vehiculos)GrillaAutos.Rows[e.RowIndex].DataBoundItem;
            txtVehiculo.Text = vehiculos._IDVehiculo.ToString();
        }
    }
}
