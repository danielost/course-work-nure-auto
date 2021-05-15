using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class CarUnit : UserControl
    {
        public CarUnit(Car car)
        {
            InitializeComponent();
            carName.Text = $"{car.Year} {car.Make} {car.Model}";
            carPrice.Text = car.Price.ToString();
        }
    }
}
