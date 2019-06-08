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

namespace Epam.TalalaykinaEI.Task3_v._3_.Invoice_Forms
{
    public partial class GetAllInvoicesForm : Form
    {
        private InvoiceLogic invoiceLogic = new InvoiceLogic();
        public GetAllInvoicesForm()
        {
            InitializeComponent();
            dataGridView.DataSource = invoiceLogic.GetAll();
        }

        private void GetAllInvoicesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uTILITIES3DataSet.Invoice". При необходимости она может быть перемещена или удалена.
            //this.invoiceTableAdapter.Fill(this.uTILITIES3DataSet.Invoice);

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
