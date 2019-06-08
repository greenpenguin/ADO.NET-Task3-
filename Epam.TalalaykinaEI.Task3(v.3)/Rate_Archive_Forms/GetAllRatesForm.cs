using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace Epam.TalalaykinaEI.Task3_v._3_.Rate_Archive_Forms
{
    public partial class GetAllRatesForm : Form
    {
        Rate_ArchiveLogic rate_ArchiveLogic = new Rate_ArchiveLogic();
        public GetAllRatesForm()
        {
            InitializeComponent();
            dataGridView.DataSource = rate_ArchiveLogic.GetAll();
        }

        private void GetAllRatesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uTILITIES3DataSet.Rate_Archive". При необходимости она может быть перемещена или удалена.
            //this.rate_ArchiveTableAdapter.Fill(this.uTILITIES3DataSet.Rate_Archive);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
