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

namespace Epam.TalalaykinaEI.Task3_v._3_.List_Of_Installed_Meters_Forms
{
    public partial class GetAllInstalledMetersForm : Form
    {
        private List_Of_Installed_MetersLogic list_Of_Installed_MetersLogic = new List_Of_Installed_MetersLogic();
        public GetAllInstalledMetersForm()
        {
            InitializeComponent();
            //dataGridView.DataSource = list_Of_Installed_MetersLogic.GetAll();
        }

        private void GetAllInstalledMetersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uTILITIES3DataSet.List_Of_Installed_Meters". При необходимости она может быть перемещена или удалена.
            this.list_Of_Installed_MetersTableAdapter.Fill(this.uTILITIES3DataSet.List_Of_Installed_Meters);

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
