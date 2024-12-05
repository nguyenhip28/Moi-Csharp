namespace CW_ThayCuong
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.U = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_roll = new System.Windows.Forms.ComboBox();
            this.Roll = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // U
            // 
            this.U.AutoSize = true;
            this.U.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.U.Location = new System.Drawing.Point(241, 178);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(55, 13);
            this.U.TabIndex = 0;
            this.U.Text = "Username";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(298, 175);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(202, 20);
            this.tb_username.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(298, 217);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(202, 20);
            this.tb_password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(241, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // cb_roll
            // 
            this.cb_roll.FormattingEnabled = true;
            this.cb_roll.Items.AddRange(new object[] {
            "Admin",
            "Player"});
            this.cb_roll.Location = new System.Drawing.Point(298, 255);
            this.cb_roll.Name = "cb_roll";
            this.cb_roll.Size = new System.Drawing.Size(202, 21);
            this.cb_roll.TabIndex = 4;
            // 
            // Roll
            // 
            this.Roll.AutoSize = true;
            this.Roll.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Roll.Location = new System.Drawing.Point(258, 260);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(25, 13);
            this.Roll.TabIndex = 5;
            this.Roll.Text = "Roll";
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(350, 293);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(87, 34);
            this.bt_login.TabIndex = 6;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 97);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.Roll);
            this.Controls.Add(this.cb_roll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.U);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label U;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_roll;
        private System.Windows.Forms.Label Roll;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

