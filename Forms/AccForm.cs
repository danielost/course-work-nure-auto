using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AccForm : Form
    {
        private User user;

        public AccForm(User user)
        {
            InitializeComponent();
            this.user = user;
            usernameLbl.Text = "Username: " + user.Name;
            loginLbl.Text = "Login: " + user.Login;
            passwordLbl.Text = user.Password;
            statusLbl.Text = "Status: " + user.Status;
            passwordLbl.Hide();
            editLogin.Hide();
            editUserName.Hide();
            editPassword.Hide();
        }

        private void passBtn_Click(object sender, EventArgs e)
        {
            if (!passwordLbl.Visible)
            {
                passwordLbl.Show();
                passBtn.Text = "(Click to hide)";
            }
            else
            {
                passwordLbl.Hide();
                passBtn.Text = "(Click to show)";
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            usernameLbl.Text = "Username: ";
            loginLbl.Text = "Login: ";
            passwordLbl.Hide();
            passBtn.Hide();
            editLogin.Show();
            editUserName.Show();
            editPassword.Show();
        }
    }
}
