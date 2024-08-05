using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace login_MVC.DAL
{

    internal class DBConnection
    {

        private SqlConnection connection;
        private string dataSource;
        private string initialCatalog;
        private string user;
        private string password;

        public DBConnection(string dataSource = "200.234.224.123,54321",
            string initialCatalog = "MarcAlbaMVC",
            string user = "sa",
            string password = "Sql#123456789")
        {
            string connectionString = $"Data source= {dataSource};" +
                $"Initial Catalog= {initialCatalog};" +
                $"User ID={user};" +
                $"Password = {password};";

            connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception error)
            {
                
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception error)
            {
               
            }
        }


        public SqlCommand ExecuteQuery(string sql)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                return command;

            }
            catch (Exception ex)
            {
                
                return null;
            }
        }

        public string Status()
        {
            return connection.State.ToString();
        }
    }
}