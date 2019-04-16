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
    public partial class Müsteriler : Form
    {
        public Müsteriler()
        {
            InitializeComponent();
        }
 

        private void Müsteriler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeeBLL.getCustomers(string.Empty);

        }

        private void siparisDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisDetail detay = new SiparisDetail();
           
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells["CustomerID"].Value.ToString());
            detay.PersonId = id;
            detay.Show();
        }

        private void siparisVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisVer ver = new SiparisVer();
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells["CustomerID"].Value.ToString());
            ver.customerId = id;
            ver.Show();
        }
    }
}
