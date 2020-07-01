using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace SignUpPage
{
    public static class SignUpPageHelper
    
    {
        public static string HashPassword(string password)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] encryptedBytes = md5.ComputeHash(utf8.GetBytes(password));
                return Convert.ToBase64String(encryptedBytes);
            }
        }

        public static void StoreUserInfo(string username, string encryptedPassword, string email)
        {
            string sqlConnection = ConfigurationManager.AppSettings["sqlConnection"];

            SqlConnection con = new SqlConnection(sqlConnection);
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                string strCommand = $"INSERT INTO UserInformation(Username, Pass, Email)VALUES('{username}', '{encryptedPassword}', '{email}')";
                SqlCommand cmd = new SqlCommand(strCommand, con);
                cmd.ExecuteNonQuery();
            }
        }


        public static bool ValidUserInformation(string username, string password, string email)
        {
            string message = "";

            if (!UsernameAvailabile(username))
                message = String.Concat(message, "That username is already taken. Try picking another one.\n");
            if (!EmailAvailabile(email))
                message = String.Concat(message, "That email is already associated with an account. Do you already have an account?\n");
            if (password.Length <= 7)
                message = String.Concat(message, "Password must be longer than 7 characters");

            if (String.IsNullOrEmpty(message))
                return true;
            else
            {
                MessageBox.Show(message);
                return false;
            }
        }
        private static bool UsernameAvailabile(string username)
        {
            string sqlConnection = ConfigurationManager.AppSettings["sqlConnection"];

            SqlConnection con = new SqlConnection(sqlConnection);
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                string strCommand = $"SELECT Username FROM UserInformation WHERE Username = '{username}'";

                SqlCommand cmd = new SqlCommand(strCommand, con);
                SqlDataReader readCmd = cmd.ExecuteReader();

                return !readCmd.Read(); // True if no matching record was found, false otherwise
            }

            return false;
        }

        private static bool EmailAvailabile(string email)
        {
            string sqlConnection = ConfigurationManager.AppSettings["sqlConnection"];

            SqlConnection con = new SqlConnection(sqlConnection);
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                string strCommand = $"SELECT Email FROM UserInformation WHERE Email = '{email}'";

                SqlCommand cmd = new SqlCommand(strCommand, con);
                SqlDataReader readCmd = cmd.ExecuteReader();

                return !readCmd.Read(); // True if no matching record was found, false otherwise
            }

            return false;
        }
    }
}
