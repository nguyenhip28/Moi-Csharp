namespace CW_ThayCuong
{
    partial class EditOpenEnd
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.rtb_answer = new System.Windows.Forms.RichTextBox();
            this.rtb_question = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(141, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Open-ended questions";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(182, 295);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(97, 37);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // rtb_answer
            // 
            this.rtb_answer.Location = new System.Drawing.Point(251, 92);
            this.rtb_answer.Name = "rtb_answer";
            this.rtb_answer.Size = new System.Drawing.Size(201, 181);
            this.rtb_answer.TabIndex = 9;
            this.rtb_answer.Text = "";
            // 
            // rtb_question
            // 
            this.rtb_question.Location = new System.Drawing.Point(9, 92);
            this.rtb_question.Name = "rtb_question";
            this.rtb_question.Size = new System.Drawing.Size(203, 181);
            this.rtb_question.TabIndex = 8;
            this.rtb_question.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Question";
            // 
            // EditOpenEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.rtb_answer);
            this.Controls.Add(this.rtb_question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditOpenEnd";
            this.Text = "EditOpenEnd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.RichTextBox rtb_answer;
        private System.Windows.Forms.RichTextBox rtb_question;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}