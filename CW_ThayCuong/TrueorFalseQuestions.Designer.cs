namespace CW_ThayCuong
{
    partial class TrueorFalseQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrueorFalseQuestions));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.rtb_question = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_answer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(121, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "True or False Question";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(266, 208);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(97, 37);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // rtb_question
            // 
            this.rtb_question.Location = new System.Drawing.Point(12, 83);
            this.rtb_question.Name = "rtb_question";
            this.rtb_question.Size = new System.Drawing.Size(203, 181);
            this.rtb_question.TabIndex = 8;
            this.rtb_question.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Question";
            // 
            // cb_answer
            // 
            this.cb_answer.FormattingEnabled = true;
            this.cb_answer.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cb_answer.Location = new System.Drawing.Point(252, 83);
            this.cb_answer.Name = "cb_answer";
            this.cb_answer.Size = new System.Drawing.Size(121, 21);
            this.cb_answer.TabIndex = 12;
            // 
            // TrueorFalseQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(419, 290);
            this.Controls.Add(this.cb_answer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.rtb_question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TrueorFalseQuestions";
            this.Text = "TrueorFalseQuestions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.RichTextBox rtb_question;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_answer;
    }
}