using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class LoginForm : Form
    {
        AppUsers appUsers;

        public LoginForm()
        {
            InitializeComponent();
            appUsers = new AppUsers();
            Serializer sr = new Serializer();
            appUsers.users = sr.DeserializeUser("data.save") as List<User>;
            WrongDataLabel.ForeColor = Color.FromArgb(217, 217, 217);
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            User user = new User("", LoginAutoBox.Text, PassAutoBox.Text, "");

            if (appUsers.Search(user))
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.Show();
            }
            else
            {
                WrongDataLabel.ForeColor = Color.Red;
            }
        }

        private bool LengthCheck(TextBox tb)
        {
            return tb.Text.Length == 0;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ToRegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm suf = new SignUpForm();
            suf.Show();
        }
    }
}
