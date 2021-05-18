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

        public VehiclesForm(bool isAdmin)
        {
            InitializeComponent();
            if (!isAdmin)
            {
                AddCarBtn.Hide();
            }
            carList = new CarList();
            Serializer<Car> sr = new Serializer<Car>();
            carList.List = sr.Deserialize("cars.save");
            foreach (Car curr in carList.List)
            {
                flowLayoutPanel1.Controls.Add(new CarUnit(curr, isAdmin));
            }
            advSrch = false;
            AdvancedSearchPanel.Hide();
        }
        
        private void FlowReset()
        {
            flowLayoutPanel1.Controls.Clear();
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
    }
}
