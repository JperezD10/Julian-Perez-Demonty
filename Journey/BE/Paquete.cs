using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Paquete
    {
        private int id_paquete;
        private int id_hotel;
        private int id_vuelo;
        private int cantidaddias;
        private int precio;

        public int Id_paquete { get => id_paquete; set => id_paquete = value; }
        public int Id_hotel { get => id_hotel; set => id_hotel = value; }
        public int Id_vuelo { get => id_vuelo; set => id_vuelo = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Cantidaddias { get => cantidaddias; set => cantidaddias = value; }
    }
}
