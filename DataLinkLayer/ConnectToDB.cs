using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataLinkLayer
{
    public class ConnectToDB
    {
        // local database
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UPVC_DB.mdf;Integrated Security=False";

        // local database absolute path
        //private string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename='F:\office projects\UPVC_Inventory\DataLinkLayer\UPVC_DB.mdf';Integrated Security = True";

        // sql server database
        //private string connectionString = @"Data Source=ABDULLAHPC\SQLEXPRESS;Initial Catalog=UPVC_Inventory;Integrated Security=True";

        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        public int WriteToDB(string query)
        {
            return ExecuteNonQuery(query);
        }

        public SqlDataReader ReadFromDB(string query)
        {
            SqlDataReader reader;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    reader = sqlCommand.ExecuteReader();
                    sqlConnection.Close();
                }
            }
            return reader;
        }

        public DataSet ReadDatasetFromDB(string query)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlDataAdapter.SelectCommand = sqlCommand;

                    sqlDataAdapter.Fill(dataset);
                    sqlConnection.Close();
                }
            }
            return dataset;
        }

        public int UpdateInDB(string query)
        {
            return ExecuteNonQuery(query);
        }

        public int DeleteFromDB(string query)
        {
            return ExecuteNonQuery(query);
        }

        public object executeScaler(string query)
        {
            object result;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    result = sqlCommand.ExecuteScalar();
                    sqlConnection.Close();
                }
            }

            return result;
        }

        public int ExecuteNonQuery(string query)
        {
            int result;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    result = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            return result;
        }
    }
}