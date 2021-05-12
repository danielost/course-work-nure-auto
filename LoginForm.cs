using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class LoginForm : Form
    {
        User curr;
        public LoginForm()
        {
            InitializeComponent();
            Serializer sr = new Serializer();
            curr = sr.JsonDeserialize(typeof(User), "data.save") as User;       
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            User user = new User("Gosha", "gosha228", "123456789");
            Serializer sr = new Serializer();
            sr.JsonSerialize(user);
        }

        private void ToRegistrationButton_Click(object sender, EventArgs e)
        {
            User user = new User("Gosha", LoginAutoBox.Text, PassAutoBox.Text);
            if (curr.Password == user.Password)
            {
                LoginAutoBox.BackColor = Color.Red;
            }
        }
    }
}
