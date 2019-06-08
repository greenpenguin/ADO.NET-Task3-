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

namespace Epam.TalalaykinaEI.Task3_v._3_.Rate_Archive_Forms
{
    public partial class AddRateForm : Form
    {
        private Rate_ArchiveLogic rate_ArchiveLogic = new Rate_ArchiveLogic();
        public AddRateForm()
        {
            InitializeComponent();
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void addRateButton_Click(object sender, EventArgs e)
        {
            if ((rateStartDateTextBox.Text == "") || (priceTextBox.Text == ""))
            {
                MessageBox.Show("Please, fill all fields!");
            }
            else
            {
                DateTime minDateTime = new DateTime(1753, 1, 1);
                DateTime maxDateTime = new DateTime(9999, 12, 31, 23, 59, 59, 997);
                if ((!DateTime.TryParse(rateStartDateTextBox.Text, out DateTime date)) ||
                    (DateTime.Parse(rateStartDateTextBox.Text) < minDateTime) ||
                    (DateTime.Parse(rateStartDateTextBox.Text) > maxDateTime) ||
                    (!double.TryParse(priceTextBox.Text, out double price)))
                {
                    MessageBox.Show("Something is wrong with the entered values!");
                }
                else
                {
                    rate_ArchiveLogic.Add(new Rate_Archive(date, price));
                }
            }

        }

    }
}
