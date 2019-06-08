﻿using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epam.TalalaykinaEI.Task3_v._3_.Rate_Archive_Forms
{
    public partial class GetRateByID : Form
    {
        private Rate_ArchiveLogic Rate_ArchiveLogic = new Rate_ArchiveLogic();
        public GetRateByID()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (IDtextBox.Text == "")
            {
                MessageBox.Show("Please, fill the field!");
            }
            else
            {
                if (!int.TryParse(IDtextBox.Text, out int result))
                {
                    MessageBox.Show("Value entered is too large!");
                }
                else
                {
                    if (Rate_ArchiveLogic.IsRateExists(result) == -1)
                    {
                        MessageBox.Show("Rate does not exist!");
                    }
                    else
                    {
                        textLabel.Text = Rate_ArchiveLogic.GetByID(result).ToString();
                    }
                }
            }
        }

        private void IDtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
