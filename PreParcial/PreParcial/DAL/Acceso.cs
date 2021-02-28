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

        void Abrir()
        {
            conexion.ConnectionString = @"Data Source=.\SQL_UAI;Initial Catalog=PreParcial;Integrated Security=True";
            conexion.Open();
        }
        void Cerrar()
        {
            conexion.Close();
        }

        public String Escribir(string st, SqlParameter[] parametros,CommandType ct)
        {

            Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = ct;
            cmd.CommandText = st;
            cmd.Parameters.AddRange(parametros);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            Cerrar();
            return "";
        }
        
        public DataTable Leer(string st, SqlParameter[] parametros,CommandType ct)
        {
            Abrir();
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = new SqlCommand();
            adaptador.SelectCommand.CommandType = ct;
            adaptador.SelectCommand.CommandText = st;
            if (parametros != null)
            {
                adaptador.SelectCommand.Parameters.AddRange(parametros);
            }
            adaptador.SelectCommand.Connection = conexion;
            adaptador.Fill(tabla);
            Cerrar();
            return tabla;
        }
    }
}
