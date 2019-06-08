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
    public partial class DebtInfoForm : Form
    {
        public DebtInfoForm()
        {
            InitializeComponent();
        }

        public DebtInfoForm(string u_type, string ow_am)
        {
            InitializeComponent();
            uTypeLabel.Text = u_type;
            owAmLabel.Text = ow_am;
        }

        private void DebtInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
