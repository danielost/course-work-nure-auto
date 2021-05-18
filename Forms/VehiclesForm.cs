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

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Car> cars = sr.Deserialize("cars.save");
            if (comboBox1.Text == "Price Ascending")
            {
                CarSort.BubbleSortPriceAsc(cars);
            }
            if (comboBox1.Text == "Price Descending")
            {
                CarSort.BubbleSortPriceDesc(cars);
            }
            if (comboBox1.Text == "Name (A-Z)")
            {
                CarSort.BubbleSortNameAsc(cars);
            }
            else
            {
                CarSort.BubbleSortNameDesc(cars);
            }
            FlowReset(cars);
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
    }
}
