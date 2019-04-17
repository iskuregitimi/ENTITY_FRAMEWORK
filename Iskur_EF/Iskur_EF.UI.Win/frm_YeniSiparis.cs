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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Customer customer = new Customer();
        public int CustomerId = 0;
        
       
        
        public string FirstName { get; set; }
       
        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            customer = CustomerBLL.GetCustomerId(CustomerId);
            lbl_musteriadi.Text = customer.Person.FirstName;

            cmbx_territory.DataSource = TerritoryBLL.GetSalesTerritories();
            cmbx_territory.DisplayMember = "Name";
            cmbx_territory.ValueMember = "TerritoryID";

          var salesperson  = SalesPErsonBLL.GetSalesPeople(string.Empty);
            cmbx_salesperson.DisplayMember = "FirstName";
            cmbx_salesperson.DataSource = salesperson;

            cmbx_bill.DataSource = EmployeeBLL.GetBillToAdressID(CustomerId);
            cmbx_bill.DisplayMember = "AddressLine1";

            cmb_credit.DataSource = EmployeeBLL.GetCreditCard(CustomerId);
            cmb_credit.DisplayMember = "CreditCardID";

            cmbx_currency.DataSource = EmployeeBLL.CurrencyRate();
   
            cmbx_currency.DisplayMember = "Toplam";
            cmbx_currency.ValueMember = "CurrencyRateID";





            dvg_showproducts.DataSource = ProductBLL.GetProductsInformation(string.Empty);
                 


        }
    }
}
