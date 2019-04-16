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
    public partial class SiparisVer : Form
    {
        public SiparisVer()
        {
            InitializeComponent();
        }
        public int customerId { get; set; }
        private void SiparisVer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeeBLL.GetProduct();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells["ProductID"].Value.ToString());
          


                var header = EmployeeBLL.addProduct(customerId);
                Product product = EmployeeBLL.getProduct1(id);
                EmployeeBLL.addOrderDetail(header, product);
            
        }

        private void dataGridView1_MultiSelectChanged(object sender, EventArgs e)
        { 

        }
    }
}
