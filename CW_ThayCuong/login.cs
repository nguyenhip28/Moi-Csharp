using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizApp;

namespace CW_ThayCuong
{
    public partial class Login : Form
    {
        Creater form_creater = new Creater();
        public Login()
        {
            InitializeComponent();
            tb_password.PasswordChar = '*';
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "nguyenvt" && tb_password.Text == "123")
            {
                if (cb_roll.Text == "Admin")
                {
                    form_creater.ShowDialog();
                }
                if (cb_roll.Text == "Player")
                {
                    Players form_player = new Players(form_creater.question_bank);
                    form_player.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cb_roll_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
