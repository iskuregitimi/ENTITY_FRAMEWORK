using Iskur_EF.BLL;
using Iskur_EF.DAL;
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
    public partial class frm_YeniSiparis : Form
    {
        public frm_YeniSiparis()
        {
            InitializeComponent();
        }
        public int id = 0;
    
        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductBLL.GetProducts(productID);
        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var header = OrderBLL.AddOrder(id, 100);
            int productID = int.Parse(dataGridView1.SelectedRows[0].Cells["ProductID"].Value.ToString());
            Product product = ProductBLL.GetProducts(productID);
            OrderDetailBLL.AddOrderDetails(product, header);
        }
    }
}
