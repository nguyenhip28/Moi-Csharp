using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuizApp;

namespace CW_ThayCuong
{
    public partial class EditTrueFalse : Form
    {
        private TrueOrFalseQuestion question;
        private int questionIndex;
        private List<Question> questionBank;

        public EditTrueFalse(List<Question> questionBank, int index)
        {
            InitializeComponent();
            this.questionBank = questionBank;
            this.questionIndex = index;

            // Ép kiểu để lấy câu hỏi True/False
            this.question = questionBank[index] as TrueOrFalseQuestion;

            if (this.question != null)
            {
                rtb_question.Text = question.QuestionText;
                cb_answer.SelectedIndex = question.IsTrue ? 0 : 1; 
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            question.QuestionText = rtb_question.Text;
            question.IsTrue = cb_answer.SelectedIndex == 0;
            MessageBox.Show("Question updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
