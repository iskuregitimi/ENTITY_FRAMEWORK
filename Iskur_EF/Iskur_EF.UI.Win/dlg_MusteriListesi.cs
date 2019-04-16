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
    public partial class dlg_MusteriListesi : Form
    {
        public dlg_MusteriListesi()
        {
            InitializeComponent();
        }

        private void dlg_MusteriListesi_Load(object sender, EventArgs e)
        {
            dgvMusteriListesi.DataSource = EmployeeBLL.GetCustomers(string.Empty);
        }

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvMusteriListesi.SelectedRows[0].Cells["CustomerID"].Value.ToString());
            dlg_Siparisler form = new dlg_Siparisler();
            form.CustomerID = id;
            form.ShowDialog();
        }
    }
}
