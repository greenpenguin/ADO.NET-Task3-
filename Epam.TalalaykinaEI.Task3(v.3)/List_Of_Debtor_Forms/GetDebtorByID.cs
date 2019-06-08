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

namespace Epam.TalalaykinaEI.Task3_v._3_.List_Of_Debtor_Forms
{
    public partial class GetDebtorByID : Form
    {
        private List_Of_DebtorLogic List_Of_DebtorLogic = new List_Of_DebtorLogic();
        private Owner_ListLogic Owner_ListLogic = new Owner_ListLogic();
        private UtilitieLogic UtilitieLogic = new UtilitieLogic();
        public GetDebtorByID()
        {
            InitializeComponent();
        }

        private void textLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if ((!int.TryParse(IDtextBox.Text, out int result1)) || (!int.TryParse(IDtextBox2.Text, out int result2)))
            {
                MessageBox.Show("Value entered is too large!");
            }
            else
            {
                if (Owner_ListLogic.IsOwnerExists(result1) == -1)
                {
                    MessageBox.Show("Owner does not exist!");
                }
                else if (UtilitieLogic.IsUtilitieExists(result2) == -1)
                {
                    MessageBox.Show("Utilitie does not exist!");
                }
                else
                {
                    textLabel.Text = List_Of_DebtorLogic.GetByID(result1, result2).ToString();
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

        private void IDtextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
