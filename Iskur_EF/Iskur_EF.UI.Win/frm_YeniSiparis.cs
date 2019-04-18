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
        public int CustomerId;

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

        
        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {

            Customer cs = new Customer();
            cs = CustomerBLL.GetCustomer(CustomerId);
            label4.Text = cs.Person.FirstName;
            comboBox2.DataSource = OrderBLL.GetTerrotry(CustomerId);
            comboBox2.DisplayMember = "TerritoryID";
            comboBox2.ValueMember= "TerritoryID";
            comboBox6.DataSource = OrderBLL.GetCrediCard(CustomerId);
            comboBox6.DisplayMember = "CreditCardID";
            comboBox6.ValueMember = "CreditCardID";
            comboBox7.DataSource = OrderBLL.GetCurrentyRateId();
            comboBox7.DisplayMember = "CurrencyRateID";
            comboBox1.DataSource = OrderBLL.GetSalePerson();
            comboBox1.DisplayMember = "SalesPersonName";
            comboBox4.DataSource = OrderBLL.GetShipToAddress(CustomerId);
            comboBox4.ValueMember = "AddressLine1";
            comboBox3.DataSource = OrderBLL.GetBillToAdress(CustomerId);
            comboBox3.DisplayMember = "AddressLine1";



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
