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

namespace Epam.TalalaykinaEI.Task3_v._3_.Apartment_Forms
{
    public partial class GetApartmentByID : Form
    {
        private ApartmentLogic ApartmentLogic = new ApartmentLogic();
        public GetApartmentByID()
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
                    if (ApartmentLogic.IsApartmentExists(result) == -1)
                    {
                        MessageBox.Show("Apartment does not exist!");
                    }
                    else
                    {
                        textLabel.Text = ApartmentLogic.GetByID(result).ToString();
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
