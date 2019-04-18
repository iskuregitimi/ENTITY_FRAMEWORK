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

        SalesOrderHeader salesOrderHeader = new SalesOrderHeader();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonID { get; set; }
        public int CustomerID { get; set; }

        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            salesOrderHeader.CustomerID = CustomerID;
            dgvUrunler.DataSource = ProductBLL.GetProducts(string.Empty);
            lblCustomerName.Text = FirstName+" "+LastName ;

            var salesPersons = SalesBLL.GetSalesPeople();
            cmbSalesPersons.ValueMember = "BusinessEntityID";
            cmbSalesPersons.DisplayMember = "SalesPersonName";
            cmbSalesPersons.DataSource = salesPersons;

            var creditCards = CustomerBLL.GetPersonCreditCards(PersonID);
            cmbCreditCards.ValueMember = "CreditCardID";
            cmbCreditCards.DisplayMember = "CardNumber";
            cmbCreditCards.DataSource = creditCards;

            var currencies = CustomerBLL.GetCurrencyRates();
            cmbCurrencyRate.DisplayMember = "Name";
            cmbCurrencyRate.DataSource = currencies;

            var territories = CustomerBLL.GetTerritories(CustomerID);
            cmbTerritory.ValueMember = "TerritoryID";
            cmbTerritory.DisplayMember = "Name";
            cmbTerritory.DataSource = territories;

            var billtoAdress = CustomerBLL.GetBillToAddressID(PersonID);
            cmbBilltoAdress.ValueMember = "AddressID";
            cmbBilltoAdress.DisplayMember = "AddressLine1";
            cmbBilltoAdress.DataSource = billtoAdress;

            cmbShiptoAddress.ValueMember = "AddressID";
            cmbShiptoAddress.DisplayMember = "AddressLine1";
            cmbShiptoAddress.DataSource = billtoAdress;

            var shipMethods = CustomerBLL.GetShipMethod();
            cmbShipMethod.ValueMember = "ShipMethodID";
            cmbShipMethod.DisplayMember = "Name";
            cmbShipMethod.DataSource = shipMethods;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salesOrderHeader.SalesOrderID = Convert.ToInt32(cmbSalesPersons.SelectedValue);
            salesOrderHeader.TerritoryID = Convert.ToInt32(cmbTerritory.SelectedValue);
            salesOrderHeader.BillToAddressID = Convert.ToInt32(cmbBilltoAdress.SelectedValue);
            salesOrderHeader.ShipToAddressID = Convert.ToInt32(cmbShiptoAddress.SelectedValue);
            salesOrderHeader.ShipMethodID = Convert.ToInt32(cmbShipMethod.SelectedValue);
            salesOrderHeader.CreditCardID = Convert.ToInt32(cmbCreditCards.SelectedValue);
            salesOrderHeader.SubTotal = Convert.ToDecimal(lblSubTotal.Text);
            salesOrderHeader.TaxAmt = Convert.ToDecimal(lblTax.Text);
            salesOrderHeader.Freight = Convert.ToDecimal(lblFreight.Text);
            salesOrderHeader.Comment = txtComment.Text;
            salesOrderHeader.ShipDate = dateTimePicker1.Value;

            var header = SiparisBLL.AddOrder(salesOrderHeader);
            foreach(DataGridViewRow line in dgvUrunler.SelectedRows)
            {
                int productID = int.Parse(line.Cells["ProductID"].Value.ToString());
                Product product = SiparisBLL.GetProduct(productID);
                SiparisBLL.AddOrderDetails(product, header);
            }
            

            MessageBox.Show("Ürün Eklendi!");
        }

        private void dgvUrunler_SelectionChanged(object sender, EventArgs e)
        {
            salesOrderHeader.SubTotal = 0;
            foreach (DataGridViewRow satir in dgvUrunler.SelectedRows)
            {
                string productId = satir.Cells["ProductID"].Value.ToString();
                decimal listPrice = decimal.Parse(satir.Cells["ListPrice"].Value.ToString());
                salesOrderHeader.SubTotal = salesOrderHeader.SubTotal + listPrice;
            }
            ShoHeaderInformation(salesOrderHeader);
        }

        private void ShoHeaderInformation(SalesOrderHeader header)
        {
            lblTax.Text = (header.SubTotal * 0.18m).ToString();
            lblFreight.Text = (header.SubTotal * 0.1m).ToString();
            lblSubTotal.Text = header.SubTotal.ToString();
            decimal toplamtutar = (header.SubTotal * 0.18m) + (header.SubTotal * 0.1m);
            lblTotalAmount.Text = toplamtutar.ToString();
        }
    }
}
