using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AutoDAL
    {
        Acceso acceso = new Acceso();

        public string Agregar(BE.Auto auto)
        {

            SqlParameter[] parametro = new SqlParameter[3];
            parametro[0] = new SqlParameter("@pat", auto._Patente);
            parametro[1] = new SqlParameter("@marca", auto._Modelo);
            parametro[2] = new SqlParameter("@estado", auto._Estado);
            return acceso.Escribir("AgregarAuto", parametro);
        }
        
    }
}
