using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class Viaje_DAL
    {
        Acceso acceso = new Acceso();

        public string Agregar(BE.Viaje via)
        {

            SqlParameter[] parametro = new SqlParameter[7];
            parametro[0] = new SqlParameter("@id", via._IDviaje);
            parametro[1] = new SqlParameter("@idvehiculo", via._IDVehiculo);
            parametro[2] = new SqlParameter("@idpasajero", via._IDPasajero);
            parametro[3] = new SqlParameter("@destino", via._Destino);
            parametro[4] = new SqlParameter("@kilometro", via._Kilometro);
            parametro[5] = new SqlParameter("@importe", via._Precio);
            parametro[6] = new SqlParameter("@fechaviaje", via.FECHAVIAJE);
            return acceso.Escribir("CargarViaje", parametro);
        }
        public int ContarViajes(BE.Viaje via)
        {
            int fa = 0;
            DataTable tabla = acceso.Leer("ContarViajes", null);
            foreach (DataRow Registro in tabla.Rows)
            {
                fa = int.Parse(Registro["cantViajes"].ToString());
            }
            return fa;
        }
    }
}
