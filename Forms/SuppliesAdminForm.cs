using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class SuppliesAdminForm : Form
    {
        private CarRequest cr;
        private Serializer<User> srUser;
        private Serializer<Car> srCar;

        public SuppliesAdminForm()
        {
            InitializeComponent();
            srUser = new Serializer<User>();
            srCar = new Serializer<Car>();
        }

        private void ReqButton_Click(object sender, EventArgs e)
        {
            List<User> users = srUser.Deserialize("data.save");
            bool exists = false;
            foreach (User currUser in users)
            {
                if (currUser.Login == LoginTextBox.Text)
                {
                    exists = true;
                    break;
                }
            }
            if (!exists)
            {
                MessageBox.Show("There is no supplier with such login registered");
                return;
            }
            cr = new CarRequest(LoginTextBox.Text);
            Reload();

            HideInfo();
        }

        private void HideInfo()
        {
            NewReqGrid.Columns["EngCapacity"].Visible = false;
            NewReqGrid.Columns["HorsePower"].Visible = false;
            NewReqGrid.Columns["Type"].Visible = false;
            NewReqGrid.Columns["EngCapacity"].Visible = false;
            NewReqGrid.Columns["Condition"].Visible = false;
            NewReqGrid.Columns["base64image"].Visible = false;
            NewReqGrid.Columns["Mileage"].Visible = false;
            NewReqGrid.Columns["Origin"].Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (cr == null)
            {
                MessageBox.Show("You didn't create a request");
                return;
            }

            if (MakeTextBox.Text == "")
            {
                MessageBox.Show("Enter the car make, please");
                return;
            }
            if (ModelTextBox.Text == "")
            {
                MessageBox.Show("Enter the car model, please");
                return;
            }

            Car newCar = new Car(MakeTextBox.Text, ModelTextBox.Text, 2.0, 160, "sedan", "Brand new", (int)PriceTextBox.Value, 2021, 0, "USA");
            cr.requestedCars.Add(newCar);
            Reload();
        }

        private void Reload()
        {
            NewReqGrid.DataSource = null;
            NewReqGrid.DataSource = cr.requestedCars;
            HideInfo();
        }

        private void NewReqGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                return;
            }
        }
    }
}
