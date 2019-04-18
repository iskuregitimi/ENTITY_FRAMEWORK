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
        public int ProductID = 0;
       
        
        public string FirstName { get; set; }
       
        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            customer = CustomerBLL.GetCustomerId(CustomerId);
            lbl_musteriadi.Text = customer.Person.FirstName;

            var territory = EmployeeBLL.GetTerritories(CustomerId);
            cmbx_territory.DisplayMember = "Name";
            cmbx_territory.ValueMember = "TerritoryID";
            cmbx_territory.DataSource = territory;

          var salesperson  = SalesPErsonBLL.GetSalesPeople();
            cmbx_salesperson.ValueMember = "BusinessEntityID";
            cmbx_salesperson.DisplayMember = "FirstName";
            cmbx_salesperson.DataSource = salesperson;

            var  billadres = EmployeeBLL.GetBillToAdressID(CustomerId);
            cmbx_bill.ValueMember = "AddressID";
            cmbx_bill.DisplayMember = "AddressLine1";
            cmbx_bill.DataSource = billadres;
            
            cmbx_shipadres.ValueMember = "AddressID";
            cmbx_shipadres.DisplayMember = "AddressLine1";
            cmbx_shipadres.DataSource = billadres;
            
            var  credit = EmployeeBLL.GetCreditCard(CustomerId);
            cmb_credit.ValueMember = "CreditCardID";
            cmb_credit.DisplayMember = "CardNumber";
            cmb_credit.DataSource = credit;

           var shipmethod = EmployeeBLL.GetShipMethodName();
            cmbx_shipmethodid.ValueMember = "ShipMethodID";
            cmbx_shipmethodid.DisplayMember = "Name";
            cmbx_shipmethodid.DataSource = shipmethod;


          var currency = EmployeeBLL.CurrencyRate();   
            cmbx_currency.DisplayMember = "Toplam";
            cmbx_currency.ValueMember = "CurrencyRateID";
            cmbx_currency.DataSource = currency;

            dvg_showproducts.DataSource = ProductBLL.GetProductsInformation(string.Empty);

            string comment = "Ürün alındı";
            txt_comment.Text = comment;
        }

        private void dvg_showproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ProductID = int.Parse(dvg_showproducts.SelectedRows[0].Cells["ProductID"].Value.ToString());
            Product islemler = EmployeeBLL.GetProuctID(ProductID);
            lbl_subtotal.Text = islemler.StandardCost.ToString();
            decimal tax = (islemler.StandardCost) * Convert.ToDecimal(0.18);
            lbl_tax.Text = tax.ToString();
            decimal nakliye= (islemler.StandardCost) * Convert.ToDecimal(0.1);
            lbl_nakliye.Text= nakliye.ToString();
            lbl_toplamtutar.Text = (nakliye + tax + islemler.StandardCost).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salePersonID = Convert.ToInt32(cmbx_salesperson.SelectedValue);
            int territoryID = Convert.ToInt32(cmbx_territory.SelectedValue);
            int billToAdressID = Convert.ToInt32(cmbx_bill.SelectedValue);
            int shiptoadressID = Convert.ToInt32(cmbx_shipadres.SelectedValue);
            int shipmethodID = Convert.ToInt32(cmbx_shipmethodid.SelectedValue);
            int creditcardID = Convert.ToInt32(cmb_credit.SelectedValue);
            decimal subTotal = Convert.ToDecimal(lbl_subtotal.Text);
            decimal tax = Convert.ToDecimal(lbl_tax.Text);
            decimal freight = Convert.ToDecimal(lbl_nakliye.Text);
            string comment = txt_comment.Text;

            var header = SiparislerBLL.AddOrder(CustomerId, salePersonID, territoryID, billToAdressID, shiptoadressID, shipmethodID, creditcardID, subTotal, tax, freight, comment);
            int ProductID = int.Parse(dvg_showproducts.SelectedRows[0].Cells["ProductID"].Value.ToString());
        }

        private void lbl_toplamtutar_Click(object sender, EventArgs e)
        {

        }
    }
}
