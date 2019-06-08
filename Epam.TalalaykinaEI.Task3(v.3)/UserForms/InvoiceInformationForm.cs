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

namespace Epam.TalalaykinaEI.Task3_v._3_.UserForms
{
    public partial class InvoiceInformationForm : Form
    {
        InvoiceLogic invoiceLogic = new InvoiceLogic();
        AccountLogic accountLogic = new AccountLogic();
        int numOfCheckedAcc;
        public InvoiceInformationForm()
        {
            InitializeComponent();
        }

        public InvoiceInformationForm(int invoiceID, string date, string t_am, string p_am, string need_to_pay)
        {
            InitializeComponent();
            infoButton.Enabled = false;
            invoiceLabel.Text = date;
            totalAmLabel.Text = t_am;
            paidAmLabel.Text = p_am;
            needToPayLabel.Text = need_to_pay;
            List<string> accountList = invoiceLogic.GetAccountByID(invoiceID);
            for (int i = 0; i < accountList.Count; i++)
            {
                accountIDComboBox.Items.Add(accountList[i]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numOfCheckedAcc = int.Parse(accountIDComboBox.Text);
            infoButton.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void invoiceLabel_Click(object sender, EventArgs e)
        {

        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            List<string> infoList = accountLogic.GetAccountInfoByID(numOfCheckedAcc);

            string ut_type = "no information";
            string date = "no information";
            string t_am = "no information";
            string p_am = "no information";
            string is_paid = "no information";
            string need_to_pay = numOfCheckedAcc.ToString();
            //if (numOfCheckedAcc != 0)
            //    {
            for (int i = 0; i < infoList.Count - 5; i++)
            {
                
                    ut_type = infoList[i];
                    date = infoList[i + 1];
                    t_am = infoList[i + 2];
                    p_am = infoList[i + 3];
                    is_paid = infoList[i + 4];
                    if (double.Parse(infoList[i + 5]) < 0)
                    {
                        need_to_pay = "0, overpayment " + infoList[i + 5];
                    }
                    else
                    {
                        need_to_pay = infoList[i + 5];
                    }
                }
            //}
            Form accInfo = new AccountInfoForm(ut_type, date, t_am, p_am, is_paid, need_to_pay);
            accInfo.ShowDialog();
        }
    }
}
