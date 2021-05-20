﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class SuppliesForm : Form
    {
        private CarRequest cr;
        private Serializer<Car> sr;
        private List<Car> cars;
        public SuppliesForm(string login)
        {
            InitializeComponent();
            cr = new CarRequest(login);
            if (cr.Read("supplierLogin.txt") == login && File.Exists("request.save") && cr.Read("status.txt") != "declined")
            {
                sr = new Serializer<Car>();
                cars = sr.Deserialize("request.save");
                ReqCurrent.DataSource = cars;
                HideCurrent();
            }
            if (cars == null)
            {
                CurrReqLbl.Text = "Current requests – you have no requests";
                HideControls();
            }
        }

        private void HideCurrent()
        {
            ReqCurrent.Columns["EngCapacity"].Visible = false;
            ReqCurrent.Columns["HorsePower"].Visible = false;
            ReqCurrent.Columns["Type"].Visible = false;
            ReqCurrent.Columns["EngCapacity"].Visible = false;
            ReqCurrent.Columns["Condition"].Visible = false;
            ReqCurrent.Columns["base64image"].Visible = false;
            ReqCurrent.Columns["Mileage"].Visible = false;
            ReqCurrent.Columns["Origin"].Visible = false;
        }

        private void HideControls()
        {
            AcceptBtn.Hide();
            DeclineBtn.Hide();
            textBox1.Hide();
            dateTimePicker1.Hide();
        }

        private void DeclineBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please leave a comment on denial");           
                return;
            }


            DialogResult dialogResult = MessageBox.Show("Are you sure to decline?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cr.Write("declined", "status.txt");
                ReqCurrent.DataSource = null;
                CurrReqLbl.Text = "Current requests – you have no requests";
                HideControls();
            }
        }
    }
}
