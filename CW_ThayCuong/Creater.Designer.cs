namespace CW_ThayCuong
{
    partial class Creater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creater));
            this.cb_modegame = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_display = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_select = new System.Windows.Forms.Button();
            this.bt_display = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_modegame
            // 
            this.cb_modegame.FormattingEnabled = true;
            this.cb_modegame.Items.AddRange(new object[] {
            "Multiple choice questions",
            "Open-ended questions",
            "True or false questions"});
            this.cb_modegame.Location = new System.Drawing.Point(32, 43);
            this.cb_modegame.Margin = new System.Windows.Forms.Padding(4);
            this.cb_modegame.Name = "cb_modegame";
            this.cb_modegame.Size = new System.Drawing.Size(215, 24);
            this.cb_modegame.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Mode Game";
            // 
            // rtb_display
            // 
            this.rtb_display.Location = new System.Drawing.Point(32, 122);
            this.rtb_display.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_display.Name = "rtb_display";
            this.rtb_display.Size = new System.Drawing.Size(372, 390);
            this.rtb_display.TabIndex = 2;
            this.rtb_display.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(35, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Display All Question";
            // 
            // rb_select
            // 
            this.rb_select.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rb_select.Location = new System.Drawing.Point(293, 33);
            this.rb_select.Margin = new System.Windows.Forms.Padding(4);
            this.rb_select.Name = "rb_select";
            this.rb_select.Size = new System.Drawing.Size(100, 42);
            this.rb_select.TabIndex = 4;
            this.rb_select.Text = "Select";
            this.rb_select.UseVisualStyleBackColor = false;
            this.rb_select.Click += new System.EventHandler(this.rb_select_Click);
            // 
            // bt_display
            // 
            this.bt_display.Location = new System.Drawing.Point(488, 122);
            this.bt_display.Margin = new System.Windows.Forms.Padding(4);
            this.bt_display.Name = "bt_display";
            this.bt_display.Size = new System.Drawing.Size(144, 43);
            this.bt_display.TabIndex = 5;
            this.bt_display.Text = "Display Question";
            this.bt_display.UseVisualStyleBackColor = true;
            this.bt_display.Click += new System.EventHandler(this.bt_display_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(488, 223);
            this.bt_edit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(144, 43);
            this.bt_edit.TabIndex = 7;
            this.bt_edit.Text = "Edit Question";
            this.bt_edit.UseVisualStyleBackColor = true;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(488, 274);
            this.bt_delete.Margin = new System.Windows.Forms.Padding(4);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(144, 43);
            this.bt_delete.TabIndex = 8;
            this.bt_delete.Text = "Delete Question";
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // Creater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(715, 554);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_display);
            this.Controls.Add(this.rb_select);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_display);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_modegame);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Creater";
            this.Text = "Creater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_modegame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rb_select;
        private System.Windows.Forms.Button bt_display;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_delete;
    }
}