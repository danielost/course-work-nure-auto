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
        }

        public Car CreateCar()
        {
            return new Car(addMake.Text, addModel.Text, Convert.ToDouble(addCapacity.Text), Convert.ToInt32(addPower.Text), addType.Text, addCondition.Text, Convert.ToInt32(addPrice.Text), Convert.ToInt32(addYear.Text));
        }

        public void AddCarBtn_Click(object sender, EventArgs e)
        {
            CarList carList = new CarList();
            Serializer sr = new Serializer();
            carList.List = sr.DeserializeCar("cars.save") as List<Car>;
            carList.List.Add(CreateCar());
            sr.Serialize(carList.List, "cars.save");
            MessageBox.Show("Car was successfully added");
            this.Close();
        }
    }
}
