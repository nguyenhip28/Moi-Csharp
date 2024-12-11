namespace CW_ThayCuong
{
    partial class EditTrueFalse
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
            this.cb_answer = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.rtb_question = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_answer
            // 
            this.cb_answer.FormattingEnabled = true;
            this.cb_answer.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cb_answer.Location = new System.Drawing.Point(244, 86);
            this.cb_answer.Name = "cb_answer";
            this.cb_answer.Size = new System.Drawing.Size(121, 21);
            this.cb_answer.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(103, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "True or False Question";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(258, 211);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(97, 37);
            this.btn_edit.TabIndex = 16;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // rtb_question
            // 
            this.rtb_question.Location = new System.Drawing.Point(4, 86);
            this.rtb_question.Name = "rtb_question";
            this.rtb_question.Size = new System.Drawing.Size(203, 181);
            this.rtb_question.TabIndex = 15;
            this.rtb_question.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Question";
            // 
            // EditTrueFalse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 315);
            this.Controls.Add(this.cb_answer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.rtb_question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditTrueFalse";
            this.Text = "EditTrueFalse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_answer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.RichTextBox rtb_question;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}