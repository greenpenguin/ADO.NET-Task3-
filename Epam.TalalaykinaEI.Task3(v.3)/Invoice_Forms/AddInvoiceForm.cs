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

namespace Epam.TalalaykinaEI.Task3_v._3_.Invoice_Forms
{
    public partial class AddInvoiceForm : Form
    {
        private InvoiceLogic invoiceLogic = new InvoiceLogic();
        private Owner_ListLogic owner_ListLogic = new Owner_ListLogic();
        public AddInvoiceForm()
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
            if ((ownerIDTextBox.Text == "") || (maskedDateTextBox.Text == "") ||
                (totalAmountTextBox.Text == "") || (paidAmountTextBox.Text == ""))
            {
                MessageBox.Show("Please, fill all fields!");
            }
            else
            {
                DateTime minDateTime = new DateTime(1753, 1, 1);
                DateTime maxDateTime = new DateTime(9999, 12, 31, 23, 59, 59, 997);
                if ((!int.TryParse(ownerIDTextBox.Text, out int ownerID)) ||
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
                    if (owner_ListLogic.IsOwnerExists(ownerID) == -1)
                    {
                        MessageBox.Show("Owner does not exist!");
                    }

                    else
                    {
                        double t_am = totalAmount;
                        double p_am = paidAmount;

                        if (t_am >= p_am)
                        {
                            invoiceLogic.Add(new Invoice(ownerID,
                                date, totalAmount, paidAmount));
                        }
                        else
                        {
                            overpaymentLabel.Text = "Registered overpayment!";
                            invoiceLogic.Add(new Invoice(ownerID,
                                date, totalAmount, totalAmount));
                        }
                    }
                }
            
            }
        }
    }
}
