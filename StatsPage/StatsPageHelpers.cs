using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace StatsPage
{
    public static class StatsPageHelpers
    {
        public static void PlayBackgroundMusic()
        {
            string pathToSong = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\StatsPage\Sounds\StatsSong.wav"));

            SoundPlayer song = new SoundPlayer(pathToSong);
            song.PlayLooping();
        }

        public static void StopBackgroundMusic()
        {
            string pathToSong = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\StatsPage\Sounds\StatsSong.wav"));

            SoundPlayer muteSong = new SoundPlayer(pathToSong);
            muteSong.Stop();
        }

        public static void DisplayGameStats()
        {
            string sqlConnection = ConfigurationManager.AppSettings["sqlConnection"];

            SqlConnection con = new SqlConnection(sqlConnection);
            con.Open();

            string statsDisplay = "Percentage answered correctly:\n\n";
            string answer = "";
            int timesAnswered;
            int timesCorrect;

            if (con.State == ConnectionState.Open)
            {
                string strCommand = $"SELECT Answer, TimesAnswered, TimesCorrect FROM [UserAnswers] WHERE GameMode = '{StatsPageForm.regionSelected}' AND UserID = {StatsPageForm.userID}";
                SqlCommand cmd = new SqlCommand(strCommand, con);
                SqlDataReader cmdReader = cmd.ExecuteReader();

                while (cmdReader.Read())
                {
                    answer = cmdReader.GetValue(0).ToString();
                    timesAnswered = int.Parse(cmdReader.GetValue(1).ToString());
                    timesCorrect = int.Parse(cmdReader.GetValue(2).ToString());

                    statsDisplay = String.Concat(statsDisplay, answer + " | " + Decimal.Round((((decimal)timesCorrect / timesAnswered)) * 100, 1) + "%\n");
                }

                MessageBox.Show(statsDisplay);
            }
        }
    }
}
