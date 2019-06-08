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

namespace Epam.TalalaykinaEI.Task3_v._3_.Utilitie_Forms
{
    public partial class AddUtilitieForm : Form
    {
        string utilitieType;
        string unit;
        private UtilitieLogic utilitieLogic = new UtilitieLogic();
        private Rate_ArchiveLogic rate_ArchiveLogic = new Rate_ArchiveLogic();
        public AddUtilitieForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addRateButton_Click(object sender, EventArgs e)
        {
            if ((rateIDTextBox.Text == "") || (utilitieType == null))
            {
                MessageBox.Show("Please, fill all fields!");
            }
            else
            {
                    if ((!int.TryParse(rateIDTextBox.Text, out int rateID)))
                    {
                        MessageBox.Show("Something is wrong with the entered values!");
                    }
                    else
                    {

                        if (rate_ArchiveLogic.IsRateExists(rateID) == -1)
                        {
                            MessageBox.Show("Rate does not exist!");
                        }
                        else
                        {
                            utilitieLogic.Add(new Utilitie(utilitieType, unit, rateID));
                        }
                    }
                }
            }
        

        private void rateIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            utilitieType = comboBox1.SelectedItem.ToString();
            if (utilitieType == "Heating")
            {
                unit = "gcal";
            }
            else if (utilitieType == "Electricity")
            {
                unit = "kwh";
            }
            //if ((utilitieType == "Gas") || (utilitieType == "Hot water supply") || (utilitieType == "Cold water supply")
            //    || (utilitieType == "Water disposal"))
            else
            {
                unit = "m3";
            }
            
            
        }

        private void rateIDTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
