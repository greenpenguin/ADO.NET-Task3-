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

namespace Epam.TalalaykinaEI.Task3_v._3_.Apartment_Forms
{
    public partial class GetAllApartmentsForm : Form
    {
        private ApartmentLogic apartmentLogic = new ApartmentLogic();
        public GetAllApartmentsForm()
        {
            InitializeComponent();
            dataGridView.DataSource = apartmentLogic.GetAll();
        }

        private void GetAllApartmentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uTILITIES3DataSet.Apartment". При необходимости она может быть перемещена или удалена.
            //this.apartmentTableAdapter.Fill(this.uTILITIES3DataSet.Apartment);

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
