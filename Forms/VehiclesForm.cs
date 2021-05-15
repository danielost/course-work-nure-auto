using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class VehiclesForm : Form
    {
        private CarList carList;

        public VehiclesForm()
        {
            InitializeComponent();
            carList = new CarList();
            Serializer sr = new Serializer();
            carList.List = sr.DeserializeCar("cars.save") as List<Car>;
            foreach (Car curr in carList.List)
            {
                flowLayoutPanel1.Controls.Add(new CarUnit(curr));
            }
        }
        
        private void FlowReset()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void AddCarBtn_Click(object sender, EventArgs e)
        {
            AddCarForm acf = new AddCarForm();
            acf.Show();
        }
    }
}
