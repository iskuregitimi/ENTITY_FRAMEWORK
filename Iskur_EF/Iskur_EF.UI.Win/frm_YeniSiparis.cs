﻿using Iskur_EF.BLL;
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

        public int CustomerId;
        Customer customer = new Customer();
        SalesOrderHeader salesheader = new SalesOrderHeader();
        SalesOrderDetail detail = new SalesOrderDetail();

        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductBLL.GetProducts();

            customer = CustomerBLL.GetCustomer(CustomerId);
            lbl_customerName.Text = customer.Person.FirstName+ " " + customer.Person.LastName;
            
            //Get Sales
            var employee = GetBLL.GetSalesPerson();
            cmb_SatisPersoneli.DataSource = employee;
            cmb_SatisPersoneli.DisplayMember = "FullName";
            cmb_SatisPersoneli.ValueMember = "BusinessEntityID";
            //Get CreditCard
            var credi = GetBLL.GetCreditCard(CustomerId);
            cmb_CrediCard.DataSource = credi;
            cmb_CrediCard.DisplayMember = "CreditCardID";
            cmb_CrediCard.ValueMember = "CreditCardID";

            //Get CurrencyRate
            var currencyrate = GetBLL.GetCurrencyRateID();
            cmb_CurrencyRate.DataSource = currencyrate;
            cmb_CurrencyRate.DisplayMember = "CurrencyRateID";
            cmb_CurrencyRate.ValueMember = "CurrencyRateID";
            
            //Get Territory
            var territory = GetBLL.GetTerritory(CustomerId);
            cmb_Territory.DataSource = territory;
            cmb_Territory.DisplayMember = "TerritoryID";
            cmb_Territory.ValueMember = "TerritoryID";
            //Get BilltoAddress
            var address = GetBLL.GetBilltoAddress(CustomerId);
            cmb_BilltoAddress.DataSource = address;
            cmb_BilltoAddress.DisplayMember = "AddressLine1";
            cmb_BilltoAddress.ValueMember = "AddressID";
            cmb_ShiptoAddress.DataSource = address;
            cmb_ShiptoAddress.DisplayMember = "AddressLine1";
            cmb_ShiptoAddress.ValueMember = "AddressID";
            //Get ShipMethod
            var shipmethod = GetBLL.GetShipMethod();
            cmb_ShipMethod.DataSource = shipmethod;
            cmb_ShipMethod.DisplayMember = "Name";
            cmb_ShipMethod.ValueMember = "ShipMethodID";


        }       
        private void button1_Click_1(object sender, EventArgs e)
        {
            salesheader.CustomerID = CustomerId;
            DateTime tarih=dtm_ShipDate.Value;
            salesheader.SalesPersonID =Convert.ToInt32(cmb_SatisPersoneli.SelectedValue);
            salesheader.CreditCardID = Convert.ToInt32(cmb_CrediCard.SelectedValue);
            salesheader.CurrencyRateID = Convert.ToInt32(cmb_CurrencyRate.SelectedValue);
            salesheader.TerritoryID = Convert.ToInt32(cmb_Territory.SelectedValue);
            salesheader.BillToAddressID = Convert.ToInt32(cmb_BilltoAddress.SelectedValue);
            salesheader.ShipToAddressID = Convert.ToInt32(cmb_ShiptoAddress.SelectedValue);
            salesheader.ShipMethodID = Convert.ToInt32(cmb_ShipMethod.SelectedValue);
            salesheader.SubTotal = Convert.ToDecimal(lbl_SubTotal.Text);
            salesheader.TaxAmt = Convert.ToDecimal(lbl_TaxAmount.Text);
            salesheader.Freight = Convert.ToDecimal(lbl_Freight.Text);
            salesheader.Comment = txt_Comment.Text;

            var header = OrderBLL.AddOrder(salesheader,tarih);
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                int ProductID = int.Parse(item.Cells["ProductID"].Value.ToString());
                Product product = ProductBLL.GetProduct(ProductID);
                OrderBLL.AddOrderDetail(product,header);
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            salesheader.SubTotal = 0;

            foreach (DataGridViewRow satir in dataGridView1.SelectedRows)
            {
                int ProductId =int.Parse(satir.Cells["ProductID"].Value.ToString());
                Product sonuc = GetBLL.GetSubTotal(ProductId);
               salesheader.SubTotal =salesheader.SubTotal +sonuc.StandardCost;
            }

            ShoHeaderInformation(salesheader);
        }

        private void ShoHeaderInformation(SalesOrderHeader salesheader)
        {
            lbl_SubTotal.Text = salesheader.SubTotal.ToString();
            lbl_TaxAmount.Text = (salesheader.SubTotal * 0.18m).ToString();
            lbl_Freight.Text = (salesheader.SubTotal * 0.1m).ToString();          
            lbl_LineTotal.Text = (salesheader.SubTotal + salesheader.TaxAmt + salesheader.Freight).ToString();
        }
    }
}
