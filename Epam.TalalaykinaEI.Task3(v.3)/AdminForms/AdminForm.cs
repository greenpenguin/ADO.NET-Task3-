using BL;
using Epam.TalalaykinaEI.Task3_v._3_.Account_Forms;
using Epam.TalalaykinaEI.Task3_v._3_.Apartment_Forms;
using Epam.TalalaykinaEI.Task3_v._3_.Houses_Forms;
using Epam.TalalaykinaEI.Task3_v._3_.Invoice_Forms;
using Epam.TalalaykinaEI.Task3_v._3_.List_Of_Debtor_Forms;
using Epam.TalalaykinaEI.Task3_v._3_.List_Of_Installed_Meters_Forms;
using Epam.TalalaykinaEI.Task3_v._3_.Meter_Forms;
using Epam.TalalaykinaEI.Task3_v._3_.Rate_Archive_Forms;
using Epam.TalalaykinaEI.Task3_v._3_.Utilitie_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epam.TalalaykinaEI.Task3_v._3_.AdminForms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ownerForm = new GetAllOwners();
            ownerForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form apartmentForm = new GetAllApartmentsForm();
            apartmentForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form houseForm = new GetAllHousesForm();
            houseForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form invoiceForm = new GetAllInvoicesForm();
            invoiceForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form accountForm = new GetAllAccountsForm();
            accountForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form debtorForm = new GetAllDebtorsForm();
            debtorForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form utilitiesForm = new GetAllUtilitiesForm();
            utilitiesForm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form metersForm = new GetAllMetersForm();
            metersForm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form installedMetersForm = new GetAllInstalledMetersForm();
            installedMetersForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form rateForm = new GetAllRatesForm();
            rateForm.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form addOwnerForm = new AddOwnerForm();
            addOwnerForm.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form addApartmentForm = new AddApartmentForm();
            addApartmentForm.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form addHouseForm = new AddHouseForm();
            addHouseForm.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form addInvoiceForm = new AddInvoiceForm();
            addInvoiceForm.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form addAccountForm = new AddAccountForm();
            addAccountForm.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form addDebtorForm = new AddDebtorForm();
            addDebtorForm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form addUtilitieForm = new AddUtilitieForm();
            addUtilitieForm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form addMeterForm = new AddMeterForm();
            addMeterForm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form addInstalledMeterForm = new AddInstalledMeterForm();
            addInstalledMeterForm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form addRateForm = new AddRateForm();
            addRateForm.ShowDialog();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //Form RemoveOwnerByID = new RemoveOwnerByID();
            //RemoveOwnerByID.ShowDialog();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Form getUtilitieForm = new GetUtilitieByID();
            getUtilitieForm.ShowDialog();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Form getRateForm = new GetRateByID();
            getRateForm.ShowDialog();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Form getMeterForm = new GetMetrByID();
            getMeterForm.ShowDialog();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Form getMeterForm = new GetInstMetrByID();
            getMeterForm.ShowDialog();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Form getDebtorForm = new GetDebtorByID();
            getDebtorForm.ShowDialog();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Form getInvoiceForm = new GetInvoiceByID();
            getInvoiceForm.ShowDialog();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Form getApartmentForm = new GetApartmentByID();
            getApartmentForm.ShowDialog();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Form getAccountForm = new GetAccountByID();
            getAccountForm.ShowDialog();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Form getHouseForm = new GetHouseByID();
            getHouseForm.ShowDialog();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Form getOwnerForm = new GetOwnerByID();
            getOwnerForm.ShowDialog();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Form RemoveHouseByID = new RemoveHouseByID();
            RemoveHouseByID.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {

            Form RemoveDebtorByID = new RemoveDebtorByID();
            RemoveDebtorByID.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form RemoveMeterByID = new RemoveMeterByID();
            RemoveMeterByID.ShowDialog();
        }


        private void button41_Click(object sender, EventArgs e)
        {
             HouseLogic HouseLogic = new HouseLogic();
            if (houseDebtTextBox.Text == "")
            {
                MessageBox.Show("Please, fill the House Debt field!");
            }
            else
            {
                if (!int.TryParse(houseDebtTextBox.Text, out int result))
                {
                    MessageBox.Show("Value entered is too large!");
                }
                else
                {
                    if (HouseLogic.IsHouseExists(result) == -1)
                    {
                        MessageBox.Show("House does not exist!");
                    }

                    else
                    {
                        houseDebtLabel.Text = HouseLogic.HouseDebtSum(result).ToString();
                    }
                }
            }
            
    }

        private void houseDebtTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
    }

