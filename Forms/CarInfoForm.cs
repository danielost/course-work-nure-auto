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
        private Car currentCar;
        private Serializer sr;
        private CarList carList;

        public CarInfoForm(Car car, bool isAdmin)
        {
            InitializeComponent();
            if (!isAdmin)
            {
                editBtn.Hide();
            }
            EditBtnsHide();
            currentCar = car;
            Reload(car);
            sr = new Serializer();
            carList = new CarList();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            carList.List = sr.DeserializeCar("cars.save") as List<Car>;
            for (int i = carList.List.Count - 1; i >= 0; i--)
            {
                if (carList.List[i].Compare(currentCar))
                {
                    carList.List.RemoveAt(i);
                }
            }
            sr.Serialize(carList.List, "cars.save");
            MessageBox.Show("Congratulations! You just bought a new car.");
            this.Close();
        }

        private void EditBtnsShow()
        {
            editYear.Show();
            editCapacity.Show();
            editCondition.Show();
            editPower.Show();
            editPrice.Show();
            editType.Show();
            SaveBtn.Show();
        }

        private void EditBtnsHide()
        {
            editYear.Hide();
            editCapacity.Hide();
            editCondition.Hide();
            editPower.Hide();
            editPrice.Hide();
            editType.Hide();
            SaveBtn.Hide();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            editCapacity.Value = (decimal)currentCar.EngCapacity;
            editCondition.Text = currentCar.Condition;
            editPower.Value = currentCar.HorsePower;
            editPrice.Value = currentCar.Price;
            editType.Text = currentCar.Type;
            editYear.Value = currentCar.Year;
            EditBtnsShow();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            carList.List = sr.DeserializeCar("cars.save") as List<Car>;
            for (int i = carList.List.Count - 1; i >= 0; i--)
            {
                if (carList.List[i].Compare(currentCar))
                {
                    currentCar.Year = (int)editYear.Value;
                    currentCar.Type = editType.Text;
                    currentCar.HorsePower = (int)editPower.Value;
                    currentCar.EngCapacity = (double)editCapacity.Value;
                    currentCar.Condition = editCondition.Text;
                    currentCar.Price = (int)editPrice.Value;
                    carList.List[i] = currentCar;
                }
            }
            sr.Serialize(carList.List, "cars.save");
            EditBtnsHide();
            Reload(currentCar);
        }

        private void Reload(Car car)
        {
            nameLbl.Text = car.Make + " " + car.Model;
            yearLbl.Text = "Year: " + car.Year;
            typeLbl.Text = "Type: " + car.Type;
            engineLbl.Text = "Engine: " + car.HorsePower + "hp " + car.EngCapacity + "l.";
            conditionLbl.Text = "Condition: " + car.Condition;
            priceLbl.Text = "Price: $" + car.Price.ToString();
            //infoFormCarPic.Image = car.CarPic;
        }
    }
}
