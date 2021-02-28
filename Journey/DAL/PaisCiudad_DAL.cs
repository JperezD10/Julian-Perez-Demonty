using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PaisCiudad_DAL
    {
        Acceso acceso = new Acceso();
        
        public List<BE.Pais> cargarPaises()
        {
            List<BE.Pais> listaPaises = new List<BE.Pais>();           
            DataTable dataTable = acceso.readData("cargarPaises", null);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                BE.Pais paises = new BE.Pais();
                paises.Id_Pais = int.Parse(dataRow["ID_Pais"].ToString());
                paises.Nombre = dataRow["Nombre"].ToString();
                listaPaises.Add(paises);
            }
            return listaPaises;
        }
        public List<BE.Ciudad> cargarCiudades(int id_pais)
        {
            List<BE.Ciudad> listaCiudades = new List<BE.Ciudad>();
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id_pais", id_pais);
            DataTable dataTable = acceso.readData("cargarCiudades",sqlParameters);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                BE.Ciudad ciudad = new BE.Ciudad();
                ciudad.Id_Ciudad = int.Parse(dataRow["ID_Ciudad"].ToString());
                ciudad.Nombre = dataRow["NombreCiudad"].ToString();
                ciudad.Id_Pais = int.Parse(dataRow["ID_Pais"].ToString());
                listaCiudades.Add(ciudad);
            }
            return listaCiudades;
        }

        public DataTable getCiudadNombre(int ciudad)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("id_ciudad", ciudad);
            return acceso.readData("getCiudadNombre", sqlParameters);
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
