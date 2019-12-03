using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace WSR_BONCH.Utils
{
    class Database
    {
        public IDbConnection CreateDatabaseConnection(string l_databaseServer, string l_databaseName, string l_databaseUser, string l_databasePassword, int l_databasePort = 3306)
        {
            IDbConnection l_databaseConnection;
            string l_databaseConnectionString = $"Server={l_databaseServer};Port={l_databasePort};Database={l_databaseName};Username={l_databaseUser};Password={l_databasePassword}";
            l_databaseConnection = new MySqlConnection(l_databaseConnectionString);
            return l_databaseConnection;
        }

        public bool OpenDatabaseConnection(ref IDbConnection l_databaseConnection)
        {
            if (l_databaseConnection != null) l_databaseConnection.Close();

            try
            {
                l_databaseConnection.Open();
            }
            catch(MySqlException ex)
            {
                l_databaseConnection = null;
                return false;
            }
            return true;
        }
    }
}
