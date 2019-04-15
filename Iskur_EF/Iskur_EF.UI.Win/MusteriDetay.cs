
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
    public partial class MusteriDetay : Form
    {
        public MusteriDetay()
        {
            InitializeComponent();
        }
        Customer selectedcustomer;
        public int customerID = 0;
        private void MusteriDetay_Load(object sender, EventArgs e)
        {
            selectedcustomer = CustomerBLL.GetCustomerDetail(customerID);

            dataGridView1.DataSource = CustomerBLL.GetCustomerDetail(customerID);
            SalesOrderHeader cstmr = CustomerBLL.GetCustomerDetail(customerID);
            label1.Text = cstmr.CustomerID.ToString();
            
        }
    }
}
