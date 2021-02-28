using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HOTEL;

namespace EJERCICIO_Nº_6
{
    public partial class Datos : Form
    {
        Hotel Hotel;

        public Datos(Hotel Hotel)
        {
            InitializeComponent();

            this.Hotel = Hotel;
        }

        private void Datos_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Hotel.Habitaciones;

            DGVReservas.DataSource = Hotel.Reservas;
            
        }
    }
}
