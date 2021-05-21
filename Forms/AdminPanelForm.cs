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
        private int income;

        public AdminPanelForm()
        {
            InitializeComponent();
            isCreated = false;
            operationSr = new Serializer<CarOperation>();
            income = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists("carOperations.save"))
            {
                MessageBox.Show("No data");
                return;
            }

            textBox1.Text = "";
            isCreated = true;
            DateTime timeFrom = dateTimePickerFrom.Value;
            DateTime timeTo = dateTimePickerTo.Value;

            List<CarOperation> operations = operationSr.Deserialize("carOperations.save");

            textBox1.Text += $"Report for {timeFrom} - {timeTo}";
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(Environment.NewLine);

            foreach (CarOperation curr in operations)
            {
                if (DateTime.Compare(curr.Time, timeFrom) > 0 && DateTime.Compare(curr.Time, timeTo) < 0)
                {
                    textBox1.Text += $"{curr.Car.Year} {curr.Car.Make} {curr.Car.Model} - ";
                    if (curr.IsSold)
                    {
                        textBox1.Text += $"sold for ${curr.Car.Price} on ";
                        income += curr.Car.Price;
                    }
                    else
                    {
                        textBox1.Text += $"acquired for ${curr.Car.Price} on ";
                        income -= curr.Car.Price;
                    }
                    textBox1.Text += curr.Time;
                    textBox1.AppendText(Environment.NewLine);
                    textBox1.AppendText(Environment.NewLine);
                }
            }
            textBox1.Text += "Profit: " + income;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isCreated)
            {
                MessageBox.Show("First you need to create a report");
                return;
            }

            string date = DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss");
            date = date.Replace(':', '_').Replace("’", "").Replace("‘", "");

            File.WriteAllText("report_for_" + date + ".txt", textBox1.Text);

            MessageBox.Show("The report has been successfully saved");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!File.Exists("carOperations.save"))
            {
                MessageBox.Show("No data");
                return;
            }

            textBox1.Text = "";
            isCreated = true;

            List<CarOperation> operations = operationSr.Deserialize("carOperations.save");

            textBox1.Text += "Report for all time";
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(Environment.NewLine);

            foreach (CarOperation curr in operations)
            {
                textBox1.Text += $"{curr.Car.Year} {curr.Car.Make} {curr.Car.Model} - ";
                if (curr.IsSold)
                {
                    textBox1.Text += $"sold for ${curr.Car.Price} on ";
                    income += curr.Car.Price;
                }
                else
                {
                    textBox1.Text += $"acquired for ${curr.Car.Price} on ";
                    income -= curr.Car.Price;
                }
                textBox1.Text += curr.Time;
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText(Environment.NewLine);
            }
            textBox1.Text += "Profit: " + income;
        }
    }
}
