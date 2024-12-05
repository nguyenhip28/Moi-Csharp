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

namespace CW_ThayCuong
{
    public partial class Login : Form
    {
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
                    Creater form_creater = new Creater();
                    form_creater.ShowDialog();
                }
                if (cb_roll.Text == "Player")
                {
                    Player form_player = new Player();
                    form_player.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }
    }
}
