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
    public partial class frm_SiparisDetail : Form
    {
        public frm_SiparisDetail()
        {
            InitializeComponent();
        }

        public int SalesOrderId { get; internal set; }

        private void frm_SiparisDetail_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OrderBLL.GetOrderDetail(SalesOrderId);
        }
    }
}
