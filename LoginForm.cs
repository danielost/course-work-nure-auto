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
        public LoginForm()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\Users\\Daniel\\Desktop\\2 Семестр\\ООП\\Курсовая\\CourseWork\\assets\\logo.bmp");
        }
    }
}
