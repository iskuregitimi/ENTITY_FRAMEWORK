using Iskur_EF.BLL;
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

        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = ProductBLL.GetProducts(string.Empty);
            lblCustomerName.Text = FirstName+" "+LastName ;
            var salesPersons = SalesBLL.GetSalesPeople();

            cmbSalesPersons.DisplayMember = "FirstName";
            cmbSalesPersons.DataSource = salesPersons;

            var getcredıtcart = CredıtCartBLL.GetCrediCard();
            cmb_credıcart.DisplayMember = "CreditCardID";
            cmb_credıcart.DataSource = getcredıtcart;

            var getBolge = SalesBLL.GetTerritories();
            cmb_bölge.DisplayMember = "Name";
            cmb_bölge.DataSource = getBolge;
            var getShipMetod = ShipBLL.GetShipMethods();
            cmb_ShipMetod.DisplayMember = "Name";
            cmb_ShipMetod.DataSource = getShipMetod;
            //var getShipDate = ShipBLL.GetPurchaseOrderHeaders();
            //DateTimePicker.
            //var getfaturaadress = AdressBLL.getFaturaAddress();
            //cmb_getFaturaAdress.DisplayMember = "AddressLine1";
            //cmb_getFaturaAdress.DataSource = getfaturaadress;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
