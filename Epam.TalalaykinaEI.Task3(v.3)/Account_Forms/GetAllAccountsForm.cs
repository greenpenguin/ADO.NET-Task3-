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

namespace Epam.TalalaykinaEI.Task3_v._3_.Account_Forms
{
    public partial class GetAllAccountsForm : Form
    {
        private AccountLogic accountLogic = new AccountLogic();
        public GetAllAccountsForm()
        {
            InitializeComponent();
            dataGridView.DataSource = accountLogic.GetAll();
        }

        private void GetAllAccountsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uTILITIES3DataSet.Account". При необходимости она может быть перемещена или удалена.
            //this.accountTableAdapter.Fill(this.uTILITIES3DataSet.Account);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
