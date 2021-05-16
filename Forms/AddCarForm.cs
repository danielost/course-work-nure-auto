using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
            addType.SelectedIndex = 0;
            addCondition.SelectedIndex = 0;
        }

        public Car CreateCar()
        {
            return new Car(addMake.Text, addModel.Text, Convert.ToDouble(addCapacity.Text), Convert.ToInt32(addPower.Text), addType.Text, addCondition.Text, Convert.ToInt32(addPrice.Text), Convert.ToInt32(addYear.Text));
        }

        public void AddCarBtn_Click(object sender, EventArgs e)
        {
            if (addMake.Text == "")
            {
                MessageBox.Show("Make field is empty");
                return;
            }
            if (addModel.Text == "")
            {
                MessageBox.Show("Model field is empty");
                return;
            }
            if (addYear.Text == "")
            {
                MessageBox.Show("Year field is empty");
                return;
            }
            if (addType.Text == "")
            {
                MessageBox.Show("Type field is empty");
                return;
            }
            if (addPower.Text == "")
            {
                MessageBox.Show("Horse power field is empty");
                return;
            }
            if (addCapacity.Text == "")
            {
                MessageBox.Show("Capacity field is empty");
                return;
            }                 
            if (addCondition.Text == "")
            {
                MessageBox.Show("Condition field is empty");
                return;
            }
            if (addPrice.Text == "")
            {
                MessageBox.Show("Price field is empty");
                return;
            }
            CarList carList = new CarList();
            Serializer sr = new Serializer();
            carList.List = sr.DeserializeCar("cars.save") as List<Car>;
            carList.List.Add(CreateCar());
            sr.Serialize(carList.List, "cars.save");
            MessageBox.Show("Car was successfully added\nPlease reload the page for the new unit to appear");
            this.Close();
        }
    }
}
