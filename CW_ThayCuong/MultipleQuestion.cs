using QuizApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_ThayCuong
{
    public partial class MultipleQuestion : Form
    {
        public List<Question> question_bank = new List<Question>();
        public MultipleQuestion(List<Question> question_bank)
        {
            InitializeComponent();
            this.question_bank = question_bank;
        }

        private void bt_add_question_Click(object sender, EventArgs e)
        {
            try
            {
                string question = tb_question.Text.Trim();

                if (string.IsNullOrWhiteSpace(tb_question.Text))
                {
                    MessageBox.Show("Question cannot be empty.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tb_correctanswer.Text))
                {
                    MessageBox.Show("Correct Answer cannot be empty.");
                    return;
                }
                string[] option = new string[4];
                option[0] = tb_answer1.Text.Trim();
                option[1] = tb_answer2.Text.Trim();
                option[2] = tb_answer3.Text.Trim();
                option[3] = tb_answer4.Text.Trim();

                if (option.Any(Option => string.IsNullOrWhiteSpace(Option)))
                {
                    MessageBox.Show("All choices must be filled in.");
                    return;
                }
                int correctAnswer = Convert.ToInt32(tb_correctanswer.Text);

                MultipleChoiceQuestion newQuestion = new MultipleChoiceQuestion(question, correctAnswer, option);
                question_bank.Add(newQuestion);
                MessageBox.Show("A question was Added");
                this.Close();   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void tb_question_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
