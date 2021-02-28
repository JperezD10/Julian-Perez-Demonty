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
            conexion.ConnectionString = @"Data Source=MSI;Initial Catalog=Parcial;Integrated Security=True";
            conexion.Open();
        }
        void cerrar()
        {
            conexion.Close();
        }
        SqlTransaction TR;

        void iniciarTR()
        {
            TR = conexion.BeginTransaction();
        }
        void confirmarTR()
        {
            TR.Commit();
        }
        void cancelarTR()
        {
            TR.Rollback();
        }
        public string Escribir(string st, SqlParameter[] parametro)
        {
            abrir();
            iniciarTR();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = st;
            cmd.Parameters.AddRange(parametro);
            try
            {
                cmd.Transaction = TR;
                cmd.ExecuteNonQuery();
                confirmarTR();
            }
            catch (Exception)
            {
                cancelarTR();
            }
            cerrar();
            return "";
        }
        public DataTable Leer(string st, SqlParameter[] parametro)
        {
            abrir();
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = new SqlCommand();
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.CommandText = st;
            if (parametro != null)
            {
                adaptador.SelectCommand.Parameters.AddRange(parametro);
            }
            adaptador.SelectCommand.Connection = conexion;
            adaptador.Fill(tabla);
            cerrar();
            return tabla;
        }
    }
}
