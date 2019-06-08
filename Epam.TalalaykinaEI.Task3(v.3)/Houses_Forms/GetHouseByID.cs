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

namespace Epam.TalalaykinaEI.Task3_v._3_.Houses_Forms
{
    public partial class GetHouseByID : Form
    {
        private HouseLogic houseLogic = new HouseLogic();
        public GetHouseByID()
        {
            InitializeComponent();
        }

        private void getHouseByIDButton_Click(object sender, EventArgs e)
        {
            if (houseIDTextBox.Text == "")
            {
                MessageBox.Show("Please, fill the field!");
            }
            else
            {
                if (!int.TryParse(houseIDTextBox.Text, out int result))
                {
                    MessageBox.Show("Value entered is too large!");
                }
                else
                {
                    if (houseLogic.IsHouseExists(result) == -1)
                    {
                        MessageBox.Show("House does not exist!");
                    }
                    else
                    {
                        getHouseLabel.Text = houseLogic.GetByID(result).ToString();
                    }
                }
            }
        }

        private void houseIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
