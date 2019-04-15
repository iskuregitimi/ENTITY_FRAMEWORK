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
      
        private void frm_PersonelListesi_Load(object sender, EventArgs e)
        {
            dgv_PersonelListesi.DataSource = EmployeeBLL.GetEmployees(string.Empty);
        }

        private void personelDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgv_PersonelListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen personel seçiniz.");
                return;
            }

            dlg_PersonelDetay form = new dlg_PersonelDetay();
            form.businessEntityId = int.Parse(dgv_PersonelListesi.SelectedRows[0].Cells["BusinessEntityID"].Value.ToString());
            form.Show();
        }
    }
}
