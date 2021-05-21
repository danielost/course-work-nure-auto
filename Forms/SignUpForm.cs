using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(600, 600);
            WrongDataLabel.ForeColor = Color.FromArgb(217, 217, 217);
        }

        private void ToRegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private bool LengthCheck(TextBox tb)
        {
            return tb.Text.Length == 0;
        }

        private void SignUp()
        {
            if (LengthCheck(RegName))
            {
                WrongDataLabel.Text = "You didn't enter the name";
                WrongDataLabel.ForeColor = Color.Red;
                return;
            }
            if (LengthCheck(RegLogin))
            {
                WrongDataLabel.Text = "You didn't enter the login";
                WrongDataLabel.ForeColor = Color.Red;
                return;
            }
            if (LengthCheck(RegPass))
            {
                WrongDataLabel.Text = "You didn't enter the password";
                WrongDataLabel.ForeColor = Color.Red;
                return;
            }
            

            if (RegLogin.Text.Length < 4)
            {
                WrongDataLabel.Text = "Minimum login length is 4 symbols";
                WrongDataLabel.ForeColor = Color.Red;
                return;
            }
            if (RegPass.Text.Length < 6)
            {
                WrongDataLabel.Text = "Minimum password length is 6 symbols";
                WrongDataLabel.ForeColor = Color.Red;
                return;
            }

            for (int i = 0; i < RegLogin.Text.Length; i++)
            {
                if (RegLogin.Text[i] == ' ')
                {
                    WrongDataLabel.Text = "White spaces are not allowed in the login";
                    WrongDataLabel.ForeColor = Color.Red;
                    return;
                }
            }

            for (int i = 0; i < RegPass.Text.Length; i++)
            {
                if (RegPass.Text[i] == ' ')
                {
                    WrongDataLabel.Text = "White spaces are not allowed in the password";
                    WrongDataLabel.ForeColor = Color.Red;
                    return;
                }
            }

            if (LengthCheck(RegPassConfirm))
            {
                WrongDataLabel.Text = "You didn't confirm the password";
                WrongDataLabel.ForeColor = Color.Red;
                return;
            }
            if (RegPass.Text != RegPassConfirm.Text)
            {
                WrongDataLabel.Text = "Password confirmation was not successful";
                WrongDataLabel.ForeColor = Color.Red;
                return;
            }

            User user = new User(RegName.Text, RegLogin.Text, RegPass.Text, "user");
            Serializer<User> sr = new Serializer<User>();
            List<User> readUsers = sr.Deserialize("data.save");
            foreach (User currUser in readUsers)
            {
                if (currUser.Login == user.Login)
                {
                    WrongDataLabel.Text = "This login is already taken by someone else";
                    WrongDataLabel.ForeColor = Color.Red;
                    return;
                }
            }
            WrongDataLabel.ForeColor = Color.FromArgb(217, 217, 217);
            readUsers.Add(user);
            sr.Serialize(readUsers, "data.save");
            MessageBox.Show("Account was successfully created");
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUp();
        }

        private void SignUpForm_Enter(object sender, EventArgs e)
        {
            SignUp();
        }
    }
}
