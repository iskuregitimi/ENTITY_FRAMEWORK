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
    public partial class frm_MusteriListesi : Form
    {
        public frm_MusteriListesi()
        {
            InitializeComponent();
        }

        private void frm_MusteriListesi_Load(object sender, EventArgs e)
        {
            dgv_MusteriListesi.DataSource = CustomerBLL.GetCustomers(string.Empty);
        }
    }
}
