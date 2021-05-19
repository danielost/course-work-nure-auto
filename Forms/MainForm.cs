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
        private Form currentChildForm;
        private bool isAdmin;
        private bool isSupplier;
        private User currUser;

        public MainForm(User user)
        {
            InitializeComponent();
            currUser = user;
            wlcmLbl.Text = "Welcome, " + user.Name;

            if (user.Status == "admin")
            {
                isAdmin = true;
            }
            else isAdmin = false;

            if (user.Status == "supplier")
            {
                isSupplier = true;
            }
            else isSupplier = false;

            if (!isAdmin)
            {
                if (isSupplier)
                {
                    adminPanelBtn.Hide();
                }
                else
                {
                    requestSupplyBtn.Hide();
                    adminPanelBtn.Hide();
                }              
            }

            

            ActivateBtn(catalogBtn);
            OpenChildForm(new VehiclesForm(isAdmin));
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
            OpenChildForm(new VehiclesForm(isAdmin));
        }

        private void contactsBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            OpenChildForm(new ContactsForm());
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
            OpenChildForm(new AccForm(currUser));
        }

        private void logOutBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
