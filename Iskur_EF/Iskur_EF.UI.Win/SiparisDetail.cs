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
    public partial class SiparisDetail : Form
    {
        public SiparisDetail()
        {
            InitializeComponent();
        }

        public int PersonId { get; internal set; }

        private void SiparisDetail_Load(object sender, EventArgs e)
        {
            dgv_siparisDetail.DataSource = EmployeeBLL.getOrderHeader(PersonId);
        }

        private void siparişDetayiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siparisdetayi2 detay = new siparisdetayi2();
            int id = int.Parse(dgv_siparisDetail.SelectedRows[0].Cells["SalesOrderID"].Value.ToString());
            detay.salesOrderId = id;
            detay.Show();

        }
    }
}
