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

namespace Epam.TalalaykinaEI.Task3_v._3_.Houses_Forms
{
    public partial class AddHouseForm : Form
    {
        private HouseLogic houseLogic = new HouseLogic();
        public AddHouseForm()
        {
            InitializeComponent();
        }

        private void addHouseButton_Click(object sender, EventArgs e)
        {
            if (addressTextBox.Text == "")
            {
                MessageBox.Show("Please, fill the address field!");
            }
            else
            {
                houseLogic.Add(new House(addressTextBox.Text));
            }
            }

        private void AddHouseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
