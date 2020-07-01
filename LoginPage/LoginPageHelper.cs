using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using MenuScreen;
using System.Windows.Forms;

namespace LoginPage
{
    /// <summary>
    /// Helper class to check login information and log the user in before playing the game.
    /// </summary>
    public static class LoginPageHelper
    {
        public static bool CheckValidLoginInfo(string username, string encryptedPassword)
        {
            string sqlConnection = ConfigurationManager.AppSettings["sqlConnection"];

            SqlConnection con = new SqlConnection(sqlConnection);
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                string strCommand = $"SELECT UserID, username FROM UserInformation WHERE Username = '{username}' AND Pass = '{encryptedPassword}'";
                SqlCommand cmd = new SqlCommand(strCommand, con);
                SqlDataReader readCmd = cmd.ExecuteReader();
                string id;

                if (readCmd.Read())
                {
                    id = readCmd.GetValue(0).ToString();
                    UserMenuScreen.userID = int.Parse(id);
                    UserMenuScreen.username = readCmd.GetValue(1).ToString();
                    return true;
                }
            }

            return false;
        }

        public static string HashPassword(string password)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] encryptedBytes = md5.ComputeHash(utf8.GetBytes(password));
                return Convert.ToBase64String(encryptedBytes);
            }
        }
    }

}
