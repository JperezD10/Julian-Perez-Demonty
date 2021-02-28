using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Viaje
    {
        private int IDViaje;

        public int _IDviaje
        {
            get { return IDViaje; }
            set { IDViaje = value; }
        }
        private int IDVehiculo;

        public int _IDVehiculo
        {
            get { return IDVehiculo; }
            set { IDVehiculo = value; }
        }
        private int IDPasajero;

        public int _IDPasajero
        {
            get { return IDPasajero; }
            set { IDPasajero = value; }
        }
        private String Destino;

        public String _Destino
        {
            get { return Destino; }
            set { Destino = value; }
        }
        private int Kilometro;

        public int _Kilometro
        {
            get { return Kilometro; }
            set { Kilometro = value; }
        }
        private int Precio;

        public int _Precio
        {
            get { return Precio; }
            set { Precio = value; }
        }
        private DateTime FechaViaje;

        public DateTime FECHAVIAJE
        {
            get { return FechaViaje; }
            set { FechaViaje = value; }
        }


    }
}
