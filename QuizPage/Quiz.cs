using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Media;

namespace QuizPage
{
    class Quiz
    {
        public const int numberOfQuestions = 10;
        private Question[] quizQuestions = new Question[numberOfQuestions];
        private int questionIndex = 0;
        public static string songLocation;
        public static bool muted = false;

        public Quiz()
        {
            CreateQuizQuestionsWithAnswer();
        }


        public Question[] QuizQuestions
        {
            get { return quizQuestions; }
        }

        public void CreateQuizQuestionsWithAnswer()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["sqlConnection"]);
            con.Open();
            int index = 0; // Index of quizQuestions array

            if (con.State == ConnectionState.Open)
            {
                string strCommand = "SELECT TOP " + numberOfQuestions + " QuestionID, Answer, Question, ImagePath FROM [Game." + QuizAttributes.dataTable + $"] ORDER BY NEWID()";
                SqlCommand cmd = new SqlCommand(strCommand, con);
                SqlDataReader readCmd = cmd.ExecuteReader();

                // Executes numberOfQuestions times
                while (readCmd.Read())
                {
                    Question quizQuestion = new Question();

                    quizQuestion.QuestionID = int.Parse(readCmd.GetValue(0).ToString());
                    quizQuestion.CorrectAnswer = readCmd.GetValue(1).ToString();
                    quizQuestion.QuestionText = readCmd.GetValue(2).ToString();
                    quizQuestion.ImagePath = readCmd.GetValue(3).ToString();

                    // The question is all set now, just needs distractor answers, then it gets added to the quizQuestions array
                    quizQuestions[index++] = AddInDistractorAnswers(quizQuestion);
                }

            }
        }

        private Question AddInDistractorAnswers(Question originalQuestion)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["sqlConnection"]);
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                string strCommand = "SELECT TOP 3" + " Answer FROM [Game." + QuizAttributes.dataTable + "] WHERE NOT Answer = '" + $"{originalQuestion.CorrectAnswer.Replace("'", "''")}" + "' ORDER BY NEWID()";
                SqlCommand cmd = new SqlCommand(strCommand, con);
                SqlDataReader readCmd = cmd.ExecuteReader();
                int index = 0; // Index of distractorAnswers array and current readCmd index

                while (readCmd.Read())
                {
                    originalQuestion.distractorAnswers[index] = readCmd.GetValue(0).ToString();
                    ++index;
                }
            }

            return originalQuestion;
        }

        public void UpdateQuestionIndex()
        {
            ++questionIndex;
        }

        public int QuestionIndex
        {
            get { return questionIndex; }
        }
    }
}
