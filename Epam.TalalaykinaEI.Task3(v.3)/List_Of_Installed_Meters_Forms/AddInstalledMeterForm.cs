using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entities;

namespace Epam.TalalaykinaEI.Task3_v._3_.List_Of_Installed_Meters_Forms
{
    public partial class AddInstalledMeterForm : Form
    {
        private List_Of_Installed_MetersLogic list_Of_Installed_MetersLogic = new List_Of_Installed_MetersLogic();
        private MeterLogic meterLogic = new MeterLogic();
        public AddInstalledMeterForm()
        {
            InitializeComponent();
        }

        private void meterReadingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void meterIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void addMeterButton_Click(object sender, EventArgs e)
        {
            if ((meterIDTextBox.Text == "") || (maskedDateTextBox.Text == "") ||
                (meterReadingTextBox.Text == ""))
            {
                MessageBox.Show("Please, fill all fields!");
            }
            else
            {
                DateTime minDateTime = new DateTime(1753, 1, 1);
                DateTime maxDateTime = new DateTime(9999, 12, 31, 23, 59, 59, 997);
                if ((!int.TryParse(meterIDTextBox.Text, out int meterID)) ||
                    (!DateTime.TryParse(maskedDateTextBox.Text, out DateTime date)) ||
                    (DateTime.Parse(maskedDateTextBox.Text) < minDateTime) ||
                    (DateTime.Parse(maskedDateTextBox.Text) > maxDateTime) ||
                    (!double.TryParse(meterReadingTextBox.Text, out double meterReading)))
                {
                    MessageBox.Show("Something is wrong with the entered values!");
                }
                else
                {
                    if (meterLogic.IsMeterExists(meterID) == -1)
                    {
                        MessageBox.Show("Meter does not exist!");
                    }

                    else
                    {
                        list_Of_Installed_MetersLogic.Add(new List_Of_Installed_Meters(meterID, date, meterReading));
                    }
                }
            
            }
        
        }

        private void AddInstalledMeterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
