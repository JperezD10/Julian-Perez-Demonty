using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class LogCliente_DAL
    {
        Acceso acceso = new Acceso();
        //Seguridad_DAL Security = new Seguridad_DAL();
        public String inscribirCliente(BE.Cliente cliente)
        {
            SqlParameter[] sqlParameters = new SqlParameter[12];
            sqlParameters[0] = new SqlParameter("@id_cliente",cliente.Id_Cliente);
            sqlParameters[1] = new SqlParameter("@dni", cliente.Dni);
            sqlParameters[2] = new SqlParameter("@nombre", cliente.Nombre);
            sqlParameters[3] = new SqlParameter("@apellido", cliente.Apellido);
            sqlParameters[4] = new SqlParameter("@fechaNacimiento", cliente.FechaNacimiento);
            sqlParameters[5] = new SqlParameter("@id_ciudad", cliente.Id_Ciudad);
            sqlParameters[6] = new SqlParameter("@direccion", cliente.Direccion);
            sqlParameters[7] = new SqlParameter("@telefono", cliente.Telefono);
            sqlParameters[8] = new SqlParameter("@email", cliente.Email);
            sqlParameters[9] = new SqlParameter("@id_logCliente", cliente.id_LogCliente);
            sqlParameters[10] = new SqlParameter("@user", cliente.User);
            sqlParameters[11] = new SqlParameter("@password", cliente.Password);
            return acceso.writeData("inscribirCliente", sqlParameters);
        }

        public String editarCliente(BE.Cliente cliente)
        {
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@id_cliente", cliente.Id_Cliente);
            sqlParameters[1] = new SqlParameter("@dni", cliente.Dni);
            sqlParameters[2] = new SqlParameter("@nombre", cliente.Nombre);
            sqlParameters[3] = new SqlParameter("@apellido", cliente.Apellido);
            sqlParameters[4] = new SqlParameter("@fechaNacimiento", cliente.FechaNacimiento);
            sqlParameters[5] = new SqlParameter("@id_ciudad", cliente.Id_Ciudad);
            sqlParameters[6] = new SqlParameter("@direccion", cliente.Direccion);
            sqlParameters[7] = new SqlParameter("@telefono", cliente.Telefono);
            return acceso.writeData("editarCliente", sqlParameters);
        }

        public DataTable iniciarSesion(BE.Cliente cliente)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("user", cliente.User);
            sqlParameters[1] = new SqlParameter("password", cliente.Password);
            DataTable dataTable = acceso.readData("iniciarSesion", sqlParameters);
            return dataTable;
        }
        public DataTable comprobarUsuarioExistente(BE.Cliente cliente)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("user", cliente.User);
            DataTable dataTable = acceso.readData("comprobarUsuarioExistente",sqlParameters);
            return dataTable;
        }

        /*public String iniciarSesion(BE.Cliente cliente, string key)
        {
           String PassCliente=null;
            SqlParameter[] sqlParameters = new SqlParameter[1];
            //sqlParameters[0] = new SqlParameter("user", cliente.User);
            sqlParameters[0] = new SqlParameter("user", cliente.User);
            DataTable dataTable = acceso.readData("iniciarSesion",sqlParameters);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                //BE.Cliente cliente1 = new BE.Cliente();
                //cliente1.User = dataRow["User"].ToString();
                PassCliente = Security.decrypt(dataRow["Password"].ToString(), key);
                
            }
            return PassCliente;
        }*/

    }
}
