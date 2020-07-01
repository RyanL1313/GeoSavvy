using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

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
            SoundPlayer sound = new SoundPlayer(GetMenuProjectPath() + @"Sounds\alexander-nakarada-gjallar.wav");
            sound.PlayLooping();
        }
    }
}
