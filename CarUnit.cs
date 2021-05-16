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
        Car currentCar;
        public CarUnit(Car car)
        {
            InitializeComponent();
            carName.Text = $"{car.Year} {car.Make} {car.Model}";
            carPrice.Text = "$" + car.Price.ToString();
            currentCar = car;
        }

        private void DelCarBtn_Click(object sender, EventArgs e)
        {
            CarList carList = new CarList();
            Serializer sr = new Serializer();
            carList.List = sr.DeserializeCar("cars.save") as List<Car>;
            for (int i = carList.List.Count - 1; i >= 0; i--)
            {
                if (carList.List[i].Compare(currentCar))
                {
                    carList.List.RemoveAt(i);
                }
            }
            sr.Serialize(carList.List, "cars.save");
            this.Hide();
        }

        private void CarPic_Click(object sender, EventArgs e)
        {
            Panel parent = (Panel)Parent.Parent;
            //parent.Controls.Clear();
            CarInfoForm cif = new CarInfoForm(currentCar);
            cif.TopLevel = false;
            cif.FormBorderStyle = FormBorderStyle.None;
            cif.Dock = DockStyle.Fill;
            parent.Controls.Add(cif);
            parent.Tag = cif;
            cif.BringToFront();
            cif.Show();
        }
    }
}
