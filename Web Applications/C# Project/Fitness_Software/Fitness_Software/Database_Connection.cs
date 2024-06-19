using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Fitness_Software
{
    internal class Database_Connection
    {
        private MySqlConnection connection = new MySqlConnection
            ("datasource=localhost;port=3306;username=root;password=1234;database=fitness_software");

        //get connection
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        //open mysql connection
        public void OpenConnection()
        {
            connection.Open();
        }

        //close mysql connection
        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
