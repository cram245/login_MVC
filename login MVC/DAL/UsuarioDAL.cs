using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace login_MVC.DAL
{
    public class UsuarioDAL
    {
        private DBConnection connection;

        public UsuarioDAL() 
        {
            this.connection = new DBConnection();
        }


        public bool CheckExists(Usuario usuario)
        {
            connection.OpenConnection();

            if (connection.Status() == "Open")
            {

                SqlCommand command = connection.ExecuteQuery($"SELECT * FROM Usuarios WHERE Email = '{usuario.Email}' AND Password = '{usuario.Password}'");
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("Select done");

                bool res = reader.Read();

                connection.CloseConnection();
                return res;
            }
            else
            {
                Console.WriteLine("Connection could not be opened");
                return false;
            }
                
        }
    }
}