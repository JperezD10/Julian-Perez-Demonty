using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Sucursal
    {
        private int IDSucursal;

        public int _IDSucursal
        {
            get { return IDSucursal; }
            set { IDSucursal = value; }
        }

        private String Direccion;

        public String _Direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

    }
}
