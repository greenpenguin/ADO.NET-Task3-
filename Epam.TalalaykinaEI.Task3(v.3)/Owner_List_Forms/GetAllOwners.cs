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

namespace Epam.TalalaykinaEI.Task3_v._3_
{
    public partial class GetAllOwners : Form
    {
        private Owner_ListLogic owner_ListLogic = new Owner_ListLogic();
        public GetAllOwners()
        {
            InitializeComponent();
            dataGridView.DataSource = owner_ListLogic.GetAll();
        }

        private void GetAllOwners_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uTILITIES3DataSet.Owner_List". При необходимости она может быть перемещена или удалена.
            //this.owner_ListTableAdapter.Fill(this.uTILITIES3DataSet.Owner_List);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
