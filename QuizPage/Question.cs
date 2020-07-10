using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace QuizPage
{
    public class Question
    {
        private string questionText;
        private string correctAnswer;
        private string imagePath;
        public string[] distractorAnswers = new string[3];
        private int questionID;

        public Question()
        {
            questionText = "undefined";
            correctAnswer = "undefined";

            for (int i = 0; i < 3; i++)
                distractorAnswers[i] = "undefined";
        }

        public string QuestionText
        {
            get { return questionText; }
            set { questionText = value; }
        }

        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }

        public int QuestionID
        {
            get { return questionID; }
            set { questionID = value; }
        }

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }
    }
}
