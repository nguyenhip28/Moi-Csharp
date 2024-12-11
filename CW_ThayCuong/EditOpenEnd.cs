using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuizApp;

namespace CW_ThayCuong
{
    public partial class EditOpenEnd : Form
    {
        private OpenEndQuestion question;
        private int questionIndex;
        private List<Question> questionBank;

        public EditOpenEnd(List<Question> questionBank, int index)
        {
            InitializeComponent();
            this.questionBank = questionBank;
            this.questionIndex = index;

            // Ép kiểu để lấy câu hỏi open-ended
            this.question = questionBank[index] as OpenEndQuestion;

            if (this.question != null)
            {
                rtb_question.Text = question.QuestionText;
                rtb_answer.Text = string.Join("\n", question.AcceptableAnswers);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            question.QuestionText = rtb_question.Text;
            question.AcceptableAnswers = new List<string>(rtb_answer.Text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries));
            MessageBox.Show("Question updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
