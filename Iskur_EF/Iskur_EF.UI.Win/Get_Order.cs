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
    public partial class Get_Order : Form
    {
        public Get_Order()
        {
            InitializeComponent();
        }

        private void Get_Order_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource=  EmployeeBLL.Get_Order(MüşteriListesi.CustomerID);
        }
        public static int SPID { get; set; }
        private void orderDetayınıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDetail frm = new OrderDetail();
            SPID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            frm.Show();
        }
    }
}
