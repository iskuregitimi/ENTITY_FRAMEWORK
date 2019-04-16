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
    public partial class frm_YeniSiparis : Form
    {
        public frm_YeniSiparis()
        {
            InitializeComponent();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = ProductBLL.GetProducts(string.Empty);
            lblCustomerName.Text = FirstName+" "+LastName ;
            var salesPersons = SalesBLL.GetSalesPeople();

            cmbSalesPersons.DisplayMember = "FirstName";
            cmbSalesPersons.DataSource = salesPersons;
        }
    }
}
