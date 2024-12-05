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
    public partial class OpenEndedQuestions : Form
    {
        public List<Question> question_bank = new List<Question>();
        public OpenEndedQuestions(List<Question> question_bank)
        {
            InitializeComponent();
            this.question_bank = question_bank;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string questionText = richTextBox1.Text.Trim();
            string answersText = richTextBox2.Text.Trim();
            if (string.IsNullOrEmpty(questionText))
            {
                MessageBox.Show("Please enter a question.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(answersText))
            {
                MessageBox.Show("Please enter at least one acceptable answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> acceptableAnswers = new List<string>(answersText.Split(','));

            OpenEndQuestion newQuestion = new OpenEndQuestion(questionText, acceptableAnswers);

            question_bank.Add(newQuestion);


            MessageBox.Show("Question added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
    
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void OpenEndedQuestions_Load(object sender, EventArgs e)
        {

        }
    }
}