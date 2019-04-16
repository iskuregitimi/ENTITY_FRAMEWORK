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
    public partial class SiparisEkle : Form
    {
        public SiparisEkle()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            var header = OrderBLL.AddOrder(id, 100);
            int productID = int.Parse(dgv_Products.SelectedRows[0].Cells["ProductID"].Value.ToString());
            Product product = ProductBLL.GetProduct(productID);
            OrderDetaisBLL.AddOrderDetails(product,header);
        }

        private void SiparisEkle_Load(object sender, EventArgs e)
        {
            dgv_Products.DataSource= ProductBLL.GetProducts();
        }
    }
}
