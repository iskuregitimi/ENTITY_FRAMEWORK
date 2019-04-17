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
        
        public static string musteribilgi;
        public static int person_beid;
        public static int person_cid;

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_Siparisler frm = new dlg_Siparisler();
            frm.CustomerId = int.Parse(dgv_musterilistesi.SelectedRows[0].Cells["CustomerID"].Value.ToString());
            frm.Show();
        }

        private void frm_MusteriListesi_Load(object sender, EventArgs e)
        {
            dgv_musterilistesi.DataSource = CustomerBLL.GetCustomers(string.Empty);
        }

        private void yeniSiparişEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteribilgi = dgv_musterilistesi.SelectedRows[0].Cells["Firstname"].Value.ToString() + " " + dgv_musterilistesi.SelectedRows[0].Cells["LastName"].Value.ToString();
            person_beid = Int32.Parse(dgv_musterilistesi.SelectedRows[0].Cells["BusinessEntityID"].Value.ToString());
            //kesinlikle daha pratik bir yolu olmalı
            frm_YeniSiparis f = new frm_YeniSiparis();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void dgv_musterilistesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
