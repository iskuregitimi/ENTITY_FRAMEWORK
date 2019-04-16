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
    public partial class dlg_Siparisler : Form
    {
        public dlg_Siparisler()
        {
            InitializeComponent();
        }
        public int CustomerID { get; set; }
        private void dlg_Siparisler_Load(object sender, EventArgs e)
        {
            dgvSiparisler.DataSource = EmployeeBLL.GetOrders(CustomerID);
        }
    }
}
