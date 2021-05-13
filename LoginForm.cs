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
            appUsers.users = sr.readUsers("data.save") as List<User>;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            User user = new User("Gosha", LoginAutoBox.Text, PassAutoBox.Text);

            if (appUsers.Search(user))
            {
                LoginAutoBox.BackColor = Color.Red;
            }
        }

        private void ToRegistrationButton_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
