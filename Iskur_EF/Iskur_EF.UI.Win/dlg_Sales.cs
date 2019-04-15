using Iskur_Ef.DAL;
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
    public partial class dlg_Sales : Form
    {
        public dlg_Sales()
        {
            InitializeComponent();
        }

        

        private void dlg_Sales_Load(object sender, EventArgs e)
        {
            //dgv_PersonelListesi.DataSource = EmployeeBLL.GetEmployees(string.Empty);
            dgv_store.DataSource = EmployeeBLL.GetStores(string.Empty);
        }

        private void storeDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_StoreDetay frm = new dlg_StoreDetay();
            frm.SalesId = int.Parse(dgv_store.SelectedRows[0].Cells[0].Value.ToString());
            frm.Show();

            
            //dlg_PersonelDetay frm = new dlg_PersonelDetay();
            //frm.BussinessEntityId = int.Parse(dgv_PersonelListesi.SelectedRows[0].Cells[0].Value.ToString());
            //frm.Show();

           











            //frm.BussinessEntityId = int.Parse(dgv_PersonelListesi.SelectedRows[0].Cells[0].Value.ToString());
            //frm.Show();
        }
    }
}
