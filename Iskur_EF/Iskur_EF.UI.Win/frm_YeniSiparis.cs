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
      
        public int CustomerId { get; internal set; }
        Customer customer = new Customer();
      
        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductBLL.GetProducts();

            customer = CustomerBLL.GetCustomer(CustomerId);
            lbl_customerName.Text = customer.Person.FirstName;
            //Get Sales
            var employee = GetBLL.GetSalesPerson();
            cmb_SatisPersoneli.DataSource = employee;
            cmb_SatisPersoneli.DisplayMember = "FullName";
           //Get CreditCard
            var credi = GetBLL.GetCreditCard();
            cmb_CrediCard.DataSource = credi;
            cmb_CrediCard.DisplayMember = "CreditCardID";
            //Get CurrencyRate
            var currencyrate = GetBLL.GetCurrencyRateID();
            cmb_CurrencyRate.DataSource = currencyrate;
            cmb_CurrencyRate.DisplayMember = "CurrencyRateID";
            //Get Territory
            var territory = GetBLL.GetTerritory();
            cmb_Territory.DataSource = territory;
            cmb_Territory.DisplayMember = "TerritoryID";
            //Get ShipMethod
            var shipmethod = GetBLL.GetShipMethod();
            cmb_ShipMethod.DataSource = shipmethod;
            cmb_ShipMethod.DisplayMember = "ShipMethodID";
           
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            var header = OrderBLL.AddOrder(CustomerId, 100);
            int ProductID = int.Parse(dataGridView1.SelectedRows[0].Cells["ProductID"].Value.ToString());
            Product product = ProductBLL.GetProduct(ProductID);
            OrderBLL.AddOrderDetail(product, header);
        }

   
    }
}
