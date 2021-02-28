using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Cliente_DAL
    {
        Acceso acceso = new Acceso();
        public DataTable getClientID(string user)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("nombreUsuario", user);
            return acceso.readData("obtenerIDCliente", sqlParameters);           
        }

        public List<BE.Cliente> getClientData(int id)
        {
            List<BE.Cliente> listaCliente = new List<BE.Cliente>();
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("id_cliente", id);
            DataTable dataTable = acceso.readData("obtenerCliente", sqlParameters);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                BE.Cliente cliente = new BE.Cliente();
                cliente.Id_Cliente = int.Parse(dataRow["ID_Cliente"].ToString());
                cliente.Dni = int.Parse(dataRow["DNI"].ToString());
                cliente.Nombre = dataRow["Nombre"].ToString();
                cliente.Apellido = dataRow["Apellido"].ToString();              
                cliente.FechaNacimiento = DateTime.Parse(dataRow["FechaNacimiento"].ToString());
                cliente.Id_Ciudad = int.Parse(dataRow["ID_Ciudad"].ToString());
                cliente.Direccion = dataRow["Direccion"].ToString();
                cliente.Telefono = int.Parse(dataRow["Telefono"].ToString());
                cliente.Email = dataRow["Email"].ToString();
                listaCliente.Add(cliente);
            }
            return listaCliente;
        }

        public DataTable getClientCiudad(int id)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("id_ciudad", id);
            return acceso.readData("obtenerNombreCiudad", sqlParameters);
        }

        public DataTable getClientPais(int id)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("id_pais", id);
            return acceso.readData("obtenerNombrePais", sqlParameters);
        }
    }
}
