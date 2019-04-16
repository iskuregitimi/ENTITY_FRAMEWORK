using Iskur_EF.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iskur_EF.UI.Win
{
    public partial class frm_magazalistesi : Form
    {
        public frm_magazalistesi()
        {
            InitializeComponent();
        }

      
        public int SalesPersonId { get; internal set; }
        private void dgv_magaza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_magaza.DataSource= EmployeeBLL.getStore();

        }

        private void frm_magazalistesi_Load(object sender, EventArgs e)
        {
            dgv_magaza.DataSource = EmployeeBLL.getStore();

        }

        private void salesPersonDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesPersonDetay detay = new SalesPersonDetay();
           SalesPersonId= int.Parse(dgv_magaza.SelectedRows[0].Cells["SalesPersonID"].Value.ToString());

            detay.SalesPersonId = SalesPersonId;
               detay.Show();

        }
    }
}
