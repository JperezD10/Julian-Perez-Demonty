using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Seguridad_DAL
    {
        Seguridad.Seguridad Security = new Seguridad.Seguridad();
        Acceso acceso = new Acceso();

        public String generarHash(String toHash, String username)
        {
            return Security.generarHash(toHash, username);
        }
        
        public string getUserPassword(string user)
        {
            string password = "";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@user", user);
            DataTable dataTable = acceso.readData("getUserPassword", sqlParameters);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                password = dataRow["Password"].ToString();
            }
            return password;
        }

        public String updatePassword(string hashed, string user)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@password", hashed);
            sqlParameters[1] = new SqlParameter("@user", user);
            return acceso.writeData("updatePassword", sqlParameters);
        }
        /*public String encrypt(String key)
        {
            return Security.returnEncrypted(key);
        }

        public String decrypt(String encrypted,String key)
        {
            return Security.returnDecrypted(encrypted, key);
        }*/
    }
}
