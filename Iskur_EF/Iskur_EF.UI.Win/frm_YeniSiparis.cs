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
        public int id { get; set; }
        public int teriotyId { get; set; }
        public int personId { get; set; }
        public int productId { get; set; }

        public  string FirstName { get; set; }
        public string LastName { get; set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            Customer customer = CustomerBLL.GetCustomerName(id);
           
            label4.Text = customer.Person.FirstName;
            var teritory = CustomerBLL.getSalesTEritory(teriotyId);
            dgv_urunler.DataSource = ProductsBLL.getProduct(string.Empty);

            var salesPersons = SalesBLL.GetSalesPeople();
            cmb_salesPerson.DisplayMember = "FirstName";
            cmb_salesPerson.DataSource = salesPersons;

            var bolgeTeritory = CustomerBLL.getSalesTEritory(teriotyId);
            cmb_teriotry.DisplayMember = "Name";
            cmb_teriotry.DataSource = bolgeTeritory;

            var creditCard = CredıtCartBLL.getCreditCart(personId);
            cmb_credıtCart.DisplayMember = "CardNumber";
            cmb_credıtCart.DataSource = creditCard;

            var currencery = ProductsBLL.getCurrenny();
            cmb_currency.DisplayMember = "Name";
            cmb_currency.DataSource = currencery;

            var billtoadress = CustomerBLL.GetBillToAddressID(personId);
            cmb_biltoAddress.DisplayMember = "AddressLine1";
            cmb_biltoAddress.DataSource = billtoadress;




            var shipToadress = CustomerBLL.GetShipTOAdress(personId);
            cmb_shipAdress.DisplayMember = "AddressLine1";
            cmb_shipAdress.DataSource = shipToadress;

            var shipEtod = TransportBLL.GetShipmetod();
            cmb_shipMetod.DisplayMember = "Name";
            cmb_shipMetod.DataSource = shipEtod;

           

            //cmb_salesPerson=sales.

        }

        private void dgv_urunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productId = int.Parse(dgv_urunler.SelectedRows[0].Cells["ProductID"].Value.ToString());

            var linetotal = ProductsBLL.Linetotal(productId);

            dgv_urunler.Rows.Add(lbl_subTotal.Text);
            //dgv_urunler.DataSource = tablo;
            int toplam = 0;
        
                toplam += Convert.ToInt32(dgv_urunler.SelectedRows[0].Cells["LineTotal"].Value);
          
            lbl_subTotal.Text = toplam.ToString();
        }
    }
}
