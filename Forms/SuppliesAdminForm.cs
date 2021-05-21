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
    public partial class SuppliesAdminForm : Form
    {
        private CarRequest cr;
        private Serializer<User> srUser;
        private Serializer<Car> srCar;
        private Serializer<CarOperation> srOperation;
        List<Car> currentList;

        public SuppliesAdminForm()
        {
            InitializeComponent();
            srUser = new Serializer<User>();
            srCar = new Serializer<Car>();
            srOperation = new Serializer<CarOperation>();
            cr = new CarRequest("login");
            textBox1.Hide();
            CreateCurrentGrid();
        }

        private void ReqButton_Click(object sender, EventArgs e)
        {
            if (currentList != null)
            {
                MessageBox.Show("A request already exists");
                return;
            }

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
            cr.Write(LoginTextBox.Text, "supplierLogin.txt");
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

            Car newCar = new Car(MakeTextBox.Text, ModelTextBox.Text, 2.0, 160, "Sedan", "Brand new", (int)PriceTextBox.Value, 2021, 0, "USA");
            for (int i = 0; i < AmountUpDown.Value; i++)
            {
                cr.requestedCars.Add(newCar);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (cr.requestedCars.Count < 3)
            {
                MessageBox.Show("You can't request less, than 3 cars");
                return;
            }

            NewReqGrid.DataSource = null;


            srCar.Serialize(cr.requestedCars, "request.save");

            CreateCurrentGrid();
            MessageBox.Show("The request was successfully created. Wait for the response of the supplier");
        }

        private void CreateCurrentGrid()
        {
            if (srCar.Deserialize("request.save") != null)
            {
                currentList = srCar.Deserialize("request.save");
                ReqCurrent.DataSource = currentList;
                AddButton.Hide();
                button1.Hide();
                addToTheCatalogueBtn.Show();
                cancelBtn.Show();
                HideCurrent();

                MakeTextBox.Text = "";
                ModelTextBox.Text = "";
                AmountUpDown.Value = 1;

                supLbl.Text = "Supplier: " + cr.Read("supplierLogin.txt");

                

                if (File.Exists("status.txt"))
                {
                    string status = cr.Read("status.txt");
                    statusLbl.Text = "Status: " + status;
                    if (status == "declined")
                    {
                        textBox1.Show();
                        textBox1.Text = cr.Read("comment.txt");
                    }
                    if (status == "accepted")
                    {
                        cancelBtn.Hide();
                    }
                    if (File.Exists("time.txt"))
                    {
                        string time = cr.Read("time.txt");
                        DateTime parsedTime = DateTime.Parse(time);
                        if (DateTime.Compare(DateTime.Now, parsedTime) > 0)
                        {
                            statusLbl.Text = "Status: arrived";
                        }
                    }                   
                }
                else
                {
                    statusLbl.Text = "Status: none";
                }

            }

            if (currentList == null)
            {
                addToTheCatalogueBtn.Hide();
                cancelBtn.Hide();
            }
        }

        private void HideCurrent()
        {
            ReqCurrent.Columns["EngCapacity"].Visible = false;
            ReqCurrent.Columns["HorsePower"].Visible = false;
            ReqCurrent.Columns["Type"].Visible = false;
            ReqCurrent.Columns["EngCapacity"].Visible = false;
            ReqCurrent.Columns["Condition"].Visible = false;
            ReqCurrent.Columns["base64image"].Visible = false;
            ReqCurrent.Columns["Mileage"].Visible = false;
            ReqCurrent.Columns["Origin"].Visible = false;
        }

        private void addToTheCatalogueBtn_Click(object sender, EventArgs e)
        {
            if (statusLbl.Text != "Status: arrived")
            {
                MessageBox.Show("The request isn't here yet");
                return;
            }
            List<Car> cars = srCar.Deserialize("cars.save");
            foreach (Car car in currentList)
            {
                cars.Add(car);
            }
            srCar.Serialize(cars, "cars.save");
            MessageBox.Show("The cars are successfully added");
            File.Delete("status.txt");
            File.Delete("request.save");
            File.Delete("supplierLogin.txt");
            File.Delete("time.txt");
            List<CarOperation> operation = new List<CarOperation>();
            if (File.Exists("carOperations.save"))
            {
                operation = srOperation.Deserialize("carOperations.save");
            }
            foreach (Car car in currentList)
            {
                operation.Add(new CarOperation(car, false));
            }
            srOperation.Serialize(operation, "carOperations.save");
            Clear();
        }

        private void Clear()
        {
            File.Delete("request.save");
            ReqCurrent.DataSource = null;
            currentList = null;
            addToTheCatalogueBtn.Hide();
            cancelBtn.Hide();
            AddButton.Show();
            button1.Show();
            statusLbl.Text = "Status: none";
            supLbl.Text = "Supplier: none";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Clear();
                textBox1.Hide();
                File.Delete("status.txt");
            }            
            else return;
        }
    }
}
