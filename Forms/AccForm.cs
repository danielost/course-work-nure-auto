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
            Reload();
            statusLbl.Text = "Status: " + user.Status;
            passwordLbl.Hide();
            editLogin.Hide();
            editUserName.Hide();
            editPassword.Hide();
            editLogin.Text = user.Login;
            editUserName.Text = user.Name;
            editPassword.Text = user.Password;
            saveBtn.Hide();
            cancelBtn.Hide();
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
            saveBtn.Show();
            cancelBtn.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            usernameLbl.Text = "Username: " + user.Name;
            loginLbl.Text = "Login: " + user.Login;
            passwordLbl.Text = user.Password;
            statusLbl.Text = "Status: " + user.Status;
            passwordLbl.Hide();
            editLogin.Hide();
            editUserName.Hide();
            editPassword.Hide();
            passBtn.Show();
            editLogin.Text = user.Login;
            editUserName.Text = user.Name;
            editPassword.Text = user.Password;

            saveBtn.Hide();
            cancelBtn.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Serializer<User> sr = new Serializer<User>();
            AppUsers users = new AppUsers();
            users.users = sr.Deserialize("data.save");
            for (int i = 0; i < users.users.Count; i++)
            {
                if (users.users[i].Compare(user))
                {
                    user.Name = editUserName.Text;
                    user.Login = editLogin.Text;
                    user.Password = editPassword.Text;
                    users.users[i] = user;
                }
            }
            sr.Serialize(users.users, "data.save");

            usernameLbl.Text = "Username: " + user.Name;
            loginLbl.Text = "Login: " + user.Login;
            passwordLbl.Text = user.Password;
            statusLbl.Text = "Status: " + user.Status;
            passwordLbl.Hide();
            editLogin.Hide();
            editUserName.Hide();
            editPassword.Hide();
            passBtn.Show();
            editLogin.Text = user.Login;
            editUserName.Text = user.Name;
            editPassword.Text = user.Password;
            saveBtn.Hide();
            cancelBtn.Hide();

            Reload();
        }

        private void Reload()
        {
            usernameLbl.Text = "Username: " + user.Name;
            loginLbl.Text = "Login: " + user.Login;
            passwordLbl.Text = user.Password;
            statusLbl.Text = "Status: " + user.Status;
        }
    }
}
