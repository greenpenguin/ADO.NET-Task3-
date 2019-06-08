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
    public partial class AccountInfoForm : Form
    {
        public AccountInfoForm()
        {
            InitializeComponent();
        }

        public AccountInfoForm(string ut_type, string date, string t_am, string p_am, string is_paid, string need_to_pay)
        {
            InitializeComponent();
            utLabel.Text = ut_type;
            dateLabel.Text = date;
            tAmLabel.Text = t_am;
            pAmLabel.Text = p_am;
            isPaidLabel.Text = is_paid;
            nToPayLabel.Text = need_to_pay;
        }

        private void AccountInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
