using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    internal class Acceso
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlTransaction sqlTransaction;

        private void openConnection()
        {
            try
            {
                sqlConnection.ConnectionString = @"Data Source = DESKTOP-TLDQ719;Initial Catalog = Journey;Integrated Security=true";
                sqlConnection.Open();
            }
            catch(Exception)
            {
                
            }
        }

        private void closeConnection()
        {
            try
            {
                sqlConnection.Close();
            }
            catch (Exception)
            {

            }
        }

        public DataTable readData(String st, SqlParameter[] parameters)
        {
            openConnection();          
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand();
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.CommandText = st;
            if (parameters != null)
            {
                sqlDataAdapter.SelectCommand.Parameters.AddRange(parameters);
            }
            sqlDataAdapter.SelectCommand.Connection = sqlConnection;
            try
            {
                sqlDataAdapter.Fill(dataTable);
            }
            catch(Exception)
            {
                
            }
            closeConnection();
            return dataTable;
        }
        public String writeData(String st, SqlParameter[] parameters)
        {
            openConnection();
            sqlTransaction = sqlConnection.BeginTransaction();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = st;
            sqlCommand.Connection = sqlConnection;      
            sqlCommand.Parameters.AddRange(parameters);
            try
            {
                sqlCommand.Transaction = sqlTransaction;
                sqlCommand.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
            catch(Exception ex)
            {
                sqlTransaction.Rollback();
                return ex.Message;
            }
            closeConnection();
            return "";
        }
    }
}
