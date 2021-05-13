using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        private Button currentBtn;
        //private Form currentChildForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //private void OpenChildForm(Form form)
        //{

        //}

        private void ActivateBtn(object btn)
        {
            if (btn != null)
            {
                DisableBtn();
                currentBtn = btn as Button;
                currentBtn.BackColor = Color.FromArgb(60, 110, 113);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                labelCurr.Text = currentBtn.Text;
            }
        }

        private void DisableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(40, 75, 99);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void catalogBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
        }

        private void contactsBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
        }

        private void requestSupplyBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
        }

        private void adminPanelBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableBtn();
            labelCurr.Text = "Home";
        }
    }
}
