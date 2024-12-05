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
    public partial class Creater : Form
    {
        public List<Question> question_bank = new List<Question>();
        public Creater()
        {
            InitializeComponent();
        }

        private void rb_select_Click(object sender, EventArgs e)
        {
            if (cb_modegame.Text == "Multiple choice questions")
            {
                MultipleQuestion form_multiplequestion = new MultipleQuestion(question_bank);
                form_multiplequestion.ShowDialog();
            }
            if (cb_modegame.Text == "Open-ended questions")
            {
                OpenEndedQuestions form_openquestion = new OpenEndedQuestions(question_bank);
                form_openquestion.ShowDialog();
            }
            if (cb_modegame.Text == "True or false questions")
            {
                TrueorFalseQuestions form_truefalse = new TrueorFalseQuestions(question_bank);
                form_truefalse.ShowDialog();
            }

        }

        private void bt_display_Click(object sender, EventArgs e)
        {
            rtb_display.Clear();

            if (question_bank.Count == 0)
            {
                rtb_display.Text = "No questions available to display.";
                return;
            }
            foreach (var question in question_bank)
            {
                rtb_display.AppendText("Question: " + question.QuestionText + Environment.NewLine);



                if (question is MultipleChoiceQuestion multiplechoicequestion)
                {
                    rtb_display.AppendText("Options:" + Environment.NewLine);
                    for (int i = 0; i < multiplechoicequestion.Options.Length; i++)
                    {
                        rtb_display.AppendText($"  {i + 1}. {multiplechoicequestion.Options[i]}" + Environment.NewLine);
                    }
                    rtb_display.AppendText("Correct Answer: " + multiplechoicequestion.CorrectAnswer + Environment.NewLine);
                }



                else if (question is TrueOrFalseQuestion TrueOrFalse)
                {
                    rtb_display.AppendText("Answer: " + (TrueOrFalse.IsTrue ? "True" : "False") + Environment.NewLine);
                }



                else if (question is OpenEndQuestion OpenEnd)
                {
                    rtb_display.AppendText("Acceptable Answers:" + Environment.NewLine);
                    foreach (var answer in OpenEnd.AcceptableAnswers)
                    {
                        rtb_display.AppendText($"  - {answer}" + Environment.NewLine);
                    }
                }

                rtb_display.AppendText(new string('-', 50) + Environment.NewLine);
            }
        }

    }
}
