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

namespace Epam.TalalaykinaEI.Task3_v._3_.Meter_Forms
{
    public partial class AddMeterForm : Form
    {
        private MeterLogic meterLogic = new MeterLogic();
        private UtilitieLogic utilitieLogic = new UtilitieLogic();
        public AddMeterForm()
        {
            InitializeComponent();
        }

        private void InstallationDateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void NextCheckDateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void utilitieIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void addMeterButton_Click(object sender, EventArgs e)
        {
            if ((InstallationDateTextBox.Text == "") || (NextCheckDateTextBox.Text == "") ||
                (utilitieIDTextBox.Text == ""))
            {
                MessageBox.Show("Please, fill all fields!");
            }
            else
            {
                DateTime minDateTime = new DateTime(1753, 1, 1);
                DateTime maxDateTime = new DateTime(9999, 12, 31, 23, 59, 59, 997);
                if ((!int.TryParse(utilitieIDTextBox.Text, out int utilitieID)) ||
                    (!DateTime.TryParse(InstallationDateTextBox.Text, out DateTime date)) ||
                    (DateTime.Parse(InstallationDateTextBox.Text) < minDateTime) ||
                    (DateTime.Parse(InstallationDateTextBox.Text) > maxDateTime) ||
                    (!DateTime.TryParse(NextCheckDateTextBox.Text, out DateTime date2)) ||
                    (DateTime.Parse(NextCheckDateTextBox.Text) < minDateTime) ||
                    (DateTime.Parse(NextCheckDateTextBox.Text) > maxDateTime))
                {
                    MessageBox.Show("Something is wrong with the entered values!");
                }
                else
                {
                    if (utilitieLogic.IsUtilitieExists(utilitieID) == -1)
                    {
                        MessageBox.Show("Utilitie does not exist!");
                    }
                    else
                    {
                        meterLogic.Add(new Meter(date, date2, utilitieID));
                    }
                }
            }
        }
    }
}
