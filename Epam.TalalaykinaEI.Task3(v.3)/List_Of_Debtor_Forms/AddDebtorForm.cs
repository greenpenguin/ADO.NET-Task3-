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

namespace Epam.TalalaykinaEI.Task3_v._3_.List_Of_Debtor_Forms
{
    public partial class AddDebtorForm : Form
    {
        private List_Of_DebtorLogic list_Of_DebtorLogic = new List_Of_DebtorLogic();
        private Owner_ListLogic owner_ListLogic = new Owner_ListLogic();
        private UtilitieLogic utilitieLogic = new UtilitieLogic();
        public AddDebtorForm()
        {
            InitializeComponent();
        }

        private void ownerIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void utilitieIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void owAmTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((ownerIDTextBox.Text == "") || (utilitieIDTextBox.Text == "") || (owAmTextBox.Text == ""))
            {
                MessageBox.Show("Please, fill all fields!");
            }
            else
            {
                if ((!int.TryParse(ownerIDTextBox.Text, out int ownerID)) ||
                    (!int.TryParse(utilitieIDTextBox.Text, out int utilitieID)) ||
                    (!double.TryParse(owAmTextBox.Text, out double owAm)))
                {
                    MessageBox.Show("Something is wrong with the entered values!");
                }
                else
                {
                    if (owner_ListLogic.IsOwnerExists(ownerID) == -1)
                    {
                        MessageBox.Show("Owner does not exist!");
                    }
                    else if (utilitieLogic.IsUtilitieExists(utilitieID) == -1)
                    {
                        MessageBox.Show("Utilitie does not exist!");
                    }

                    else
                    {
                        list_Of_DebtorLogic.Add(new List_Of_Debtor(ownerID, utilitieID,
                    owAm));
                    }
                }
            }
        }
        

        private void AddDebtorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
    
