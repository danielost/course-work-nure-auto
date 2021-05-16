using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{    
    public partial class CarInfoForm : Form
    {
        public Car currentCar;

        public CarInfoForm(Car car)
        {
            InitializeComponent();
            currentCar = car;
            nameLbl.Text = car.Make + " " + car.Model;
            yearLbl.Text = "Year: " + car.Year;
            typeLbl.Text = "Type: " + car.Type;
            engineLbl.Text = "Engine: " + car.HorsePower + "hp " + car.EngCapacity + "l.";
            conditionLbl.Text = "Condition: " + car.Condition;
            priceLbl.Text = "Price: $" + car.Price.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
