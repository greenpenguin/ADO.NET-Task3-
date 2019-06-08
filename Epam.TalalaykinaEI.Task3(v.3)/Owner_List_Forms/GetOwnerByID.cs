using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epam.TalalaykinaEI.Task3_v._3_
{
    public partial class GetOwnerByID : Form
    {
        private Owner_ListLogic owner_ListLogic = new Owner_ListLogic();
        public GetOwnerByID()
        {
            InitializeComponent();
        }

        private void ownerIDButton_Click(object sender, EventArgs e)
        {
            if (ownerIDTextBox.Text == "")
            {
                MessageBox.Show("Please, fill the field!");
            }
            else
            {
                if (!int.TryParse(ownerIDTextBox.Text, out int result))
                {
                    MessageBox.Show("Value entered is too large!");
                }
                else
                {
                    if (owner_ListLogic.IsOwnerExists(result) == -1)
                    {
                        MessageBox.Show("Owner does not exist!");
                    }
                    else
                    {
                        getOwnerLabel.Text = owner_ListLogic.GetByID(result).ToString();
                    }
                }
            }
        }

        private void ownerIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
