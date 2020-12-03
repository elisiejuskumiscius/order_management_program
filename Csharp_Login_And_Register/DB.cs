using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Csharp_Login_And_Register
{

    class DB
    {
        public static String cs
        {
            get { return cs; }
            set { cs = value; }
        }

        string value = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\order_management_program\Csharp_Login_And_Register\Database.mdf;Integrated Security=True";

        SqlConnection connection = new SqlConnection(cs);

        // create a function to open the connection
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // create a function to close the connection
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // create a function to return the connection
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
