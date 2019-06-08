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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epam.TalalaykinaEI.Task3_v._3_
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdminOrUserForm());
            //Application.Run(new AddOwnerForm()); 
            //Application.Run(new RemoveOwnerByID());
            //Application.Run(new GetOwnerByID());
            //Application.Run(new GetAllOwners());

            //Application.Run(new AddHouseForm());
            //Application.Run(new RemoveHouseByID());
            //Application.Run(new GetHouseByID());
            //Application.Run(new GetAllHousesForm());

            //Application.Run(new AddOwnerForm()); 
            //Application.Run(new RemoveOwnerByID());
            //Application.Run(new GetOwnerByID());
            //Application.Run(new GetAllOwners());

            //Application.Run(new AddAccountForm());
            //Application.Run(new AddApartmentForm());
            //Application.Run(new AddInvoiceForm());
            //Application.Run(new AddDebtorForm());
            //Application.Run(new AddInstalledMeterForm());
            //Application.Run(new AddMeterForm());
            //Application.Run(new AddRateForm());
            //Application.Run(new GetAllRatesForm());
            //Application.Run(new GetAllMetersForm());
            //Application.Run(new GetAllInstalledMetersForm());
            //Application.Run(new GetAllDebtorsForm());
            //Application.Run(new GetAllInvoicesForm());
            
                //Application.Run(new GetAllApartmentsForm());
            
//Application.Run(new GetAllAccountsForm());
            //Application.Run(new AddUtilitieForm());
            //Application.Run(new GetAllUtilitiesForm());
        }
    }
}
