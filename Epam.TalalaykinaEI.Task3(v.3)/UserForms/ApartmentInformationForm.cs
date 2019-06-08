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
    public partial class ApartmentInformationForm : Form
    {
        public ApartmentInformationForm()
        {
            InitializeComponent();
        }

        public ApartmentInformationForm(string area, string numOfPrscr)
        {
            InitializeComponent();
            appAreaLabel.Text = area;
            numOfPrscrLabel.Text = numOfPrscr;
        }

        private void ApartmentInformationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
