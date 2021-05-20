﻿using Newtonsoft.Json;
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
            Serializer<User> sr = new Serializer<User>();
            appUsers.users = sr.Deserialize("data.save");
            WrongDataLabel.ForeColor = Color.FromArgb(217, 217, 217);
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            User user = new User("", LoginAutoBox.Text, PassAutoBox.Text, "");

            User fromJson = appUsers.Search(user);

            if (fromJson != null)
            {
                this.Hide();
                MainForm mf = new MainForm(fromJson);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm(new User("Admin", "admin", "12345", "admin"));
            mf.Show();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (PassAutoBox.UseSystemPasswordChar)
            {
                PassAutoBox.UseSystemPasswordChar = false;
            }
            else
            {
                PassAutoBox.UseSystemPasswordChar = true;
            }
        }
    }
}
