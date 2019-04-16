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
            dgv_PersonelListesi.DataSource = EmployeeBLL.AllGetEmployees();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgv_PersonelListesi.DataSource = EmployeeBLL.GetEmployee(textBox1.Text);
        }

        private void personelDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_PersonelDetay frm = new dlg_PersonelDetay();
            frm.BusinessID = int.Parse(dgv_PersonelListesi.SelectedRows[0].Cells[0].Value.ToString());
            frm.ShowDialog();
        }
    }
}
