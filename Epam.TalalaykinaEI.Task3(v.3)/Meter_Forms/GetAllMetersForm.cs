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

namespace Epam.TalalaykinaEI.Task3_v._3_.Meter_Forms
{
    public partial class GetAllMetersForm : Form
    {
        private MeterLogic meterLogic = new MeterLogic();
        public GetAllMetersForm()
        {
            InitializeComponent();
            dataGridView.DataSource = meterLogic.GetAll();
        }

        private void GetAllMetersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uTILITIES3DataSet.Meter". При необходимости она может быть перемещена или удалена.
           // this.meterTableAdapter.Fill(this.uTILITIES3DataSet.Meter);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
