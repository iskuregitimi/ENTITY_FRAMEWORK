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
    public partial class dlg_Urunler : Form
    {
        public int CustomerID { get; set; }
        public dlg_Urunler()
        {
            InitializeComponent();
        }

        private void dlg_Urunler_Load(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = UrunlerBLL.GetProducts(string.Empty);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var selectedRows = dgvUrunler.SelectedRows.OfType<DataGridViewRow>().Where(row => !row.IsNewRow).ToArray();
            int i = 0;
            foreach (var row in selectedRows)
            {            
                var header = SiparisBLL.AddOrder(CustomerID, 100);
                int productID = int.Parse(dgvUrunler.SelectedRows[i].Cells["ProductID"].Value.ToString());
                Product product = SiparisBLL.GetProduct(productID);
                SiparisBLL.AddOrderDetails(product, header);
                i++;
            }
            
            MessageBox.Show("Ürün Eklendi!");
        }
    }
}
