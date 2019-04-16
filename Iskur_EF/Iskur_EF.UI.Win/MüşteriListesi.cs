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
    public partial class MüşteriListesi : Form
    {
        public MüşteriListesi()
        {
            InitializeComponent();
        }
        public static int CustomerID { get; set; }
        private void MüşteriListesi_Load(object sender, EventArgs e)
        {
             dataGridView1.DataSource=  EmployeeBLL.Get_Customers();
             CustomerID=(int)dataGridView1.CurrentRow.Cells[0].Value;
        }

        private void orderListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Get_Order or = new Get_Order();
            or.Show();
        }

        private void orderVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products_Listele frm = new Products_Listele();
            
            frm.Show();
        }
    }
}
