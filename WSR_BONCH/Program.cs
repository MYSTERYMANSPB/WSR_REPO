using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WSR_BONCH.Utils;

namespace WSR_BONCH
{
    static class Program
    {
        private static Database m_database = new Database();
        public static IDbConnection m_databaseConnection;
        public static bool m_databaseConnectionStatus = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            m_databaseConnection = m_database.CreateDatabaseConnection("127.0.0.1", "wsr_test", "root", "");
            m_databaseConnectionStatus = m_database.OpenDatabaseConnection(ref m_databaseConnection);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (m_databaseConnectionStatus)
            {
                Application.Run(new LogINForm());
            } else
            {
                MessageBox.Show(Errors.errorText[(int)Errors.ErrorMssage.NO_DATABASE_CONNECTION], "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }            
        }
    }
}
