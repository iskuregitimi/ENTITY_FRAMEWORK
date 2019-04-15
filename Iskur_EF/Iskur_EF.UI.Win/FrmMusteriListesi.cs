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
    public partial class FrmMusteriListesi : Form
    {
        public FrmMusteriListesi()
        {
            InitializeComponent();
        }

        private void FrmMusteriListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerBLL.GetCustomer(string.Empty);
        }

        private void sparisleriGetirToolStripMenuItem_Click(object sender, EventArgs e)
        {


            MusteriDetay frm = new MusteriDetay();
            frm.customerID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
