using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FacturaVuelo
    {
        private int id_facturavuelo;
        private int id_tipofactura;
        private int id_factura;
        private int id_vuelo;
        private int cantidadVuelos;

        public int Id_facturavuelo { get => id_facturavuelo; set => id_facturavuelo = value; }
        public int Id_tipofactura { get => id_tipofactura; set => id_tipofactura = value; }
        public int Id_factura { get => id_factura; set => id_factura = value; }
        public int Id_vuelo { get => id_vuelo; set => id_vuelo = value; }
        public int CantidadVuelos { get => cantidadVuelos; set => cantidadVuelos = value; }
    }
}
