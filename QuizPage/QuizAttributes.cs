using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizPage
{
    public static class QuizAttributes
    {
        public static string region;
        public static string dataTable;
        public static int userID;
        public static Dictionary<string, string> QuizBackgroundFileMap = new Dictionary<string, string>();

        public static void ResetQuizProperties()
        {
            QuizBackgroundFileMap = new Dictionary<string, string>();
            region = "";
            dataTable = "";
        }
    }
}
