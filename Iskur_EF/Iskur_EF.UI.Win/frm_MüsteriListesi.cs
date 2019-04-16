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
    public partial class frm_MüsteriListesi : Form
    {
        public frm_MüsteriListesi()
        {
            InitializeComponent();
        }

        private void dgv_MüsteriListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int businessEntityId = 0;
            businessEntityId = int.Parse(dgv_MüsteriListesi.SelectedRows[0].Cells["BusinessEntityID"].Value.ToString());

            dlg_MüsteriDetay dlg = new dlg_MüsteriDetay();
       
            //dlg_PersonelDetay dlg = new dlg_PersonelDetay();
            //dlg.BusinessEntityID = businessEntityId;
            //dlg.ShowDialog();
        }

        private void frm_MüsteriListesi_Load(object sender, EventArgs e)
        {
            //dgv_MüsteriListesi.DataSource
        }
    }
}
