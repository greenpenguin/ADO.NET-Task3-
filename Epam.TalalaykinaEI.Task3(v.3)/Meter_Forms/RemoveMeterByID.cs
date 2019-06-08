using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epam.TalalaykinaEI.Task3_v._3_.Meter_Forms
{
    public partial class RemoveMeterByID : Form
    {
        private MeterLogic MeterLogic = new MeterLogic();
        public RemoveMeterByID()
        {
            InitializeComponent();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "")
            {
                MessageBox.Show("Please, fill the field!");
            }
            else
            {
                if (!int.TryParse(IDTextBox.Text, out int result))
                {
                    MessageBox.Show("Value entered is too large!");
                }
                else
                {
                    if (MeterLogic.IsMeterExists(result) == -1)
                    {
                        MessageBox.Show("Meter does not exist!");
                    }
                    else
                    {
                        MeterLogic.RemoveByID(result);
                    }
                }
            }
        }

        private void IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
