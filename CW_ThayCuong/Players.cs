using QuizApp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace CW_ThayCuong
{
    public partial class Players : Form
    {
        List<Question> question_bank; 
        private int currentQuestionIndex;   
        private int score;                  
        private Stopwatch stopwatch;

        public Players(List<Question> question_bank)
        {
            InitializeComponent();

            if (question_bank == null || question_bank.Count == 0)
            {
                MessageBox.Show("The question bank is empty. Please add questions before starting.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close(); 
                return;
            }

            this.question_bank = question_bank;
            currentQuestionIndex = 0;
            score = 0;

            btn_nextquestion.Enabled = false;
            btn_submit.Enabled = false;
            stopwatch = new Stopwatch(); 
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
 
            currentQuestionIndex = 0;
            score = 0;
            btn_nextquestion.Enabled = true;
            btn_submit.Enabled = false;

            stopwatch.Reset(); 
            stopwatch.Start(); 

            DisplayQuestion();
        }

        private void btn_nextquestion_Click(object sender, EventArgs e)
        {
            if (!CheckAnswer())
            {
                return; 
            }

            currentQuestionIndex++;
            if (currentQuestionIndex < question_bank.Count)
            {
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show("You've reached the last question. Click Submit to finish the quiz.",
                                "Quiz Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_nextquestion.Enabled = false;
                btn_submit.Enabled = true;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            stopwatch.Stop(); 
            TimeSpan elapsedTime = stopwatch.Elapsed; 

            MessageBox.Show($"Quiz finished! Your score is {score}/{question_bank.Count}.\n" +
                                $"Time taken: {elapsedTime.Minutes} minutes and {elapsedTime.Seconds} seconds.",
                                "Quiz Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetQuiz();
        }

        private void DisplayQuestion()
        {
            var currentQuestion = question_bank[currentQuestionIndex];
            rtb_question.Text = currentQuestion.QuestionText;


            rtb_answer.Clear();

            switch (currentQuestion)
            {
                case MultipleChoiceQuestion mcq:
                    rtb_question.Text += "\nOptions:\n";
                    for (int i = 0; i < mcq.Options.Length; i++)
                    {
                        rtb_question.Text += $"{i + 1}. {mcq.Options[i]}\n";
                    }
                    break;

                case TrueOrFalseQuestion tofq:
                    rtb_question.Text += "\nAnswer with 'True' or 'False'.";
                    break;

                case OpenEndQuestion oeq:
                    rtb_question.Text += "\nType your answer below.";
                    break;
            }
        }

        private bool CheckAnswer()
        {
            var currentQuestion = question_bank[currentQuestionIndex];
            string userAnswer = rtb_answer.Text.Trim();

            if (string.IsNullOrEmpty(userAnswer))
            {
                MessageBox.Show("Please enter an answer before proceeding.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }

            switch (currentQuestion)
            {
                case MultipleChoiceQuestion mcq:
                    if (int.TryParse(userAnswer, out int selectedOption) &&
                        selectedOption == mcq.CorrectAnswer)
                    {
                        score++;
                    }
                    break;

                case TrueOrFalseQuestion tofq:
                    if (bool.TryParse(userAnswer, out bool userResponse) && userResponse == tofq.IsTrue)
                    {
                        score++;
                    }
                    break;

                case OpenEndQuestion oeq:
                    if (oeq.AcceptableAnswers.Any(ans => ans.Equals(userAnswer, StringComparison.OrdinalIgnoreCase)))
                    {
                        score++;
                    }

                    break;

                default:
                    MessageBox.Show("Unknown question type.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
            }

            return true; 
        }

        private void ResetQuiz()
        {
            rtb_question.Clear();
            rtb_answer.Clear();
            currentQuestionIndex = 0;
            score = 0;
            btn_nextquestion.Enabled = false;
            btn_submit.Enabled = false;

            stopwatch.Reset(); 
        }
    }
}
