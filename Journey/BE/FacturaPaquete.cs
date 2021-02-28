using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FacturaPaquete
    {
        private int id_facturapaquete;
        private int id_factura;
        private int id_tipofactura;
        private int id_paquete;
        private DateTime checkin;
        private DateTime checkout;
        private int cantidadmenores;
        private int cantidadadultos;

        public int Id_facturapaquete { get => id_facturapaquete; set => id_facturapaquete = value; }     
        public DateTime Checkin { get => checkin; set => checkin = value; }
        public DateTime Checkout { get => checkout; set => checkout = value; }
        public int Cantidadmenores { get => cantidadmenores; set => cantidadmenores = value; }
        public int Cantidadadultos { get => cantidadadultos; set => cantidadadultos = value; }
        public int Id_factura { get => id_factura; set => id_factura = value; }
        public int Id_tipofactura { get => id_tipofactura; set => id_tipofactura = value; }
        public int Id_paquete { get => id_paquete; set => id_paquete = value; }
    }
}
