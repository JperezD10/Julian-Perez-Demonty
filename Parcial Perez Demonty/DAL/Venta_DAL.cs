using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Venta_DAL
    {
        Acceso acceso = new Acceso();
        public String AgregarVenta(BE.Venta v)
        {
            SqlParameter[] parametro = new SqlParameter[6];
            parametro[0] = new SqlParameter("@idventa", v._IdVenta);
            parametro[1] = new SqlParameter("@idsucursal",v._IDSucursal);
            parametro[2] = new SqlParameter("@idproducto", v._IDProducto);
            parametro[3] = new SqlParameter("@cantidad", v._Cantidad);
            parametro[4] = new SqlParameter("@precio", v._Cantidad);
            parametro[5] = new SqlParameter("@importe", v._Cantidad);
            return acceso.Escribir("altaVenta", parametro);
        }
    }
}
