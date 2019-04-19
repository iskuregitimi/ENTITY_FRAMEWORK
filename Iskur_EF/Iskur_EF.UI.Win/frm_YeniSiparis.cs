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


        string CrProductName;
        float calculatedvalue;
        float taxamount;
        float freightrate;
        int selectedcurrency;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            
            dgv_urunlistesi.DataSource = MagazaBLL.GetProducts();
            lbl_musteriadi.Text = frm_MusteriListesi.musteribilgi;
            cmb_salesperson.DataSource = EmployeeBLL.GetSalesPerson();
            cmb_salesperson.DisplayMember = "SalesPersonName";
            cmb_salesperson.ValueMember = "BusinessEntityID";
      
            cmb_CreditCard.DataSource = EmployeeBLL.GetCreditCard(frm_MusteriListesi.person_beid);
            cmb_CreditCard.DisplayMember = "CardType";
            cmb_CreditCard.ValueMember = "CreditCardID";
            var currencyRateid = MagazaBLL.GetCurrencyRate();

            cmb_CurrencyRate.DataSource = currencyRateid;
            cmb_CurrencyRate.DisplayMember = "CurrencyCode";
            cmb_CurrencyRate.ValueMember = "CurrencyRateID";
            cmb_billaddress.DataSource = CustomerBLL.GetCustomerAdress(frm_MusteriListesi.person_beid);
            cmb_billaddress.DisplayMember = "Adres";
            cmb_billaddress.ValueMember = "AddressID";

            cmb_shippingAdress.DataSource=CustomerBLL.GetCustomerAdress(frm_MusteriListesi.person_beid);
            cmb_shippingAdress.DisplayMember = "Adres";
            cmb_shippingAdress.ValueMember = "AddressID";
            var territory = CustomerBLL.GetTerritories();

            cmb_Territory.DataSource = territory;
            cmb_Territory.DisplayMember = "Territory";
            cmb_Territory.ValueMember = "TerritoryID";
            
            cmb_shipmethod.DataSource = MagazaBLL.GetShippingMethod();
            cmb_shipmethod.ValueMember = "ShipMethodID";
            cmb_shipmethod.DisplayMember = "ShipCompanies";
        }

        private void comboBox1_Format(object sender, ListControlConvertEventArgs e)
        {
        }

        private void cmb_shippingAdressList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_urunlistesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            CrProductName = dgv_urunlistesi.SelectedRows[0].Cells["Name"].Value.ToString();

            selectedcurrency = Convert.ToInt32(cmb_CurrencyRate.SelectedValue);

            calculatedvalue = Convert.ToSingle(MagazaBLL.CalculateListPriceWithCurrencyRate($"{CrProductName}", selectedcurrency));

            freightrate = MagazaBLL.freightrate(calculatedvalue);

            taxamount = MagazaBLL.TaxAmount(calculatedvalue);


            lbl_TaxAmount.Text = taxamount.ToString();
            lbl_SubTotal.Text = calculatedvalue.ToString();
            lbl_freight.Text = freightrate.ToString();

            lbl_toplam.Text = (freightrate + taxamount + calculatedvalue).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////int personbeid = (cmb_salesperson.SelectedValue));
            //int customerid = frm_MusteriListesi.customer_cid;
            //int territoryid = Convert.ToInt32(cmb_Territory.SelectedValue);
            //int billtoaddress = Convert.ToInt32(cmb_billaddress.SelectedValue);
            //int shiptoaddress = Convert.ToInt32(cmb_billaddress.SelectedValue);
            //int 
            //MagazaBLL.AddOrderHeader(customerid,territoryid,billtoaddress,);

            salesOrderHeader.BillToAddressID = Convert.ToInt32(cmb_billaddress.SelectedValue);
            salesOrderHeader.ShipToAddressID = Convert.ToInt32(cmb_shippingAdress.SelectedValue);
            salesOrderHeader.SalesOrderID = Convert.ToInt32(cmb_shippingAdress.SelectedValue);
            salesOrderHeader.ShipMethodID = Convert.ToInt32(cmb_shipmethod.SelectedValue);
            salesOrderHeader.TerritoryID = Convert.ToInt32(cmb_Territory.SelectedValue);
            salesOrderHeader.CreditCardID = Convert.ToInt32(cmb_CreditCard.SelectedValue);
            salesOrderHeader.SalesOrderID = Convert.ToInt32(cmb_salesperson.SelectedValue);
            salesOrderHeader.CreditCardApprovalCode = (cmb_CreditCard.SelectedValue).ToString();
            salesOrderHeader.SubTotal = Convert.ToDecimal(lbl_SubTotal.Text);
            salesOrderHeader.TotalDue = Convert.ToDecimal(lbl_toplam.Text);
            salesOrderHeader.Comment = txt_comment.Text;
            salesOrderHeader.ShipDate = dtpicker.Value;
            var header = MagazaBLL.AddOrder(salesOrderHeader);

            foreach (DataGridViewRow satir in dgv_urunlistesi.SelectedRows)
            {
                int productID = int.Parse(satir.Cells["ProductID"].Value.ToString());
                Product product = MagazaBLL.GETPRODUCT(productID);
                MagazaBLL.AddOrderDetails(product, header);
            }

            MessageBox.Show("Ürün Başarıyla Eklendi");

        }

        private void cmb_billaddress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
