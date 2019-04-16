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
    public partial class siparisdetayi2 : Form
    {
        public siparisdetayi2()
        {
            InitializeComponent();
        }
        public int salesOrderId;

        private void siparisdetayi2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeeBLL.getOrderdetail(salesOrderId);
        }
    }
}
