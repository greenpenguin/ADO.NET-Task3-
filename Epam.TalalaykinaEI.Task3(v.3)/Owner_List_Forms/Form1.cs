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

namespace Epam.TalalaykinaEI.Task3_v._3_
{
    public partial class AddOwnerForm : Form
    {
        private Owner_ListLogic owner_ListLogic = new Owner_ListLogic();
        public AddOwnerForm()
        {
            InitializeComponent();
        }

        private void AddOwnerForm_Load(object sender, EventArgs e)
        {

        }

        private void addOwnerButton_Click(object sender, EventArgs e)
        {
            if ((nameTextBox.Text == "") || (secondNameTextBox.Text == "") || (phoneNumberTextBox.Text == ""))
            {
                MessageBox.Show("Please, fill all fields!");
            }
            else
            {
                owner_ListLogic.Add(new Owner_List(nameTextBox.Text, secondNameTextBox.Text, phoneNumberTextBox.Text));
                //this.Close();
            }
        }

        private void phoneNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void secondNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void secondNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }
    }
}
