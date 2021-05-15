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
        public VehiclesForm()
        {
            InitializeComponent();
        }
        
        private void FlowReset()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void AddUnit()
        {
            Car car = new Car("Dodge", "Challenger", 5.7, 375, "coupe", "brand new", 25000);
            Panel pnl = new Panel();
            pnl.Size = new Size(335, 270);
            pnl.BackColor = Color.Gray;
            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Image = Image.FromFile(@"C:\Users\Daniel\Desktop\2 Семестр\ООП\Курсовая\Car Dealeship\assets\car.png");
            pnl.Controls.Add(pb);
            pb.Dock = DockStyle.Top;
            pb.Height = 200;
            Label carName = new Label();
            carName.Text = car.Make + " " + car.Model;
            pnl.Controls.Add(carName);
            carName.Dock = DockStyle.Bottom;
            Label carPrice = new Label();
            carPrice.Text = car.Price.ToString();
            pnl.Controls.Add(carPrice);
            carPrice.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Controls.Add(pnl);
            carName.Padding = new Padding(2);
            carName.Font = new Font("Roboto", 16, FontStyle.Regular);
            carPrice.Font = new Font("Roboto", 12, FontStyle.Regular);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FlowReset();
            AddUnit();
        }
    }
}
