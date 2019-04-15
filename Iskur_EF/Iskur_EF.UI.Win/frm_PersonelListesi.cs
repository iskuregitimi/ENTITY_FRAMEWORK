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

        private void dgv_PersonelListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seçili kaydın ID sini alınıyor
            int businessEntityId = 0;
            businessEntityId = int.Parse(dgv_PersonelListesi.SelectedRows[0].Cells["BusinessEntityID"].Value.ToString());


            dlg_PersonelDetay dlg = new dlg_PersonelDetay();
            dlg.BusinessEntityID = businessEntityId;
            dlg.ShowDialog();
        }

        private void dgv_PersonelListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
