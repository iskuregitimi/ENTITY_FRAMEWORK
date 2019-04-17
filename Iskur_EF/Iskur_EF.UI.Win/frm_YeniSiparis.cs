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

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonID { get; set; }
        public int CustomerID { get; set; }

        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = ProductBLL.GetProducts(string.Empty);
            lblCustomerName.Text = FirstName+" "+LastName ;

            var salesPersons = SalesBLL.GetSalesPeople();
            cmbSalesPersons.DisplayMember = "SalesPersonName";
            cmbSalesPersons.DataSource = salesPersons;

            var creditCards = CustomerBLL.GetPersonCreditCards(PersonID);
            cmbCreditCards.DisplayMember = "CardNumber";
            cmbCreditCards.DataSource = creditCards;

            var currencies = CustomerBLL.GetCurrencyRates();
            cmbCurrencyRate.DisplayMember = "Name";
            cmbCurrencyRate.DataSource = currencies;

            var territories = CustomerBLL.GetTerritories(CustomerID);
            cmbTerritory.DisplayMember = "Name";
            cmbTerritory.DataSource = territories;

            var billtoAdress = CustomerBLL.GetBillToAddressID(PersonID);
            cmbBilltoAdress.DisplayMember = "AddressLine1";
            cmbBilltoAdress.DataSource = billtoAdress;

            cmbShiptoAddress.DisplayMember = "AddressLine1";
            cmbShiptoAddress.DataSource = billtoAdress;

            var shipMethods = CustomerBLL.GetShipMethod();
            cmbShipMethod.DisplayMember = "Name";
            cmbShipMethod.DataSource = shipMethods;
        }

        private void dgvUrunler_SelectionChanged(object sender, EventArgs e)
        {
            //int ProductID = int.Parse(dgvUrunler.SelectedRows[0].Cells["ProductID"].Value.ToString());
            //lblSubTotal.Text = (Convert.ToDecimal(lblSubTotal.Text) + Convert.ToDecimal(CustomerBLL.GetProductPrice(ProductID))).ToString();
        }

        private void dgvUrunler_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvUrunler.Rows[0].Selected = false;
        }

        private void dgvUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ProductID = int.Parse(dgvUrunler.SelectedRows[0].Cells["ProductID"].Value.ToString());
            SalesOrderDetail result = CustomerBLL.GetProductPrice(ProductID);
            lblSubTotal.Text = result.LineTotal.ToString();
            decimal tax = (result.LineTotal) * Convert.ToDecimal(0.18);
            lblTax.Text = tax.ToString();
            decimal freight = (result.LineTotal) * Convert.ToDecimal(0.1);
            lblFreight.Text = freight.ToString();
            lblTotalAmount.Text = (freight + tax + result.LineTotal).ToString();
        }
    }
}
