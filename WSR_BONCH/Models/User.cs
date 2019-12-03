using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace WSR_BONCH.Models
{
    class User
    {
        private int m_userID;
        private string m_userLogin;
        private string m_userPassword;
        private string m_userRole;

        public int UserID
        {
            get
            {
                return m_userID;
            }
            set
            {
                m_userID = value;
            }
        }
        
        public string UserLogin
        {
            get
            {
                return m_userLogin;
            }
            set
            {
               m_userLogin = value;
            }
        }

        public string UserPassword
        {
            get
            {
                return m_userPassword;
            }
            set
            {
                m_userPassword = value;
            }
        }

        public bool CheckUserLogin()
        {
            string l_regexLoginPattern = @"^[A-Z][a-zA-Z]{1,32}$";
            return Regex.IsMatch(UserLogin, l_regexLoginPattern) ? true : false;
        }

        public bool CheckUserPassword()
        {
            string l_regexEmailPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,32}$";
            return Regex.IsMatch(UserPassword, l_regexEmailPattern) ? true : false;
        }

        public bool SignUPUser()
        {
            MySqlCommand l_databaseCommand = (MySqlCommand)Program.m_databaseConnection.CreateCommand();
            l_databaseCommand.CommandText = $"INSERT INTO `users` (`user_login`, `user_password`) VALUES (@userLogin, @userPassword);";
            l_databaseCommand.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = UserLogin;
            l_databaseCommand.Parameters.Add("@userPassword", MySqlDbType.VarChar).Value = UserPassword;
            try
            {
                int result = l_databaseCommand.ExecuteNonQuery();
                if (result != 0) return true;
                else return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public bool LogINUser()
        {
            MySqlCommand l_databaseCommand = (MySqlCommand)Program.m_databaseConnection.CreateCommand();
            l_databaseCommand.CommandText = $"SELECT * FROM users WHERE `user_login` = '@userLogin' AND `user_password` = '@userPassword'";
            l_databaseCommand.Parameters.AddWithValue("@userLogin", UserLogin);
            l_databaseCommand.Parameters.AddWithValue("@userPassword", UserPassword);
            MySqlDataReader l_dataReader;
            try
            {
                l_dataReader = l_databaseCommand.ExecuteReader();
                if(l_dataReader.Read())
                {
                    Console.WriteLine(l_dataReader["user_id"]);
                }
                l_dataReader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Number.ToString());
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }
    }
}
