using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Vuelo_DAL
    {
        Acceso acceso = new Acceso();

        public List<BE.Vuelo> listarVuelos()
        {
            List<BE.Vuelo> listaVuelos = new List<BE.Vuelo>();
            DataTable dataTable = acceso.readData("obtenerVuelos", null);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                BE.Vuelo vuelo = new BE.Vuelo();
                vuelo.Id_vuelo = int.Parse(dataRow["ID_Vuelo"].ToString());
                vuelo.Id_ciudadOrigen = int.Parse(dataRow["ID_CiudadOrigen"].ToString());
                vuelo.Id_ciudadDestino = int.Parse(dataRow["ID_CiudadDestino"].ToString());
                var _FechaSalida = DateTime.Parse(dataRow["FechaSalida"].ToString());
                var _FechaLlegada = DateTime.Parse(dataRow["FechaLlegada"].ToString());
                var _HoraSalida = DateTime.Parse(dataRow["HoraSalida"].ToString());
                var _HoraLlegada = DateTime.Parse(dataRow["HoraLlegada"].ToString());
                vuelo.FechaSalida = _FechaSalida.ToShortDateString();
                vuelo.FechaLlegada = _FechaLlegada.ToShortDateString();
                vuelo.HoraSalida = _HoraSalida.ToShortTimeString();
                vuelo.HoraLlegada = _HoraLlegada.ToShortTimeString();
                vuelo.Precio = float.Parse(dataRow["Precio"].ToString());
                listaVuelos.Add(vuelo);
            }
            return listaVuelos;
        }

        public String getCiudadNombre(int ciudad)
        {
            string nombre = "";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("id_ciudad", ciudad);
            DataTable dataTable = acceso.readData("getCiudadNombre", sqlParameters);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                nombre = dataRow["NombreCiudad"].ToString();
            }
            return nombre;
        }

        public int getCiudadID(string nombreCiudad)
        {
            int id = 0;
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("nombreCiudad", nombreCiudad);
            DataTable dataTable = acceso.readData("getCiudadID", sqlParameters);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                id = int.Parse(dataRow["ID_Ciudad"].ToString());
            }
            return id;
        }

        public DataTable getVueloID(int[] datos)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("id_CiudadOrigen", datos[0]);
            sqlParameters[1] = new SqlParameter("id_CiudadDestino", datos[1]);
            return acceso.readData("getVueloID", sqlParameters);
        }

        public List<BE.Vuelo> getVueloDatos(int id)
        {
            List<BE.Vuelo> listaVuelo = new List<BE.Vuelo>();
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("id_vuelo", id);
            DataTable dataTable = acceso.readData("getVueloDatos", sqlParameters);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                BE.Vuelo vuelo = new BE.Vuelo();
                vuelo.Id_vuelo = int.Parse(dataRow["ID_Vuelo"].ToString());
                vuelo.Id_ciudadOrigen = int.Parse(dataRow["ID_CiudadOrigen"].ToString());
                vuelo.Id_ciudadDestino = int.Parse(dataRow["ID_CiudadDestino"].ToString());
                var _FechaSalida = DateTime.Parse(dataRow["FechaSalida"].ToString());
                var _FechaLlegada = DateTime.Parse(dataRow["FechaLlegada"].ToString());
                var _HoraSalida = DateTime.Parse(dataRow["HoraSalida"].ToString());
                var _HoraLlegada = DateTime.Parse(dataRow["HoraLlegada"].ToString());
                vuelo.FechaSalida = _FechaSalida.ToShortDateString();
                vuelo.FechaLlegada = _FechaLlegada.ToShortDateString();
                vuelo.HoraSalida = _HoraSalida.ToShortTimeString();
                vuelo.HoraLlegada = _HoraLlegada.ToShortTimeString();
                vuelo.Precio = float.Parse(dataRow["Precio"].ToString());
                listaVuelo.Add(vuelo);
            }
            return listaVuelo;
        }

        public DataTable getPaisID(string nombreCiudad)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("nombreCiudad", nombreCiudad);
            return acceso.readData("getPaisID", sqlParameters);
        }

        public DataTable getPaisNombre(int id)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("id_pais", id);
            return acceso.readData("getPaisNombre", sqlParameters);
        }

        
    }
}
