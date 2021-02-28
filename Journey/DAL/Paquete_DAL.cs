using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Paquete_DAL
    {
        Acceso acceso = new Acceso();
        public List<BE.Paquete> listarPaquetes()
        {
            List<BE.Paquete> listaPaquetes = new List<BE.Paquete>();
            DataTable dataTable = acceso.readData("listarPaquetes", null);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                BE.Paquete paquete = new BE.Paquete();
                paquete.Id_paquete = int.Parse(dataRow["ID_Paquete"].ToString());
                paquete.Id_hotel = int.Parse(dataRow["ID_Hotel"].ToString());
                paquete.Id_vuelo = int.Parse(dataRow["ID_Vuelo"].ToString());
                paquete.Cantidaddias = int.Parse(dataRow["CantidadDias"].ToString());
                paquete.Precio = int.Parse(dataRow["Precio"].ToString());
                listaPaquetes.Add(paquete);
            }
            return listaPaquetes;
        }

        public int getPaqueteID(int[] datos)
        {
            int id = 0;
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@idVuelo", datos[0]);
            sqlParameters[1] = new SqlParameter("@idHotel", datos[1]);
            DataTable dataTable = acceso.readData("getPaqueteID", sqlParameters);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                id = int.Parse(dataRow["ID_Paquete"].ToString());
            }
            return id;
        }

        public int getPaquetePrecio(int id)
        {
            int precio = 0;
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DataTable dataTable = acceso.readData("getPaquetePrecio", sqlParameters);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                precio = int.Parse(dataRow["Precio"].ToString());
            }
            return precio;
        }
        
        public int getCantidadDias(int id)
        {
            int dias = 0;
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);
            DataTable dataTable = acceso.readData("getCantidadDias", sqlParameters);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                dias = int.Parse(dataRow["CantidadDias"].ToString());
            }
            return dias;
        }
    }
}
