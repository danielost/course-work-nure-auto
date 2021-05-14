﻿using System;
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
        private Form currentChildForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OpenChildForm(Form form)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            mainPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }

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

        private void button1_Click(object sender, EventArgs e)
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

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}