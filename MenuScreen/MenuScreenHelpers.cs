using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QuizPage;
using System.Windows.Forms;

namespace MenuScreen
{
    public static class MenuScreenHelpers
    {
        private static string GetMenuProjectPath()
        {
            return Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\MenuScreen\"));
        }

        public static void PlayBackgroundMusic()
        {
            SoundPlayer sound = new SoundPlayer(GetMenuProjectPath() + @"Sounds\MenuMusic.wav");
            sound.PlayLooping();
        }

        public static void StopBackgroundMusic()
        {
            SoundPlayer sound = new SoundPlayer(GetMenuProjectPath() + @"Sounds\MenuMusic.wav");
            sound.Stop();
        }

        public static int GetUserID()
        {
            string sqlConnection = ConfigurationManager.AppSettings["sqlConnection"];

            SqlConnection con = new SqlConnection(sqlConnection);
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                string strCommand = $"SELECT UserID FROM UserInformation WHERE Username = '{UserMenuScreen.username}'";
                string id = "";

                SqlCommand cmd = new SqlCommand(strCommand, con);
                SqlDataReader readCmd = cmd.ExecuteReader();

                if (readCmd.Read())
                    id = readCmd.GetValue(0).ToString();

                return int.Parse(id);
            }

            return -1;
        }
    }
}
