using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizApp;

namespace CW_ThayCuong
{
    public partial class EditMultipleChoice : Form
    {
        List<Question> question_bank = new List<Question>();
        int questionIndex;
        public EditMultipleChoice(List<Question> question_bank, int index)
        {
            InitializeComponent();
            this.question_bank = question_bank;
            this.questionIndex = index;

            if (index >= 0 && index < question_bank.Count)
            {
                var selectedQuestion = question_bank[index];
            }
            else
            {
                MessageBox.Show("Invalid question index");
            }
            display();
        }
        private void display()
        {
            tb_question.Clear();
            if (question_bank[questionIndex] is MultipleChoiceQuestion multipleChoice)
            {
                tb_question.Text += multipleChoice.QuestionText;
                tb_answer1.Text = multipleChoice.Options[0];
                tb_answer2.Text = multipleChoice.Options[1];
                tb_answer3.Text = multipleChoice.Options[2];
                tb_answer4.Text = multipleChoice.Options[3];

                tb_correctanswer.Text += multipleChoice.CorrectAnswer + 1;
            }
        }
        private void bt_edit_question_Click(object sender, EventArgs e)
        {
            try
            {
                string questionText = tb_question.Text.Trim();
                if (string.IsNullOrEmpty(questionText))
                {
                    MessageBox.Show("Question cannot be empty.");
                    return;
                }

                string[] Options = new string[4];
                Options[0] = tb_answer1.Text.Trim();
                Options[1] = tb_answer2.Text.Trim();
                Options[2] = tb_answer3.Text.Trim();
                Options[3] = tb_answer4.Text.Trim();

                if (Options.Any(string.IsNullOrWhiteSpace))
                {
                    MessageBox.Show("All options must be provide and cannot be empty");
                    return;
                }

                int correctAns = Convert.ToInt32(tb_correctanswer.Text.Trim());
                if (correctAns < 1 || correctAns > 4)
                {
                    MessageBox.Show("Correct Answer must be a number 1, 2, 3, 4");
                    return;
                }

                correctAns -= 1;
                if (question_bank[questionIndex] is MultipleChoiceQuestion multipleChoiceQuestion)
                {
                    multipleChoiceQuestion.QuestionText = questionText;
                    multipleChoiceQuestion.Options = Options;
                    multipleChoiceQuestion.CorrectAnswer = correctAns;

                    MessageBox.Show("Question has been edit!");
                    this.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
