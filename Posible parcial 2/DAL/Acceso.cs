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

        private void abrir()
        {
            try
            {
                conexion.ConnectionString = @"Data Source = msi; Initial Catalog = Parcial2LUG; Integrated Security = True";
                conexion.Open();
            }
            catch(Exception)
            {
            }
        }
        public void Cerrar()
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
        public String Escribir(string st, SqlParameter[] parametros)
        {

            abrir();
            iniciarTR();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = st;
            cmd.Parameters.AddRange(parametros);
            try
            {
                cmd.Transaction = TR;
                cmd.ExecuteNonQuery();
                confirmarTR();
            }
            catch (Exception ex)
            {
                cancelarTR();
                return ex.Message + "error de conexion a la base";
            }

            Cerrar();
            return "";
        }

        public DataTable Leer(string st, SqlParameter[] parametros)
        {
            abrir();
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = new SqlCommand();
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
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
        public string GenerarXML()
        {
            DataSet DS = new DataSet();
            abrir();
            SqlDataAdapter DA = new SqlDataAdapter("Select * from Viaje where Importe>=500 and IDvehiculo=1", conexion);
            DA.Fill(DS, "Viajes");
            Cerrar();
            DS.WriteXml("D:\\Viajes.txt");
            return "";
        }
    }
}
