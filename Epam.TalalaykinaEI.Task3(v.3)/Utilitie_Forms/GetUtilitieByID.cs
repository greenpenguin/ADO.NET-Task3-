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

namespace Epam.TalalaykinaEI.Task3_v._3_.Utilitie_Forms
{
    public partial class GetUtilitieByID : Form
    {
        private UtilitieLogic UtilitieLogic = new UtilitieLogic();
        public GetUtilitieByID()
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
                    if (UtilitieLogic.IsUtilitieExists(result) == -1)
                    {
                        MessageBox.Show("Utilitie does not exist!");
                    }
                    else
                    {
                        textLabel.Text = UtilitieLogic.GetByID(result).ToString();
                    }
                }
            }
        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textLabel_Click(object sender, EventArgs e)
        {

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
