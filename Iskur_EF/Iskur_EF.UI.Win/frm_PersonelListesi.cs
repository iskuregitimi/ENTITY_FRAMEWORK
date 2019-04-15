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
            dataGridView1.DataSource = EmployeeBLL.GetEmployees(string.Empty);
        }

        private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_PersonelDetay frm = new dlg_PersonelDetay();
            frm.businessentityid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
