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

        public VehiclesForm()
        {
            InitializeComponent();
            carList = new CarList();
            Serializer sr = new Serializer();
            carList.List = sr.DeserializeCar("cars.save") as List<Car>;
            foreach (Car curr in carList.List)
            {
                flowLayoutPanel1.Controls.Add(new CarUnit(curr));
                //AddUnit(curr);
            }
        }
        
        private void FlowReset()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        //private void AddUnit(Car car)
        //{
        //    Panel pnl = new Panel();
        //    pnl.Size = new Size(335, 270);
        //    pnl.BackColor = Color.Gray;           
        //    PictureBox pb = new PictureBox();
        //    pb.SizeMode = PictureBoxSizeMode.Zoom;
        //    pb.Image = Image.FromFile(@"C:\Users\Daniel\Desktop\2 Семестр\ООП\Курсовая\Car Dealeship\assets\car.png");
        //    pnl.Controls.Add(pb);
        //    pb.Dock = DockStyle.Top;
        //    pb.Height = 170;
        //    Label delLbl = new Label();
        //    delLbl.Width = 10;
        //    delLbl.Text = "Delete";
        //    pnl.Controls.Add(delLbl);
        //    delLbl.Dock = DockStyle.Top;
        //    delLbl.TextAlign = ContentAlignment.MiddleRight;
        //    delLbl.Padding = new Padding(2);
        //    delLbl.Height = 35;
        //    Label carName = new Label();
        //    carName.Text = $"{car.Year} {car.Make} {car.Model}";
        //    pnl.Controls.Add(carName);
        //    carName.Height = 30;
        //    carName.Dock = DockStyle.Bottom;
        //    Label carPrice = new Label();
        //    carPrice.Text = "$" + car.Price.ToString();
        //    pnl.Controls.Add(carPrice);
        //    carPrice.Dock = DockStyle.Bottom;
        //    flowLayoutPanel1.Controls.Add(pnl);
        //    carName.Margin = new Padding(0, 0, 0, 30);
        //    carName.Font = new Font("Roboto", 18, FontStyle.Regular);
        //    carPrice.Font = new Font("Roboto", 14, FontStyle.Regular);
        //    delLbl.Font = new Font("Roboto", 12, FontStyle.Regular);
        //}

        private void AddCarBtn_Click(object sender, EventArgs e)
        {
            AddCarForm acf = new AddCarForm();
            acf.Show();
        }
    }
}
