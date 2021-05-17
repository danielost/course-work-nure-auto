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
        string base64Pic;

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
            Serializer<Car> sr = new Serializer<Car>();
            carList.List = sr.Deserialize("cars.save");
            Car newCar = CreateCar();
            newCar.base64image = base64Pic;
            carList.List.Add(newCar);
            sr.Serialize(carList.List, "cars.save");
            MessageBox.Show("Car was successfully added\nPlease reload the page for the new unit to appear");
            this.Close();
        }

        private string ToBase64(string path)
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(path);
            return Convert.ToBase64String(imageArray);
        }

        private void addPicBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                base64Pic = ToBase64(ofd.FileName);
            }
            pictureBox1.Image = Image.FromFile(ofd.FileName);
        }
    }
}
