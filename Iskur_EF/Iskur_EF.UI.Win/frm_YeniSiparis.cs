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
            cmb_teriotry.ValueMember = "ShipMethodID";
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

        private void dgv_urunler_DoubleClick(object sender, EventArgs e)
        {  double toplam = 0;
            try
            {
                if (true)
                {
                    productId = int.Parse(dgv_urunler.SelectedRows[0].Cells["ProductID"].Value.ToString());

                    SalesOrderDetail linetotal = ProductsBLL.Linetotal(productId);
                  

                    toplam += Convert.ToDouble(linetotal.LineTotal)/* + Convert.ToDouble(lbl_subTotal.Text)*/;

                    lbl_vergi.Text = (toplam * 0.18).ToString();
                    lbl_nakliye.Text = (toplam * 0.1).ToString();
                    lbl_subTotal.Text = toplam.ToString();
                    double toplamtutar = (toplam * 0.18) + (toplam * 0.1);
                    lbl_toplamtutar.Text = toplamtutar.ToString();

                }


            }
            catch (Exception)
            {

                MessageBox.Show("ÖYLE BİŞEY YOK");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //(int customerID, decimal totalDue, decimal subtotal, int biltoAdressId(personID), int salesAddressId(personID), int shipmetodId)
            int biltoadressId = Convert.ToInt32(cmb_biltoAddress.SelectedValue);
            int salesadressId = Convert.ToInt32(cmb_shipAdress.SelectedValue);
            int shipmetodId = Convert.ToInt32(cmb_shipMetod.SelectedValue);

            var header = SalesBLL.AddOrder(id, Convert.ToDecimal(lbl_toplamtutar),Convert.ToDecimal(lbl_subTotal),biltoadressId,salesadressId,shipmetodId);
            int productID = int.Parse(dgv_urunler.SelectedRows[0].Cells["ProductID"].Value.ToString());
            Product product = ProductsBLL.GETPRODUCT(productID);
            SalesBLL.AddOrderDetails(product, header);

        }
    }
}
