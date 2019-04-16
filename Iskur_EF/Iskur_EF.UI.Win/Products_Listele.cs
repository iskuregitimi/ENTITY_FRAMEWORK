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
    public partial class Products_Listele : Form
    {
        public Products_Listele()
        {
            InitializeComponent();
        }

        private void Products_Listele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= EmployeeBLL.Get_Products();

        }
        public static int productId { get; set; }
        private void ürünüSeçVeSiparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productId =(int) dataGridView1.CurrentRow.Cells[0].Value;
            int salesorderId= EmployeeBLL.Create_Order(productId,MüşteriListesi.CustomerID);
            EmployeeBLL.SalesOrderDetailİnsert(productId, salesorderId);
            
        }
    }
}
