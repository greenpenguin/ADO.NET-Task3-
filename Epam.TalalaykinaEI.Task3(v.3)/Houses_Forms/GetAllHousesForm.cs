using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epam.TalalaykinaEI.Task3_v._3_.Houses_Forms
{
    public partial class GetAllHousesForm : Form
    {
        private HouseLogic houseLogic = new HouseLogic();
        public GetAllHousesForm()
        {
            InitializeComponent();
            //dataGridView.DataSource = houseLogic.GetAll();
        }

        private void GetAllHousesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uTILITIES3DataSet.House". При необходимости она может быть перемещена или удалена.
            this.houseTableAdapter.Fill(this.uTILITIES3DataSet.House);
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
