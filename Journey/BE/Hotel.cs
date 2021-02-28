using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Hotel
    {
        private int id_Hotel;
        private String nombre;
        private int telefono;
        private int id_Ciudad;
        private int id_CategoriaHotel;
        private String direccion;
        private int precio;

        public int Id_Hotel { get => id_Hotel; set => id_Hotel = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public int Id_Ciudad { get => id_Ciudad; set => id_Ciudad = value; }
        public int Id_CategoriaHotel { get => id_CategoriaHotel; set => id_CategoriaHotel = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Precio { get => precio; set => precio = value; }
    }
}
