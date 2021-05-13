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
            return tb.Text.Length > 2;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (!LengthCheck(RegLogin) || !LengthCheck(RegName) || !LengthCheck(RegPass) || !LengthCheck(RegPassConfirm))
            {
                return;
            }
            if (RegPass.Text != RegPassConfirm.Text)
            {
                return;
            }
            User user = new User(RegName.Text, RegLogin.Text, RegPass.Text);
            Serializer sr = new Serializer();
            List<User> readUsers = sr.Deserialize("data.save") as List<User>;
            foreach(User currUser in readUsers)
            {
                if (currUser.Password == user.Password)
                {
                    return;
                }
                if (currUser.Login == user.Login)
                {
                    return;
                }
            }
            readUsers.Add(user);
            sr.Serialize(readUsers, "data.save");
        }
    }
}
