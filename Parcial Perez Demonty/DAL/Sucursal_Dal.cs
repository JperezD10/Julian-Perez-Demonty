using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    
    public class Sucursal_Dal
    {
        Acceso acceso = new Acceso();
        public String Agregar(BE.Sucursal s)
        {
            SqlParameter[] parametro = new SqlParameter[2];
            parametro[0] = new SqlParameter("@ID", s._IDSucursal);
            parametro[1] = new SqlParameter("@direccion",s._Direccion);
            return acceso.Escribir("altaSucursal", parametro);
        }
    }
}
