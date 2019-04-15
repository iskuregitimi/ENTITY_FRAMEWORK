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
    public partial class dlg_Siparisler : Form
    {
        public dlg_Siparisler()
        {
            InitializeComponent();
        }

        public int CustomerId { get; internal set; }

        private void dlg_Siparisler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerBLL.GetSalesOrderHeaders(CustomerId);
        }

        private void siparişDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SiparisDetail frm = new frm_SiparisDetail();
            frm.SalesOrderId = int.Parse(dataGridView1.SelectedRows[0].Cells["SalesOrderID"].Value.ToString());
            frm.Show();
        }
    }
}
