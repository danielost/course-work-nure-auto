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
        private Serializer<CarOperation> operationSr;
        private CarList carList;
        private BaseImageConverter bic;

        public CarInfoForm(Car car, bool isAdmin)
        {
            InitializeComponent();
            bic = new BaseImageConverter();
            sr = new Serializer<Car>();
            operationSr = new Serializer<CarOperation>();
            carList = new CarList();
            if (!isAdmin)
            {
                editBtn.Hide();
            }           
            currentCar = car;
            EditBtnsHide();
            Reload(car);           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this vehicle?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
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
                List<CarOperation> operation = new List<CarOperation>();
                if (File.Exists("carOperations.save"))
                {
                    operation = operationSr.Deserialize("carOperations.save");
                }
                operation.Add(new CarOperation(currentCar, true));
                operationSr.Serialize(operation, "carOperations.save");

                MessageBox.Show("Congratulations! You just bought a new car.");
                this.Close();
            }          
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
            cancelBtn.Show();


            yearLbl.Text = "Year: ";
            typeLbl.Text = "Type: ";
            engineLbl.Text = "Engine: ";
            conditionLbl.Text = "Condition: ";
            priceLbl.Text = "";
            mileageLbl.Text = "Mileage: ";
            originLbl.Text = "Origin: ";
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
            cancelBtn.Hide();

            Reload(currentCar);
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            EditBtnsHide();
        }
    }
}
