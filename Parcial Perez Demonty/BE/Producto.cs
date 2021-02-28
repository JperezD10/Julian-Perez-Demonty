using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {
        private int IDProducto;

        public int _IDProducto
        {
            get { return IDProducto; }
            set { IDProducto = value; }
        }
        private string Descripcion;

        public string _Descripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }

        private int Stock;

        public int _Stock
        {
            get { return Stock; }
            set { Stock = value; }
        }
        private int PrecioU;

        public int _PrecioU
        {
            get { return PrecioU; }
            set { PrecioU = value; }
        }

    }
}
