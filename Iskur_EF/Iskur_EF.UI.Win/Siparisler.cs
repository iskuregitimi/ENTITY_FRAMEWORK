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
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void Siparisler_Load(object sender, EventArgs e)
        {
            dgv_Siparis.DataSource = OrderBLL.GetPurchaseOrders(id);
        }

        private void siparisDetayıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisDetayi frm = new SiparisDetayi();
            frm.id = int.Parse(dgv_Siparis.SelectedRows[0].Cells["SalesOrderID"].Value.ToString());
            frm.ShowDialog();
        }
    }
}
