using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class Acceso
    {
        SqlConnection conexion = new SqlConnection();

        void abrir()
        {
            conexion.ConnectionString = @"Data Source=.\SQL_UAI;Initial Catalog=AUTORERIA;Integrated Security=True";
            conexion.Open();
        }
        public void Cerrar()
        {
            conexion.Close();
        }
        public String Escribir(string st, SqlParameter[] parametros)
        {

            abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = st;
            cmd.Parameters.AddRange(parametros);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.Message + "error de conexion a la base";
            }

            Cerrar();
            return "";
        }
        public string GenerarXML()
        {
            DataSet DS = new DataSet();
            abrir();
            SqlDataAdapter DA = new SqlDataAdapter("Select * from Auto where Estado='Pagado'", conexion);
            DA.Fill(DS, "Auto");
            Cerrar();
            DS.WriteXml("D:\\Auto.xml");
            return "";
        }
    }
}
