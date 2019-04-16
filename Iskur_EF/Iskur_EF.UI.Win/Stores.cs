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
    public partial class Stores : Form
    {
        public Stores()
        {
            InitializeComponent();
        }

        private void Stores_Load(object sender, EventArgs e)
        {
            dgv_Sales.DataSource = StoreBLL.GetStores();
        }

        private void satışKişisiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_PersonelDetay frm = new dlg_PersonelDetay();
            frm.BusinessID= int.Parse(dgv_Sales.SelectedRows[0].Cells["SalesPersonID"].Value.ToString());
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgv_Sales.DataSource = StoreBLL.GetStores(textBox1.Text);
        }
    }
}
