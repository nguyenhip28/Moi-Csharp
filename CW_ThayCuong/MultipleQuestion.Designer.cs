namespace CW_ThayCuong
{
    partial class MultipleQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultipleQuestion));
            this.question = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.tb_answer1 = new System.Windows.Forms.TextBox();
            this.tb_answer2 = new System.Windows.Forms.TextBox();
            this.tb_answer3 = new System.Windows.Forms.TextBox();
            this.tb_answer4 = new System.Windows.Forms.TextBox();
            this.tb_correctanswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_add_question = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(19, 96);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(49, 13);
            this.question.TabIndex = 0;
            this.question.Text = "Question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Answer 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Answer 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Answer 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Answer 4";
            // 
            // tb_question
            // 
            this.tb_question.Location = new System.Drawing.Point(20, 113);
            this.tb_question.Name = "tb_question";
            this.tb_question.Size = new System.Drawing.Size(302, 20);
            this.tb_question.TabIndex = 5;
            this.tb_question.TextChanged += new System.EventHandler(this.tb_question_TextChanged);
            // 
            // tb_answer1
            // 
            this.tb_answer1.Location = new System.Drawing.Point(20, 190);
            this.tb_answer1.Name = "tb_answer1";
            this.tb_answer1.Size = new System.Drawing.Size(200, 20);
            this.tb_answer1.TabIndex = 6;
            // 
            // tb_answer2
            // 
            this.tb_answer2.Location = new System.Drawing.Point(20, 255);
            this.tb_answer2.Name = "tb_answer2";
            this.tb_answer2.Size = new System.Drawing.Size(200, 20);
            this.tb_answer2.TabIndex = 7;
            // 
            // tb_answer3
            // 
            this.tb_answer3.Location = new System.Drawing.Point(22, 314);
            this.tb_answer3.Name = "tb_answer3";
            this.tb_answer3.Size = new System.Drawing.Size(200, 20);
            this.tb_answer3.TabIndex = 8;
            // 
            // tb_answer4
            // 
            this.tb_answer4.Location = new System.Drawing.Point(23, 378);
            this.tb_answer4.Name = "tb_answer4";
            this.tb_answer4.Size = new System.Drawing.Size(197, 20);
            this.tb_answer4.TabIndex = 9;
            // 
            // tb_correctanswer
            // 
            this.tb_correctanswer.Location = new System.Drawing.Point(251, 189);
            this.tb_correctanswer.Name = "tb_correctanswer";
            this.tb_correctanswer.Size = new System.Drawing.Size(202, 20);
            this.tb_correctanswer.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Correct Answer";
            // 
            // bt_add_question
            // 
            this.bt_add_question.Location = new System.Drawing.Point(309, 225);
            this.bt_add_question.Name = "bt_add_question";
            this.bt_add_question.Size = new System.Drawing.Size(84, 34);
            this.bt_add_question.TabIndex = 12;
            this.bt_add_question.Text = "Add Question";
            this.bt_add_question.UseVisualStyleBackColor = true;
            this.bt_add_question.Click += new System.EventHandler(this.bt_add_question_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(143, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Multiple choice questions";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MultipleQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_add_question);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_correctanswer);
            this.Controls.Add(this.tb_answer4);
            this.Controls.Add(this.tb_answer3);
            this.Controls.Add(this.tb_answer2);
            this.Controls.Add(this.tb_answer1);
            this.Controls.Add(this.tb_question);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.question);
            this.Name = "MultipleQuestion";
            this.Text = "MultipleQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.TextBox tb_answer1;
        private System.Windows.Forms.TextBox tb_answer2;
        private System.Windows.Forms.TextBox tb_answer3;
        private System.Windows.Forms.TextBox tb_answer4;
        private System.Windows.Forms.TextBox tb_correctanswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_add_question;
        private System.Windows.Forms.Button button1;
    }
}