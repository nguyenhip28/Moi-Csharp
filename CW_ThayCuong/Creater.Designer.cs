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
            this.tb_index = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_modegame
            // 
            this.cb_modegame.FormattingEnabled = true;
            this.cb_modegame.Items.AddRange(new object[] {
            "Multiple choice questions",
            "Open-ended questions",
            "True or false questions"});
            this.cb_modegame.Location = new System.Drawing.Point(24, 35);
            this.cb_modegame.Name = "cb_modegame";
            this.cb_modegame.Size = new System.Drawing.Size(162, 21);
            this.cb_modegame.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Mode Game";
            // 
            // rtb_display
            // 
            this.rtb_display.Location = new System.Drawing.Point(24, 99);
            this.rtb_display.Name = "rtb_display";
            this.rtb_display.Size = new System.Drawing.Size(280, 318);
            this.rtb_display.TabIndex = 2;
            this.rtb_display.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Display All Question";
            // 
            // rb_select
            // 
            this.rb_select.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rb_select.Location = new System.Drawing.Point(220, 27);
            this.rb_select.Name = "rb_select";
            this.rb_select.Size = new System.Drawing.Size(75, 34);
            this.rb_select.TabIndex = 4;
            this.rb_select.Text = "Select";
            this.rb_select.UseVisualStyleBackColor = false;
            this.rb_select.Click += new System.EventHandler(this.rb_select_Click);
            // 
            // bt_display
            // 
            this.bt_display.Location = new System.Drawing.Point(366, 99);
            this.bt_display.Name = "bt_display";
            this.bt_display.Size = new System.Drawing.Size(108, 35);
            this.bt_display.TabIndex = 5;
            this.bt_display.Text = "Display Question";
            this.bt_display.UseVisualStyleBackColor = true;
            this.bt_display.Click += new System.EventHandler(this.bt_display_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(366, 181);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(108, 35);
            this.bt_edit.TabIndex = 7;
            this.bt_edit.Text = "Edit Question";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(366, 223);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(108, 35);
            this.bt_delete.TabIndex = 8;
            this.bt_delete.Text = "Delete Question";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // tb_index
            // 
            this.tb_index.Location = new System.Drawing.Point(366, 264);
            this.tb_index.Name = "tb_index";
            this.tb_index.Size = new System.Drawing.Size(108, 20);
            this.tb_index.TabIndex = 9;
            // 
            // Creater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.tb_index);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_display);
            this.Controls.Add(this.rb_select);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_display);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_modegame);
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
        private System.Windows.Forms.TextBox tb_index;
    }
}





