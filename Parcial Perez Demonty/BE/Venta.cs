using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Venta
    {
        private int IDVenta;

        public int _IdVenta
        {
            get { return IDVenta; }
            set { IDVenta = value; }
        }
        private int IDSucursal;

        public int _IDSucursal
        {
            get { return IDSucursal; }
            set { IDSucursal = value; }
        }
        private int IDProducto;

        public int _IDProducto
        {
            get { return IDProducto; }
            set { IDProducto = value; }
        }
        private int Cantidad;

        public int _Cantidad
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }
        private int Precio;

        public int _Precio
        {
            get { return Precio; }
            set { Precio = value; }
        }

        private int Importe;

        public int _Importe
        {
            get { return Importe; }
            set { Importe = value; }
        }

    }
}
