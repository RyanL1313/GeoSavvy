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

namespace QuizPage
{
    class QuizPageHelpers
    {
        public static void UpdateBackgroundImageMapping()
        {
            QuizAttributes.QuizBackgroundFileMap.Add("Oceania", "AustralianOutback.jpg");
            QuizAttributes.QuizBackgroundFileMap.Add("Asia", "GreatWallOfChina.jpg");
            QuizAttributes.QuizBackgroundFileMap.Add("South America", "MachuPicchu.jpg");
            QuizAttributes.QuizBackgroundFileMap.Add("North America", "MountRushmore.jpg");
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
            int randomSongNumber = randomGenerator.Next(1, 4); // 3 possible song choices

            SoundPlayer song = new SoundPlayer(GetQuizPageProjectPath() + @"Sounds\QuizSong" + randomSongNumber + ".wav");
            song.PlayLooping();
        }
    }
}
