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
        private int correctAnswerIndex = 0;
        private int numberCorrect = 0;
        Quiz quiz;

        Button[] AnswerChoiceButtons = new Button[numAnswerChoices];
        public QuizPageForm()
        {
            InitializeComponent();
        }

        private void QuizPageForm_Load(object sender, EventArgs e)
        {
            if (QuizAttributes.dataTable.Contains("Flags")) // Smaller picture to prevent blur
            {
                ImageForQuestionBox.Size = new Size(300, 200);
                ImageForQuestionBox.Location = new Point(534, 163);
            }
            else
            {
                ImageForQuestionBox.Size = new Size(701, 450);
                ImageForQuestionBox.Location = new Point(332, 68);
            }

            Quiz.muted = false;
            QuizPageHelpers.UpdateBackgroundImageMapping();
            BackgroundBox.BackgroundImage = QuizPageHelpers.GetQuizBackgroundImage();
            QuizPageHelpers.PlayRandomQuizMusic();
            AddButtonsToArray();

            quiz = new Quiz();

            SetUpQuestion();
        }

        private void SetUpQuestion()
        {
            NextQuestionButton.Click -= NextQuestionButton_Click;
            ChangeCorrectAnswerIndex();
            CorrectAnswerNotifier.Visible = false;
            ResetButtonBorders();
            SetUpButtonChoices(correctAnswerIndex, quiz.QuizQuestions[quiz.QuestionIndex]);
            SetUpQuestionLabels();
            ImageForQuestionBox.BackgroundImage = QuizPageHelpers.GetQuestionImage(quiz.QuizQuestions[quiz.QuestionIndex].ImagePath);
            DisableAnswerChoiceButtons(); // To avoid a double event from occurring
            EnableAnswerChoiceButtons();
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

        private void SetUpQuestionLabels()
        {
            QuestionLabel.Text = quiz.QuizQuestions[quiz.QuestionIndex].QuestionText;
            QuizProgressLabel.Text = $"Question {quiz.QuestionIndex + 1}/{Quiz.numberOfQuestions}";
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
                QuizPageHelpers.AddQuestionResultToDatabase(quiz.QuizQuestions[quiz.QuestionIndex].CorrectAnswer, true);

                AnswerChoiceButtons[buttonIndex].FlatAppearance.BorderColor = Color.Green;
                CorrectAnswerNotifier.Text = "Correct!";
                CorrectAnswerNotifier.Visible = true;
                ++numberCorrect;
            }
            else
            {
                QuizPageHelpers.AddQuestionResultToDatabase(quiz.QuizQuestions[quiz.QuestionIndex].CorrectAnswer, false);

                foreach (Button choiceButton in AnswerChoiceButtons)
                    choiceButton.FlatAppearance.BorderColor = Color.Red;

                AnswerChoiceButtons[correctAnswerIndex].FlatAppearance.BorderColor = Color.Green;

                CorrectAnswerNotifier.Text = $"Incorrect. The correct answer was \"{quiz.QuizQuestions[quiz.QuestionIndex].CorrectAnswer}\".";
                CorrectAnswerNotifier.Visible = true;
            }

            if (quiz.QuestionIndex + 1 >= Quiz.numberOfQuestions)
            {
                FinishButton.Visible = true;
                MessageBox.Show($"You have finished the quiz and scored a {((double)numberCorrect / Quiz.numberOfQuestions) * 100}%! Press \"Finish\" to be taken back to the menu.");
            }

            // Prevent double event from occurring
            NextQuestionButton.Click -= NextQuestionButton_Click;
            NextQuestionButton.Click += NextQuestionButton_Click;
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
            CloseWindow();
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            if (quiz.QuestionIndex + 1 < Quiz.numberOfQuestions)
            {
                quiz.UpdateQuestionIndex();
                SetUpQuestion();
            }       
        }

        private void CloseWindow()
        {
            QuizAttributes.ResetQuizProperties();

            this.DialogResult = DialogResult.OK;
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void MuteButton_Click(object sender, EventArgs e)
        {
            if (Quiz.muted)
            {
                QuizPageHelpers.PlaySetQuizMusic();
                Quiz.muted = false;
            }
            else
            {
                QuizPageHelpers.MuteQuizMusic();
                Quiz.muted = true;
            }
        }
    }
}
