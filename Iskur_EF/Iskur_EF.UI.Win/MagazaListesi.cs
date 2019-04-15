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
    public partial class MagazaListesi : Form
    {
        public MagazaListesi()
        {
            InitializeComponent();
        }

        private void MagazaListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeeBLL.GetStores(string.Empty);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void mağazaDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MagazaDetay frm = new MagazaDetay();
            frm.SalesPersonID = int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
