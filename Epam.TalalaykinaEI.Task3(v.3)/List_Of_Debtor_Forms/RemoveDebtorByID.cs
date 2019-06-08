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
    public partial class RemoveDebtorByID : Form
    {
        private Owner_ListLogic owner_ListLogic = new Owner_ListLogic();
        private List_Of_DebtorLogic List_Of_DebtorLogic = new List_Of_DebtorLogic();
        public RemoveDebtorByID()
        {
            InitializeComponent();
        }

        private void removeHouseButton_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "")
            {
                MessageBox.Show("Please, fill the field!");
            }
            else
            {
                if (!int.TryParse(IDTextBox.Text, out int result))
                {
                    MessageBox.Show("Value entered is too large!");
                }
                else
                {
                    if (owner_ListLogic.IsOwnerExists(result) == -1)
                    {
                        MessageBox.Show("Debtor does not exist!");
                    }
                    else
                    {
                        List_Of_DebtorLogic.RemoveByID(result);
                    }
                }
            }
        }

        private void RemoveDebtorByID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
