using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{    
    public partial class CarInfoForm : Form
    {
        private Car currentCar;
        private Serializer<Car> sr;
        private CarList carList;
        private BaseImageConverter bic;

        public CarInfoForm(Car car, bool isAdmin)
        {
            InitializeComponent();
            bic = new BaseImageConverter();
            sr = new Serializer<Car>();
            carList = new CarList();
            if (!isAdmin)
            {
                editBtn.Hide();
            }
            EditBtnsHide();
            currentCar = car;
            Reload(car);           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            carList.List = sr.Deserialize("cars.save");
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
            editPhotoBtn.Show();
            editMileage.Show();
            editOrigin.Show();
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
            editPhotoBtn.Hide();
            editMileage.Hide();
            editOrigin.Hide();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            editCapacity.Value = (decimal)currentCar.EngCapacity;
            editCondition.Text = currentCar.Condition;
            editPower.Value = currentCar.HorsePower;
            editPrice.Value = currentCar.Price;
            editType.Text = currentCar.Type;
            editYear.Value = currentCar.Year;
            editMileage.Value = currentCar.Mileage;
            editOrigin.Text = currentCar.Origin;
            EditBtnsShow();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            carList.List = sr.Deserialize("cars.save");
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
                    currentCar.Mileage = (int)editMileage.Value;
                    currentCar.Origin = editOrigin.Text;
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
            priceLbl.Text = "$" + car.Price.ToString();
            mileageLbl.Text = "Mileage: " + car.Mileage;
            originLbl.Text = "Origin: " + car.Origin;
            if (car.base64image != null)
            {
                infoFormCarPic.Image = bic.FromBase64(car.base64image);
            }            
        }

        private void editPhotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            carList.List = sr.Deserialize("cars.save");
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                currentCar.base64image = bic.ToBase64(ofd.FileName);
                infoFormCarPic.Image = Image.FromFile(ofd.FileName);
            }
            for (int i = carList.List.Count - 1; i >= 0; i--)
            {
                if (carList.List[i].Compare(currentCar))
                {
                    carList.List[i] = currentCar;
                }
            }
            sr.Serialize(carList.List, "cars.save");
        }
    }
}
