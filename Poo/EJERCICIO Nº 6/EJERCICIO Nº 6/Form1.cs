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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hotel Hotel = new Hotel();

        PERSONAS Personita;

        HABITACION Habitaciones;

        RESERVAS Reservar;

        private void Form1_Load(object sender, EventArgs e)
        {

            /*
            MessageBox.Show(Hotel.Habitaciones[0].nroHabitacion+" precio :"+Hotel.Habitaciones[0].PRECIO);
                 MessageBox.Show(Hotel.Habitaciones[1].nroHabitacion + " precio :" + Hotel.Habitaciones[1].PRECIO);
            MessageBox.Show(Hotel.Habitaciones[2].nroHabitacion + " precio :" + Hotel.Habitaciones[2].PRECIO);
            */

        }

        void RellenarComboHabitaciones()
        {
        

            CmbHabitaciones.Items.Clear();

            foreach (HABITACION H in Hotel.Habitaciones)
            {

             CmbHabitaciones.Items.Add(H.NROHABITACION + " " + "Precio: " + H.PRECIO);
               
            }

        }

        void RellenarComboPersonas()
        {

            CmbPersonas.Items.Clear();

            foreach (PERSONAS Men in Hotel.Personas)
            {

                CmbPersonas.Items.Add(Men.APELLIDO);

            }

        }

        private void BtnCrearHabitacion_Click(object sender, EventArgs e)
        {


            Hotel.LlenarHabitaciones(CmbTipoHabitacion.SelectedIndex);

            RellenarComboHabitaciones();


        }

        private void BtnAgregarPersona_Click(object sender, EventArgs e)
        {

            Personita = new PERSONAS(TxtNombre.Text,TxtApellido.Text,int.Parse(TxtDni.Text) ,int.Parse(TxtEdad.Text) ,int.Parse(TxtNacimiento.Text));

            Hotel.LlenarPeronas(Personita);

            RellenarComboPersonas();

        }

        void LLenarComboHabReservadas()
        {
            CmbHabReservadas.Items.Clear();

            foreach(RESERVAS H in Hotel.Reservas)
            {

               CmbHabReservadas.Items.Add(H.NROHABITACION + " " + H.NOMBREDELPROPIETARIO);
  

            }

        }

        private void BtnReservar_Click(object sender, EventArgs e)
        {
            if(Hotel.Habitaciones[CmbHabitaciones.SelectedIndex].ESTADOHABITACION == true)
            {

                MessageBox.Show(" Habitacion: " + Hotel.Habitaciones[CmbHabitaciones.SelectedIndex].NROHABITACION + " Vendida");
               
            }
            else
            {
                
                Hotel.Habitaciones[CmbHabitaciones.SelectedIndex].ESTADOHABITACION = true;

                Reservar = new RESERVAS(Hotel.Habitaciones[CmbHabitaciones.SelectedIndex].NROHABITACION,Hotel.Personas[CmbPersonas.SelectedIndex].APELLIDO);

                Hotel.LLenarReservas(Reservar);

                LLenarComboHabReservadas();

                              

            }

             
            
        }

        private void BtnNuevoForm_Click(object sender, EventArgs e)
        {

            Datos New = new Datos(Hotel);

            New.ShowDialog();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Hotel.Reservas[CmbHabReservadas.SelectedIndex].ESTADORESERVA == true)
            {

                MessageBox.Show("La habitacion :" + Hotel.Reservas[CmbHabReservadas.SelectedIndex].NROHABITACION + " Ya se a concretado la reserva");

            }

            Hotel.Reservas[CmbHabReservadas.SelectedIndex].ESTADORESERVA = true;
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Hotel.CancelarReserva(CmbHabReservadas.SelectedIndex);

        }
    }
}
