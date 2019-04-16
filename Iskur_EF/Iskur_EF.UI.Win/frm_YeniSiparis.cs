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

        public int ProductId { get; internal set; }

        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductBLL.GetProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var header = OrderBLL.AddOrder(ProductId, 100);
            int ProductID = int.Parse(dataGridView1.SelectedRows[0].Cells["ProductID"].Value.ToString());
            Product product = ProductBLL.GetProduct(ProductID);
            OrderBLL.AddOrderDetail(product, header);
        }
    }
}
