using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entities;

namespace Epam.TalalaykinaEI.Task3_v._3_.Account_Forms
{
    public partial class AddAccountForm : Form
    {
        private AccountLogic accountLogic = new AccountLogic();
        private InvoiceLogic invoiceLogic = new InvoiceLogic();
        private UtilitieLogic utilitieLogic = new UtilitieLogic();
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void invoiceNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void totalAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void paidAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            if ((invoiceNumberTextBox.Text == "") || (utilitieIDTextBox.Text == "") ||
                (maskedDateTextBox.Text == "") || (totalAmountTextBox.Text == "") || (paidAmountTextBox.Text == "") )
            {
                MessageBox.Show("Please, fill all fields!");
            }
            else
            {
                DateTime minDateTime = new DateTime(1753, 1, 1);
                DateTime maxDateTime = new DateTime(9999, 12, 31, 23, 59, 59, 997);
                if ((!int.TryParse(invoiceNumberTextBox.Text, out int invoiceNumber)) ||
                    (!int.TryParse(utilitieIDTextBox.Text, out int utilitieID)) ||
                    (!DateTime.TryParse(maskedDateTextBox.Text, out DateTime date)) ||
                    (DateTime.Parse(maskedDateTextBox.Text) < minDateTime) ||
                    (DateTime.Parse(maskedDateTextBox.Text) > maxDateTime) ||
                    (!double.TryParse(totalAmountTextBox.Text, out double totalAmount)) ||
                    (!double.TryParse(paidAmountTextBox.Text, out double paidAmount)))
                {
                    MessageBox.Show("Something is wrong with the entered values!");
                }
                else
                {
                    if (invoiceLogic.IsInvoiceExists(invoiceNumber) == -1)
                    {
                        MessageBox.Show("Invoice does not exist!");
                    }
                    else if (utilitieLogic.IsUtilitieExists(utilitieID) == -1)
                    {
                        MessageBox.Show("Utilitie does not exist!");
                    }

                    else
                    {
                        double t_am = totalAmount;
                        double p_am = paidAmount;
                        int is_paid;
                        if (t_am == p_am)
                        {
                            is_paid = 1;
                        }
                        else
                        {
                            is_paid = 0;
                        }

                        if (t_am >= p_am)
                        {
                            accountLogic.Add(new Account(invoiceNumber, utilitieID,
                                date, totalAmount, paidAmount,
                                is_paid, totalAmount - paidAmount));
                        }
                        else
                        {
                            overpaymentLabel.Text = "Registered overpayment!";
                            accountLogic.Add(new Account(invoiceNumber, utilitieID,
                                date, totalAmount, paidAmount,
                                1, 0));
                        }
                    }
                }
            }
        }
    }
}
