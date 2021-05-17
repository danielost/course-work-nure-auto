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
        private Car currentCar;
        private bool isAdmin;

        public CarUnit(Car car, bool isAdmin)
        {
            InitializeComponent();
            carName.Text = $"{car.Year} {car.Make} {car.Model}";
            carPrice.Text = "$" + car.Price.ToString();
            //CarPic.Image = car.CarPic;
            currentCar = car;
            if (!isAdmin)
            {
                DelCarBtn.Hide();
            }
            this.isAdmin = isAdmin;
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
            CarInfoForm cif = new CarInfoForm(currentCar, isAdmin);
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
