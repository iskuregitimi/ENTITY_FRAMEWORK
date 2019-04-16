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
    public partial class CustomerListesi : Form
    {
        public CustomerListesi()
        {
            InitializeComponent();
        }

        private void CustomerListesi_Load(object sender, EventArgs e)
        {
            dgv_Customer.DataSource = CustomerBLL.GetAllCustomers();
        }

        private void siparislerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Siparisler frm = new Siparisler();
            frm.id = int.Parse(dgv_Customer.SelectedRows[0].Cells["CustomerID"].Value.ToString());
            frm.ShowDialog();
        }

        private void siparisEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisEkle frm = new SiparisEkle();
            frm.id= int.Parse(dgv_Customer.SelectedRows[0].Cells["CustomerID"].Value.ToString());
            frm.ShowDialog();
        }
    }
}
