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
    public partial class frm_PersonelListesi : Form
    {
        public frm_PersonelListesi()
        {
            InitializeComponent();
        }

        private void dgv_PersonelListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_PersonelListesi_Load(object sender, EventArgs e)
        {
            dgv_PersonelListesi.DataSource = EmployeeBLL.GetEmployees(string.Empty);


        }

        private void personelDetayToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            dlg_PersonelDetay detay = new dlg_PersonelDetay();
            //detay.MdiParent = this;
            detay.Show();
        }

        private void dgv_PersonelListesi_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void dgv_PersonelListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int businessEntityId = 0;
            businessEntityId = int.Parse(dgv_PersonelListesi.SelectedRows[0].Cells["BusinessEntityID"].Value.ToString());

            dlg_PersonelDetay detay = new dlg_PersonelDetay();
            detay.BusinessEntityID = businessEntityId;
            detay.Show();

        }
    }
}
