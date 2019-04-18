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
    public partial class frm_MusteriListesi : Form
    {
        public frm_MusteriListesi()
        {
            InitializeComponent();
        }

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_Siparisler frm = new dlg_Siparisler();
            frm.CustomerId = int.Parse(dataGridView1.SelectedRows[0].Cells["CustomerID"].Value.ToString());
            frm.Show();
        }

        private void frm_MusteriListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerBLL.GetCustomers(string.Empty);
        }

        private void yeniSiparişEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_YeniSiparis f = new frm_YeniSiparis();
            f.CustomerId = int.Parse(dataGridView1.SelectedRows[0].Cells["CustomerID"].Value.ToString());
            f.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
