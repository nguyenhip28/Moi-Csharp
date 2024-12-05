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
    public partial class TrueorFalseQuestions : Form
    {
        public List<Question> question_bank = new List<Question>();
        public TrueorFalseQuestions(List<Question> question_bank)
        {
            InitializeComponent();
            this.question_bank = question_bank;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string questionText = rtb_question.Text.Trim();
            if (string.IsNullOrWhiteSpace(questionText))
            {
                MessageBox.Show("Please enter a valid question.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cb_answer.SelectedItem == null)
            {
                MessageBox.Show("Please select an answer (True or False).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isTrue = cb_answer.SelectedItem.ToString() == "True";
            var newQuestion = new TrueOrFalseQuestion(questionText, isTrue);

            question_bank.Add(newQuestion);
            this.Close();
            rtb_question.Clear();
            cb_answer.SelectedIndex = -1;

            MessageBox.Show("Question added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
