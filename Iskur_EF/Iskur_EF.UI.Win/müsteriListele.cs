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
    public partial class müsteriListele : Form
    {
        public müsteriListele()
        {
            InitializeComponent();
        }

        private void müsteriListele_Load(object sender, EventArgs e)
        {
            //dgv_PersonelListesi.DataSource = EmployeeBLL.GetEmployees(string.Empty);
            dvg_musterigetir.DataSource = CustomerBLL.GetCustomer(string.Empty);
        }

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Siparişler_genel_ frm = new Siparişler_genel_();
            frm.CustomerId = int.Parse(dvg_musterigetir.SelectedRows[0].Cells[0].Value.ToString());
            //frm.BussinessEntityId = int.Parse(dgv_PersonelListesi.SelectedRows[0].Cells[0].Value.ToString());
            frm.Show();
        }
    }
}
