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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void personelDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personelDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int businessEntityID = 0;
            businessEntityID = int.Parse(dgv_PersonelListesi.SelectedRows[0].Cells["BusinessEntityID"].Value.ToString());

            dlg_PersonelDetay form = new dlg_PersonelDetay();
            form.BusinessEntitiyID = businessEntityID;
            form.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgv_PersonelListesi.DataSource = EmployeeBLL.GetEmployees(textBox1.Text);
            
        }

        private void dgv_PersonelListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
