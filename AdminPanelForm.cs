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
    public partial class AdminPanelForm : Form
    {
        private bool isCreated;
        private Serializer<CarOperation> operationSr;

        public AdminPanelForm()
        {
            InitializeComponent();
            isCreated = false;
            operationSr = new Serializer<CarOperation>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists("carOperations.save"))
            {
                MessageBox.Show("No data");
                return;
            }

            isCreated = true;
            DateTime timeFrom = dateTimePickerFrom.Value;
            DateTime timeTo = dateTimePickerFrom.Value;

            List<CarOperation> operations = operationSr.Deserialize("carOperations.save");

            foreach (CarOperation curr in operations)
            {
                if (DateTime.Compare(curr.Time, timeFrom) < 0 && DateTime.Compare(curr.Time, timeTo) > 0)
                {
                    textBox1.Text += $"{curr.Car.Make} ";
                }

            }
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dateTimePickerFrom.Value, dateTimePickerTo.Value) > 0)
            {
                DateTime temp = dateTimePickerFrom.Value;
                dateTimePickerFrom.Value = dateTimePickerTo.Value;
                dateTimePickerTo.Value = temp;
            }
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dateTimePickerFrom.Value, dateTimePickerTo.Value) > 0)
            {
                DateTime temp = dateTimePickerFrom.Value;
                dateTimePickerFrom.Value = dateTimePickerTo.Value;
                dateTimePickerTo.Value = temp;
            }
        }
    }
}
