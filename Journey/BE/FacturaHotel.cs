using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FacturaHotel
    {
        private int id_facturahotel;
        private int id_factura;
        private int id_tipofactura;
        private int id_hotel;
        private DateTime checkin;
        private DateTime checkout;

        public int Id_facturahotel { get => id_facturahotel; set => id_facturahotel = value; }
        public int Id_factura { get => id_factura; set => id_factura = value; }
        public int Id_tipofactura { get => id_tipofactura; set => id_tipofactura = value; }
        public int Id_hotel { get => id_hotel; set => id_hotel = value; }
        public DateTime Checkin { get => checkin; set => checkin = value; }
        public DateTime Checkout { get => checkout; set => checkout = value; }
    }
}
