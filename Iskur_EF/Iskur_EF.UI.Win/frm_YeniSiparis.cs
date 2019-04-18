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

        public int CustomerID;
        Customer customer = new Customer();

        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            lbl_MüsteriIsim.Text = frm_MusteriListesi.CustomerName;
            
            dataGridView1.DataSource = OrderBLL.GetProducts();

            cmb_PersonelAdı.DataSource = OrderBLL.GetSalesPerson();
            cmb_PersonelAdı.ValueMember = "BusinessEntityID";
            cmb_PersonelAdı.DisplayMember = "SalesPersonName";

            cmb_KrediKartID.DataSource = OrderBLL.GetCreditCardID(frm_MusteriListesi.CustomerID);
            cmb_KrediKartID.ValueMember = "CreditCardID";
            cmb_KrediKartID.DisplayMember = "KrediKartıListesi";

            cmb_DövizKuruID.DataSource = OrderBLL.GetCurrencyRateID();
            cmb_DövizKuruID.ValueMember = "CurrencyRateID";
            cmb_DövizKuruID.DisplayMember = "DövizKuruListesi";

            cmb_BölgeID.DataSource = OrderBLL.GetSalesTerritoryID();
            cmb_BölgeID.ValueMember = "TerritoryID";
            cmb_BölgeID.DisplayMember = "Name";        

            cmb_FaturaAdresID.DataSource = OrderBLL.GetBillToAddressID(frm_MusteriListesi.CustomerID);
            cmb_FaturaAdresID.ValueMember = "AddressID";
            cmb_FaturaAdresID.DisplayMember = "ShipAdres";

            cmb_ShipToAdresID.DataSource = OrderBLL.GetBillToAddressID(frm_MusteriListesi.CustomerID);
            cmb_ShipToAdresID.ValueMember = "AddressID";
            cmb_ShipToAdresID.DisplayMember = "ShipAdres";

            cmb_ShipMethodID.DataSource = OrderBLL.GetShipMethodID();
            cmb_ShipMethodID.ValueMember = "ShipMethodID";
            cmb_ShipMethodID.DisplayMember = "Name";

        }

        public static decimal ProductListPrice { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductListPrice = (decimal)dataGridView1.CurrentRow.Cells[3].Value;
            int ProductID = (int)dataGridView1.CurrentRow.Cells["ProductID"].Value;

            try
            {

                OrderBLL.İnsertOrderHeader(frm_MusteriListesi.CustomerID, 
                    Convert.ToInt32(cmb_PersonelAdı.SelectedValue), 
                    Convert.ToInt32(cmb_BölgeID.SelectedValue), 
                    Convert.ToInt32(cmb_FaturaAdresID.SelectedValue), 
                    Convert.ToInt32(cmb_ShipToAdresID.SelectedValue), 
                    Convert.ToInt32(cmb_ShipMethodID.SelectedValue), 
                    Convert.ToInt32(cmb_KrediKartID.SelectedValue), 
                    Convert.ToDouble(ProductListPrice), 
                    Convert.ToInt32(cmb_DövizKuruID.SelectedValue), txt_Comment.Text);

                OrderBLL.İnsertSaleOrderDetail(ProductID, ProductListPrice);
                MessageBox.Show("Siparişiniz Başarıyla Alınmıştır İyi Günler Dileriz");
            }
            catch
            {

                MessageBox.Show("Siparişiniz İşleminiz Gerçekleştirilemedi");
            }
        }
    }
}
