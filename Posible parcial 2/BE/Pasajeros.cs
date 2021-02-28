using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pasajeros
    {
        private int IDPasajero;

        public int _IDPasajero
        {
            get { return IDPasajero; }
            set { IDPasajero = value; }
        }
        private string Nombre;

        public string _Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        private string Apellido;

        public string _Apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        private string Direccion;

        public string _Direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

    }
}
