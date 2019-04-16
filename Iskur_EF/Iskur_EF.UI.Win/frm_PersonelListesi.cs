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
            dgvPersonelListesi.DataSource = EmployeeBLL.GetEmployees(string.Empty);
        }

        private void personelDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvPersonelListesi.SelectedRows[0].Cells["BusinessEntityID"].Value.ToString());
            dlg_PersonelDetay form = new dlg_PersonelDetay();
            form.BusinessEntityID = id;
            form.ShowDialog();
        }
    }
}
