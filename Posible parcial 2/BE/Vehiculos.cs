using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Vehiculos
    {
        private int IDVehiculo;

        public int _IDVehiculo
        {
            get { return IDVehiculo; }
            set { IDVehiculo = value; }
        }
        private String Marca;

        public String _Marca
        {
            get { return Marca; }
            set { Marca = value; }
        }
        private string Modelo;

        public string _Modelo
        {
            get { return Modelo; }
            set { Modelo = value; }
        }
        private string Patente;

        public string _Patente
        {
            get { return Patente; }
            set { Patente = value; }
        }



    }
}
