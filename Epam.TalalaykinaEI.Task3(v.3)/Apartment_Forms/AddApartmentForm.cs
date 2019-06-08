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

namespace Epam.TalalaykinaEI.Task3_v._3_.Apartment_Forms
{
    public partial class AddApartmentForm : Form
    {
        private Owner_ListLogic owner_ListLogic = new Owner_ListLogic();
        private HouseLogic houseLogic = new HouseLogic();
        private ApartmentLogic apartmentLogic = new ApartmentLogic();
        public AddApartmentForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void apartmentNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void houseIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void apSqTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void ownerIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void numOfPrescrtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void addApartmentButton_Click(object sender, EventArgs e)
        {
            if ((apartmentNumberTextBox.Text == "") || (houseIDTextBox.Text == "") || 
                (apSqTextBox.Text == "") || (ownerIDTextBox.Text == "") || (numOfPrescrtextBox.Text == ""))
            {
                MessageBox.Show("Please, fill all fields!");
            }
                else
            {
                if ((!int.TryParse(apartmentNumberTextBox.Text, out int apartmentNumber)) ||
                    (!int.TryParse(houseIDTextBox.Text, out int houseID)) ||
                    (!double.TryParse(apSqTextBox.Text, out double apSq)) ||
                    (!int.TryParse(ownerIDTextBox.Text, out int ownerID)) ||
                    (!int.TryParse(numOfPrescrtextBox.Text, out int numOfPrescr)))
                {
                    MessageBox.Show("Something is wrong with the entered values!");
                }
                else
                {
                    if (owner_ListLogic.IsOwnerExists(ownerID) == -1)
                    {
                        MessageBox.Show("Owner does not exist!");
                    }
                    else if (houseLogic.IsHouseExists(houseID) == -1)
                    {
                        MessageBox.Show("House does not exist!");
                    }

                    else
                    {
                        apartmentLogic.Add(new Apartment(apartmentNumber, houseID,
                            apSq, ownerID, numOfPrescr));
                    }
                }
            }
        }

        private void houseIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
