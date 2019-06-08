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

namespace Epam.TalalaykinaEI.Task3_v._3_.List_Of_Debtor_Forms
{
    public partial class GetAllDebtorsForm : Form
    {
        private List_Of_DebtorLogic list_Of_DebtorLogic = new List_Of_DebtorLogic();
        public GetAllDebtorsForm()
        {
            InitializeComponent();
            dataGridView.DataSource = list_Of_DebtorLogic.GetAll();
        }

        private void GetAllDebtorsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uTILITIES3DataSet.List_Of_Debtor". При необходимости она может быть перемещена или удалена.
            //this.list_Of_DebtorTableAdapter.Fill(this.uTILITIES3DataSet.List_Of_Debtor);

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
