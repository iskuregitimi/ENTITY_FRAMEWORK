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
    public partial class frm_YeniSiparis : Form
    {
        public frm_YeniSiparis()
        {
            InitializeComponent();
        }

        public int id;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            Customer customer = CustomerBLL.GetCustomerName(id);
            lbl_CustomerName.Text = customer.Person.FirstName+" "+customer.Person.LastName;
            cmb_TerritoryID.DataSource = TerritoryBLL.GetSalesTerritory();
            cmb_TerritoryID.DisplayMember = "Name";
            cmb_TerritoryID.ValueMember = "TerritoryID";
            dataGridView1.DataSource = ProductBLL.GetProducts();
        }
    }
}
