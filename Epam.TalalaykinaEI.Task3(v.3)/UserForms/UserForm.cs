using BL;
using Epam.TalalaykinaEI.Task3_v._3_.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epam.TalalaykinaEI.Task3_v._3_
{
    public partial class UserForm : Form
    {
        private Owner_ListLogic owner_ListLogic = new Owner_ListLogic();
        int userIDForClass;
        int numOfCheckedApp;
        int idOfCheckedInv;
        int numOfCheckedInv;
        double sumOfCheckedDebt;
        int numOfCheckedDebt;
        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(int userID)
        {
            InitializeComponent();
            userIDForClass = userID;
            apAddButton.Enabled = false;
            invButton.Enabled = false;
            debtButton.Enabled = false;
            IDLabel.Text = owner_ListLogic.GetByID(userID).ID_Owner.ToString();
            nameLabel.Text = owner_ListLogic.GetByID(userID).Name.ToString();
            sNameLabel.Text = owner_ListLogic.GetByID(userID).Second_Name.ToString();
            List<string> addressesList = owner_ListLogic.GetApartmentByID(userID);
            for (int i=0;i< addressesList.Count-1;i+=2)
            {
                apartmentComboBox.Items.Add(addressesList[i] + ", " + addressesList[i + 1]);
            }
            List<string> invoicesList = owner_ListLogic.GetInvoicesByID(userID);
            for (int i = 0; i < invoicesList.Count; i++)
            {
                invoicesComboBox.Items.Add(invoicesList[i]);
            }
            List<string> debtList = owner_ListLogic.GetDebtByID(userID);
            //List<string> debtOwnerIDList = owner_ListLogic.GetDebtByID(userID);
            for (int i = 0; i < debtList.Count; i+=2)
            {
                debtComboBox.Items.Add(debtList[i]);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

private void apartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numOfCheckedApp = apartmentComboBox.SelectedIndex;
            apAddButton.Enabled = true;
        }

        private void apAddButton_Click(object sender, EventArgs e)
        {
            List<string> infoList = owner_ListLogic.GetApartmentInfoByID(userIDForClass);
            string area = "-1";
            string num = "-1";
            
                for (int i = 0; i < infoList.Count-1; i++)
                {
                if (i == numOfCheckedApp * 2)
                {
                    area = infoList[i];
                    num = infoList[i + 1];

                }
                }
                Form appInfo = new ApartmentInformationForm(area, num);
                appInfo.ShowDialog();
        }

        private void invoicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            idOfCheckedInv = int.Parse(invoicesComboBox.Text);
            numOfCheckedInv = invoicesComboBox.SelectedIndex;
            invButton.Enabled = true;
        }

        private void invButton_Click(object sender, EventArgs e)
        {
            List<string> infoList = owner_ListLogic.GetInvoicesInfoByID(userIDForClass);

            string date = "-1";
            string t_am = "-1";
            string p_am = "-1";
            string need_to_pay = "-1";
            for (int i = 0; i < infoList.Count - 3; i++)
            {
                if (i == numOfCheckedInv * 4)
                {
                    date = infoList[i];
                    t_am = infoList[i + 1];
                    p_am = infoList[i + 2];
                    if (double.TryParse(infoList[i + 3], out double result))
                    {
                        if (result < 0)
                        {
                            need_to_pay = "0, overpayment " + infoList[i + 3];
                        }
                        else
                        {
                            need_to_pay = infoList[i + 3];
                        }
                    }
                }

            }
            Form invInfo = new InvoiceInformationForm(idOfCheckedInv, date, t_am, p_am, need_to_pay);
            invInfo.ShowDialog();
        }

        private void debtComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sumOfCheckedDebt = double.Parse(debtComboBox.Text);
            numOfCheckedDebt = debtComboBox.SelectedIndex;
            debtButton.Enabled = true;
        }

        private void debtButton_Click(object sender, EventArgs e)
        {
            List<string> debtOwnerIDList = owner_ListLogic.GetDebtByID(userIDForClass);          
            if (numOfCheckedDebt==0)
            {
                numOfCheckedDebt = 1;
            }
            else
            {
                numOfCheckedDebt+=2;
            }
            List<string> infoList = owner_ListLogic.GetDebtInfoByID(userIDForClass, int.Parse(debtOwnerIDList[numOfCheckedDebt]));

            string u_type = "-1";
            string ow_am = debtOwnerIDList[numOfCheckedDebt];
            for (int i = 0; i < infoList.Count - 1; i++)
            {
                u_type = infoList[i];
                ow_am = infoList[i + 1];
            }
            Form debtInfo = new DebtInfoForm(u_type, ow_am);
            debtInfo.ShowDialog();
        }
    }
}
