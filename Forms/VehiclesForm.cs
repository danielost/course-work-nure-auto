using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class VehiclesForm : Form
    {
        private CarList carList;
        private bool advSrch;
        Serializer<Car> sr;
        private bool isAdmin;

        public VehiclesForm(bool isAdmin)
        {
            InitializeComponent();
            if (!isAdmin)
            {
                AddCarBtn.Hide();
            }
            carList = new CarList();
            sr = new Serializer<Car>();
            carList.List = sr.Deserialize("cars.save");
            this.isAdmin = isAdmin;
            FlowReset(carList.List);
            advSrch = false;
            AdvancedSearchPanel.Hide();
            searchCondition.SelectedIndex = 0;
            searchOrigin.SelectedIndex = 0;
        }

        private void FlowReset(List<Car> list)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Hide();
            }
            foreach (Car curr in list)
            {
                flowLayoutPanel1.Controls.Add(new CarUnit(curr, isAdmin));
            }
        }

        private void AddCarBtn_Click(object sender, EventArgs e)
        {
            AddCarForm acf = new AddCarForm();
            acf.Show();
        }

        private void AdvSrchBtn_Click(object sender, EventArgs e)
        {
            if (!advSrch)
            {
                
                AdvancedSearchPanel.Show();
                advSrch = true;
            }
            else
            {
                AdvancedSearchPanel.Hide();
                advSrch = false;
            }
        }      

        private void yearFrom_ValueChanged(object sender, EventArgs e)
        {
            if (yearFrom.Value > yearTo.Value)
            {
                decimal temp = yearTo.Value;
                yearTo.Value = yearFrom.Value;
                yearFrom.Value = temp;
            }
        }

        private void yearTo_ValueChanged(object sender, EventArgs e)
        {
            if (yearFrom.Value > yearTo.Value)
            {
                decimal temp = yearTo.Value;
                yearTo.Value = yearFrom.Value;
                yearFrom.Value = temp;
            }
        }

        private void priceFrom_ValueChanged(object sender, EventArgs e)
        {
            if (priceFrom.Value > priceTo.Value)
            {
                decimal temp = priceTo.Value;
                priceTo.Value = priceFrom.Value;
                priceFrom.Value = temp;
            }
        }

        private void priceTo_ValueChanged(object sender, EventArgs e)
        {
            if (priceFrom.Value > priceTo.Value)
            {
                decimal temp = priceTo.Value;
                priceTo.Value = priceFrom.Value;
                priceFrom.Value = temp;
            }
        }

        private void mileageFrom_ValueChanged(object sender, EventArgs e)
        {
            if (mileageFrom.Value > mileageTo.Value)
            {
                decimal temp = mileageTo.Value;
                mileageTo.Value = mileageFrom.Value;
                mileageFrom.Value = temp;
            }
        }

        private void mileageTo_ValueChanged(object sender, EventArgs e)
        {
            if (mileageFrom.Value > mileageTo.Value)
            {
                decimal temp = mileageTo.Value;
                mileageTo.Value = mileageFrom.Value;
                mileageFrom.Value = temp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Car> cars = sr.Deserialize("cars.save");
            string name = MakeTextBox.Text;
            string toFind = String.Concat(name.Where(c => !Char.IsWhiteSpace(c)));

            if (!advSrch)
            {
                foreach (Car car in cars.ToList())
                {
                    if ((car.Make + car.Model).ToLower().IndexOf(toFind.ToLower()) == -1 && (car.Model + car.Make).ToLower().IndexOf(toFind.ToLower()) == -1)
                    {
                        cars.Remove(car);
                    }
                }
            }
            else
            {
                if (AtLeastOneChecked())
                {
                    CheckBox[] cbs = new CheckBox[7] { sedanCheckBox, coupeCheckBox, SUVCheckBox, CUVCheckBox, vanCheckBox, truckCheckBox, supercarCheckBox };
                    for (int i = 0; i < cbs.Length; i++)
                    {
                        if (!cbs[i].Checked)
                        {
                            foreach (Car car in cars.ToList())
                            {
                                if (car.Type == cbs[i].Text)
                                {
                                    cars.Remove(car);
                                }
                            }
                        }
                    }
                }

                foreach (Car car in cars.ToList())
                {
                    if (car.Condition != searchCondition.Text && searchCondition.Text != "Both")
                    {
                        cars.Remove(car);
                    }
                }

                foreach (Car car in cars.ToList())
                {
                    if (car.Origin != searchOrigin.Text && searchOrigin.Text != "All")
                    {
                        cars.Remove(car);
                    }
                }

                foreach (Car car in cars.ToList())
                {
                    if (car.Year < yearFrom.Value || car.Year > yearTo.Value)
                    {
                        cars.Remove(car);
                    }
                }

                foreach (Car car in cars.ToList())
                {
                    if (car.Price < priceFrom.Value || car.Price > priceTo.Value)
                    {
                        cars.Remove(car);
                    }
                }

                foreach (Car car in cars.ToList())
                {
                    if (car.Mileage < mileageFrom.Value || car.Mileage > mileageTo.Value)
                    {
                        cars.Remove(car);
                    }
                }

                foreach (Car car in cars.ToList())
                {
                    if ((car.Make + car.Model).ToLower().IndexOf(toFind.ToLower()) == -1 && (car.Model + car.Make).ToLower().IndexOf(toFind.ToLower()) == -1)
                    {
                        cars.Remove(car);
                    }
                }
            }

            FlowReset(cars);
        }

        private bool AtLeastOneChecked()
        {
            return sedanCheckBox.Checked || coupeCheckBox.Checked || SUVCheckBox.Checked || CUVCheckBox.Checked || vanCheckBox.Checked || truckCheckBox.Checked || supercarCheckBox.Checked;
        }
    }
}
