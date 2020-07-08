using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizPage
{
    public partial class QuizPageForm : Form
    {
        private const int numAnswerChoices = 4;
        private int numQuestions = 0;
        private int correctAnswerIndex = 0;
        private int numberCorrect = 0;
        Question[] questions;
        Quiz quiz;

        Button[] AnswerChoiceButtons = new Button[numAnswerChoices];
        public QuizPageForm()
        {
            InitializeComponent();
        }

        private void QuizPageForm_Load(object sender, EventArgs e)
        {
            QuizPageHelpers.UpdateBackgroundImageMapping();
            BackgroundBox.BackgroundImage = QuizPageHelpers.GetQuizBackgroundImage();
            QuizPageHelpers.PlayRandomQuizMusic();

            AddButtonsToArray();

            quiz = new Quiz();

            questions = quiz.QuizQuestions;
            numQuestions = questions.Length;

            // Allows the correct answer to be within a random button
            ChangeCorrectAnswerIndex();
            SetUpButtonChoices(correctAnswerIndex, questions[0]);

            QuestionLabel.Text = questions[0].QuestionText;
            QuizProgressLabel.Text = $"{quiz.QuestionIndex}/{numQuestions}";
            ImageForQuestionBox.BackgroundImage = QuizPageHelpers.GetQuestionImage(questions[0].CorrectAnswer);
        }

        private void AddButtonsToArray()
        {
            AnswerChoiceButtons[0] = ChoiceAButton;
            AnswerChoiceButtons[1] = ChoiceBButton;
            AnswerChoiceButtons[2] = ChoiceCButton;
            AnswerChoiceButtons[3] = ChoiceDButton;
        }

        private void ChangeCorrectAnswerIndex()
        {
            Random randomGenerator = new Random();
            correctAnswerIndex = randomGenerator.Next(0, 4);
        }

        private void SetUpQuestionLabels(Question question)
        {
            QuestionLabel.Text = question.QuestionText;
            QuizProgressLabel.Text = $"{quiz.QuestionIndex}/{Quiz.numberOfQuestions}";

        }

        private void SetUpButtonChoices(int correctAnswerIndex, Question question)
        {
            AnswerChoiceButtons[correctAnswerIndex].Text = question.CorrectAnswer;
            int distractorAnswersIndex = 0;

            for (int i = 0; i < numAnswerChoices; i++)
            {
                if (i != correctAnswerIndex)
                    AnswerChoiceButtons[i].Text = question.distractorAnswers[distractorAnswersIndex++];
            }
        }

        private void DisableAnswerChoiceButtons()
        {
            ChoiceAButton.Click -= ChoiceAButton_Click;
            ChoiceBButton.Click -= ChoiceBButton_Click;
            ChoiceCButton.Click -= ChoiceCButton_Click;
            ChoiceDButton.Click -= ChoiceDButton_Click;
        }

        private void EnableAnswerChoiceButtons()
        {
            ChoiceAButton.Click += ChoiceAButton_Click;
            ChoiceBButton.Click += ChoiceBButton_Click;
            ChoiceCButton.Click += ChoiceCButton_Click;
            ChoiceDButton.Click += ChoiceDButton_Click;
        }

        private void AnswerChoiceButtonPressEvent(int buttonIndex)
        {
            DisableAnswerChoiceButtons();

            if (correctAnswerIndex == buttonIndex)
            {
                AnswerChoiceButtons[buttonIndex].FlatAppearance.BorderColor = Color.Green;
                CorrectAnswerNotifier.Text = "Correct!";
                CorrectAnswerNotifier.Visible = true;
                ++numberCorrect;
            }
            else
            {
                foreach (Button choiceButton in AnswerChoiceButtons)
                    choiceButton.FlatAppearance.BorderColor = Color.Red;

                AnswerChoiceButtons[correctAnswerIndex].FlatAppearance.BorderColor = Color.Green;

                CorrectAnswerNotifier.Text = $"Incorrect. The correct answer was \"{questions[quiz.QuestionIndex - 1].CorrectAnswer}\".";
                CorrectAnswerNotifier.Visible = true;
            }

            if (quiz.QuestionIndex + 1 > numQuestions)
            {
                FinishButton.Visible = true;
                MessageBox.Show($"You have finished the quiz and scored a {((double)numberCorrect / numQuestions) * 100}%! Press \"finish\" to be taken back to the menu.");
                NextQuestionButton.Click -= NextQuestionButton_Click;
            }
        }

        private void ResetButtonBorders()
        {
            foreach (Button choiceButton in AnswerChoiceButtons)
                choiceButton.FlatAppearance.BorderColor = Color.Empty;
        }

        private void ChoiceAButton_Click(object sender, EventArgs e)
        {
            AnswerChoiceButtonPressEvent(0);
        }

        private void ChoiceBButton_Click(object sender, EventArgs e)
        {
            AnswerChoiceButtonPressEvent(1);
        }

        private void ChoiceCButton_Click(object sender, EventArgs e)
        {
            AnswerChoiceButtonPressEvent(2);
        }

        private void ChoiceDButton_Click(object sender, EventArgs e)
        {
            AnswerChoiceButtonPressEvent(3);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.ResetQuizProperties();

            this.DialogResult = DialogResult.OK;
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            if (quiz.QuestionIndex < numQuestions)
            {
                EnableAnswerChoiceButtons();
                quiz.UpdateQuestionIndex();
                ChangeCorrectAnswerIndex();
                CorrectAnswerNotifier.Visible = false;
                ResetButtonBorders();
                SetUpButtonChoices(correctAnswerIndex, questions[quiz.QuestionIndex - 1]);
                SetUpQuestionLabels(questions[quiz.QuestionIndex - 1]);
                ImageForQuestionBox.BackgroundImage = QuizPageHelpers.GetQuestionImage(questions[quiz.QuestionIndex - 1].CorrectAnswer);
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
