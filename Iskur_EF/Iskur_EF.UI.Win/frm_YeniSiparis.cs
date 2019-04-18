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

        SalesOrderHeader salesOrderHeader = new SalesOrderHeader();

        public frm_YeniSiparis()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        public int teriotyId { get; set; }
        public int personId { get; set; }
        public int productId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {

            salesOrderHeader.CustomerID = id;

            Customer customer = CustomerBLL.GetCustomerName(id);

            label4.Text = customer.Person.FirstName;
            var teritory = CustomerBLL.getSalesTEritory(teriotyId);
            dgv_urunler.DataSource = ProductsBLL.getProduct(string.Empty);

            var salesPersons = SalesBLL.GetSalesPeople();
            cmb_salesPerson.DisplayMember = "FirstName";
            cmb_salesPerson.ValueMember = "BusinessEntityID";
            cmb_salesPerson.DataSource = salesPersons;

            var bolgeTeritory = CustomerBLL.getSalesTEritory(teriotyId);
            cmb_teriotry.ValueMember = "TerritoryID";
            cmb_teriotry.DisplayMember = "Name";
            cmb_teriotry.DataSource = bolgeTeritory;

            var creditCard = CredıtCartBLL.getCreditCart(personId);
            cmb_credıtCart.DisplayMember = "CardNumber";
            cmb_credıtCart.ValueMember = "CreditCardID";
            cmb_credıtCart.DataSource = creditCard;

            var currencery = ProductsBLL.getCurrenny();
            cmb_currency.ValueMember = "CurrencyCode";
            cmb_currency.DisplayMember = "Name";
            cmb_currency.DataSource = currencery;

            var billtoadress = CustomerBLL.GetBillToAddressID(personId);
            cmb_biltoAddress.ValueMember = "AddressID";
            cmb_biltoAddress.DisplayMember = "AddressLine1";
            cmb_biltoAddress.DataSource = billtoadress;




            var shipToadress = CustomerBLL.GetShipTOAdress(personId);
            cmb_shipAdress.ValueMember = "AddressID";
            cmb_shipAdress.DisplayMember = "AddressLine1";
            cmb_shipAdress.DataSource = shipToadress;

            var shipEtod = TransportBLL.GetShipmetod();
            cmb_shipMetod.ValueMember = "ShipMethodID";
            cmb_shipMetod.DisplayMember = "Name";
            cmb_shipMetod.DataSource = shipEtod;






            //cmb_salesPerson=sales.

        }

        private void dgv_urunler_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            //(int customerID, decimal totalDue, decimal subtotal, int biltoAdressId(personID), int salesAddressId(personID), int shipmetodId)
            //int biltoadressId = Convert.ToInt32(cmb_biltoAddress.SelectedValue);
            salesOrderHeader.BillToAddressID = Convert.ToInt32(cmb_biltoAddress.SelectedValue);
            salesOrderHeader.ShipToAddressID = Convert.ToInt32(cmb_shipAdress.SelectedValue);
            salesOrderHeader.SalesOrderID = Convert.ToInt32(cmb_shipAdress.SelectedValue);
            salesOrderHeader.ShipMethodID = Convert.ToInt32(cmb_shipMetod.SelectedValue);
            salesOrderHeader.TerritoryID = Convert.ToInt32(cmb_teriotry.SelectedValue);
            salesOrderHeader.CreditCardID = Convert.ToInt32(cmb_credıtCart.SelectedValue);
            salesOrderHeader.SalesOrderID = Convert.ToInt32(cmb_salesPerson.SelectedValue);
            salesOrderHeader.CreditCardApprovalCode = (cmb_credıtCart.SelectedValue).ToString();
            salesOrderHeader.SubTotal = Convert.ToDecimal(lbl_subTotal.Text);
            salesOrderHeader.TotalDue = Convert.ToDecimal(lbl_toplamtutar.Text);
            salesOrderHeader.Comment = txt_comment.Text;
            salesOrderHeader.ShipDate = dtpicker.Value;
            var header = SalesBLL.AddOrder(salesOrderHeader);

            foreach (DataGridViewRow satir in dgv_urunler.SelectedRows)
            {
                int productID = int.Parse(satir.Cells["ProductID"].Value.ToString());
                Product product = ProductsBLL.GETPRODUCT(productID);
                SalesBLL.AddOrderDetails(product, header);
            }

            MessageBox.Show("Ürün Başarıyla Eklendi");
        }

        private void dgv_urunler_SelectionChanged(object sender, EventArgs e)
        {
            salesOrderHeader.SubTotal = 0;

            // Header toplam değerlerini burada hesapla

            foreach (DataGridViewRow satir in dgv_urunler.SelectedRows)
            {
                string productId = satir.Cells["ProductID"].Value.ToString();
                decimal listPrice = decimal.Parse(satir.Cells["ListPrice"].Value.ToString());
                salesOrderHeader.SubTotal = salesOrderHeader.SubTotal + listPrice;

            }

            ShoHeaderInformation(salesOrderHeader);
        }

        private void ShoHeaderInformation(SalesOrderHeader header)
        {
            lbl_vergi.Text = (header.SubTotal * 0.18m).ToString();
            lbl_nakliye.Text = (header.SubTotal * 0.1m).ToString();
            lbl_subTotal.Text = header.SubTotal.ToString();
            decimal toplamtutar = (header.SubTotal * 0.18m) + (header.SubTotal * 0.1m);
            lbl_toplamtutar.Text = toplamtutar.ToString();

        }
    }
}
