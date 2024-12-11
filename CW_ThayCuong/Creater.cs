using QuizApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void bt_edit_Click(object sender, EventArgs e)
        {
            string questionMode = cb_modegame.Text;
            int index = Convert.ToInt32(tb_index.Text)-1;

            if(questionMode == "Multiple choice questions")
            {
                EditMultipleChoice form_editmultiplechoice = new EditMultipleChoice(question_bank, index);
                form_editmultiplechoice.ShowDialog();
                
            }
            if (questionMode == "Open-ended questions")
            {
                EditOpenEnd form_editopenend = new EditOpenEnd(question_bank, index);
                form_editopenend.ShowDialog();
            }

            if (questionMode == "True or false questions")
            {
                EditTrueFalse form_edittruefalse = new EditTrueFalse(question_bank, index);
                form_edittruefalse.ShowDialog();
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string questionIndex = tb_index.Text.Trim();
            if (string.IsNullOrEmpty(questionIndex))
            {
                MessageBox.Show("Please enter the index of the question to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(questionIndex, out int index) || index < 1 || index > question_bank.Count)
            {
                MessageBox.Show("Invalid question index. Please provide a valid number within range.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirmation = MessageBox.Show(
                $"Are you sure you want to delete question:{index}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmation == DialogResult.Yes)
            {
                question_bank.RemoveAt(index - 1);
                MessageBox.Show("Question deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_index.Clear();
                bt_display_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Deletion canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}







