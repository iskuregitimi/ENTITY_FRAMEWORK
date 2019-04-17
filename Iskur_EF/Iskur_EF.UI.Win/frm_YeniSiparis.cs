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
            cmb_CurrencyRate.DataSource = MagazaBLL.GetCurrencyRate();
            cmb_CurrencyRate.DisplayMember = "CurrencyCode";
            cmb_CurrencyRate.ValueMember = "CurrencyRateID";
            cmb_billaddress.DataSource = CustomerBLL.GetBillToAddressID(frm_MusteriListesi.person_beid);
            cmb_billaddress.DisplayMember = "AddressLine1";

        }

        private void comboBox1_Format(object sender, ListControlConvertEventArgs e)
        {
        }
    }
}
