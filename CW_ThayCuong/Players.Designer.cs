namespace CW_ThayCuong
{
    partial class Players
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
            this.rtb_question = new System.Windows.Forms.RichTextBox();
            this.rtb_answer = new System.Windows.Forms.RichTextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_nextquestion = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_question
            // 
            this.rtb_question.Location = new System.Drawing.Point(12, 81);
            this.rtb_question.Name = "rtb_question";
            this.rtb_question.Size = new System.Drawing.Size(216, 146);
            this.rtb_question.TabIndex = 0;
            this.rtb_question.Text = "";
            // 
            // rtb_answer
            // 
            this.rtb_answer.Location = new System.Drawing.Point(245, 81);
            this.rtb_answer.Name = "rtb_answer";
            this.rtb_answer.Size = new System.Drawing.Size(216, 236);
            this.rtb_answer.TabIndex = 1;
            this.rtb_answer.Text = "";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(26, 233);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(84, 39);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_nextquestion
            // 
            this.btn_nextquestion.Location = new System.Drawing.Point(129, 233);
            this.btn_nextquestion.Name = "btn_nextquestion";
            this.btn_nextquestion.Size = new System.Drawing.Size(83, 39);
            this.btn_nextquestion.TabIndex = 3;
            this.btn_nextquestion.Text = "Next Question";
            this.btn_nextquestion.UseVisualStyleBackColor = true;
            this.btn_nextquestion.Click += new System.EventHandler(this.btn_nextquestion_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(77, 278);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(84, 39);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Answer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Welcome Player";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_nextquestion);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.rtb_answer);
            this.Controls.Add(this.rtb_question);
            this.Name = "Player";
            this.Text = "Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_question;
        private System.Windows.Forms.RichTextBox rtb_answer;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_nextquestion;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}