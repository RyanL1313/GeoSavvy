using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace QuizPage
{
    class QuizPageHelpers
    {
        /// <summary>
        /// Adds values to the QuizBackgroundFileMap Dictionary object in QuizAttributes.
        /// </summary>
        public static void UpdateBackgroundImageMapping()
        {
            QuizAttributes.QuizBackgroundFileMap.Add("Oceania", "AustralianOutback.jpg");
            QuizAttributes.QuizBackgroundFileMap.Add("Asia", "GreatWallOfChina.jpg");
            QuizAttributes.QuizBackgroundFileMap.Add("South America", "MachuPicchu.jpg");
            QuizAttributes.QuizBackgroundFileMap.Add("North America", "MayanRuins.jpg");
            QuizAttributes.QuizBackgroundFileMap.Add("Africa", "Sphinx.jpeg");
            QuizAttributes.QuizBackgroundFileMap.Add("Europe", "Venice.jpg");
            QuizAttributes.QuizBackgroundFileMap.Add("USA", "WhiteHouse.jpg");
        }

        private static string GetFilePathToQuizBackgroundImage()
        {
            return GetQuizPageProjectPath() + @"Images\" + QuizAttributes.QuizBackgroundFileMap[QuizAttributes.region];
        }

        private static string GetFilePathToQuestionImage(string imageName)
        {
            return GetQuizPageProjectPath() + @"Images\" + imageName + ".jpg";
        }

        /// <summary>
        /// Returns a string of the file path for the QuizPage namespace.
        /// </summary>
        /// <returns> File path for the QuizPage namespace. </returns>
        private static string GetQuizPageProjectPath()
        {
            return Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\QuizPage\"));
        }

        public static Image GetQuizBackgroundImage()
        {
            return new Bitmap(GetFilePathToQuizBackgroundImage());
        }

        public static Image GetQuestionImage(string imageName)
        {
            return new Bitmap(GetFilePathToQuestionImage(imageName));
        }

        public static void PlayRandomQuizMusic()
        {
            Random randomGenerator = new Random();
            int randomSongNumber = randomGenerator.Next(1, 7); // 6 possible song choices

            Quiz.songLocation = GetQuizPageProjectPath() + @"Sounds\QuizSong" + randomSongNumber + ".wav";

            SoundPlayer song = new SoundPlayer(Quiz.songLocation);
            song.PlayLooping();
        }

        /// <summary>
        /// This method activates when the mute button is pressed again after disabling it. This way it selects the song already randomly selected instead of picking a new random song.
        /// </summary>
        public static void PlaySetQuizMusic()
        {
            SoundPlayer song = new SoundPlayer(Quiz.songLocation);
            song.PlayLooping();
        }

        public static void MuteQuizMusic()
        {
            SoundPlayer muteSong = new SoundPlayer(Quiz.songLocation);
            muteSong.Stop();
        }
        /// <summary>
        /// Adds the answer to a question just answered by the user and whether or not they got it correct.
        /// Either the answer for this question is already in the database for that particular user and we just need to
        /// increment the TimesAnswered and TimesCorrect columns for that answer choice, or a new row needs to be created
        /// for that particular answer if it's the first time the user has answered the question.
        /// </summary>
        /// <param name="answer"> The answer to the question. </param>
        /// <param name="correct"> Whether or not the user got the question correct. </param>
        public static void AddQuestionResultToDatabase(string answer, bool correct)
        {
            SqlConnection con1 = new SqlConnection(ConfigurationManager.AppSettings["sqlConnection"]);
            con1.Open();

            if (con1.State == ConnectionState.Open)
            {
                string strCommand1 = $"SELECT AnswerID FROM [UserAnswers] WHERE GameMode = '{QuizAttributes.dataTable}' AND UserID = {QuizAttributes.userID} AND Answer = '{answer.Replace("'", "''")}'";
                SqlCommand cmd1 = new SqlCommand(strCommand1, con1);
                SqlDataReader readCmd1 = cmd1.ExecuteReader();

                if (readCmd1.Read()) // User has answered this question before, update the existing row
                {
                    SqlConnection con2 = new SqlConnection(ConfigurationManager.AppSettings["sqlConnection"]);
                    con2.Open();

                    string strCommand2 = $"UPDATE UserAnswers SET TimesAnswered = TimesAnswered + 1{GetUpdateCorrectString(correct)} WHERE AnswerID = {int.Parse(readCmd1.GetValue(0).ToString())}";
                    SqlCommand cmd2 = new SqlCommand(strCommand2, con2);
                    cmd2.ExecuteNonQuery();
                }
                else // First time user is answering this question, create new row
                {
                    SqlConnection con3 = new SqlConnection(ConfigurationManager.AppSettings["sqlConnection"]);
                    con3.Open();

                    string strCommand3 = $"INSERT INTO UserAnswers (GameMode, UserID, Answer, TimesAnswered, TimesCorrect) VALUES ('{QuizAttributes.dataTable}', {QuizAttributes.userID}, '{answer.Replace("'", "''")}', 1, {(correct ? 1 : 0)})";
                    SqlCommand cmd3 = new SqlCommand(strCommand3, con3);
                    cmd3.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Returns an addition to the strCommand2 in the AddQuestionResultToDatabase method based on the correct boolean value.
        /// </summary>
        /// <param name="correct"> If the user answered the question correctly. </param>
        /// <returns> The string addition if the user answered correctly, empty string otherwise. </returns>
        private static string GetUpdateCorrectString(bool correct)
        {
            return correct ? ", TimesCorrect = TimesCorrect + 1" : "";
        }
    }
}
