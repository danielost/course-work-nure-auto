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
    public partial class CarUnit : UserControl
    {
        private Car currentCar;
        private bool isAdmin;

        public CarUnit(Car car, bool isAdmin)
        {
            InitializeComponent();
            carName.Text = $"{car.Year} {car.Make} {car.Model}";
            carPrice.Text = "$" + car.Price.ToString();
            if (car.base64image != null)
            {
                CarPic.Image = FromBase64(car.base64image);
            }           
            currentCar = car;
            if (!isAdmin)
            {
                DelCarBtn.Hide();
            }
            this.isAdmin = isAdmin;
        }

        private Image FromBase64(string base64pic)
        {
            if (base64pic != null)
            {
                byte[] bytes = Convert.FromBase64String(base64pic);

                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
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

        private void DelCarBtn_Click_1(object sender, EventArgs e)
        {
            CarList carList = new CarList();
            Serializer<Car> sr = new Serializer<Car>();
            carList.List = sr.Deserialize("cars.save");
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
    }
}
