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

namespace Epam.TalalaykinaEI.Task3_v._3_.Utilitie_Forms
{
    public partial class GetAllUtilitiesForm : Form
    {
        private UtilitieLogic utilitieLogic = new UtilitieLogic();
        public GetAllUtilitiesForm()
        {
            InitializeComponent();
            dataGridView.DataSource = utilitieLogic.GetAll();
        }

        private void GetAllUtilitiesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uTILITIES3DataSet.Utilitie". При необходимости она может быть перемещена или удалена.
            //this.utilitieTableAdapter.Fill(this.uTILITIES3DataSet.Utilitie);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
