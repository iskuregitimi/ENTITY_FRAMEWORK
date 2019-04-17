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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OrderBLL.GetProduct();

            cmbSatısPersoneli.DataSource = OrderBLL.Get_SalePerson(); ;
            cmbSatısPersoneli.ValueMember = "BusinessEntityID";
            cmbSatısPersoneli.DisplayMember = "SalesPersonName";


            cmbCreditID.DataSource = OrderBLL.GetCreditCardsID(frm_MusteriListesi.CustomerID);
            cmbCreditID.DisplayMember = "CardNumber"; 
            cmbCreditID.ValueMember = "CardId";

            cmbCurrencyRate.DataSource = OrderBLL.GetCurrencyRate();
            cmbCurrencyRate.DisplayMember = "CurrencyName";
            cmbCurrencyRate.ValueMember = "CurrencyID";

            cmbTerratory.DataSource = OrderBLL.GetTerritoryID();
            cmbTerratory.ValueMember = "TerritoryID";
            cmbTerratory.DisplayMember = "Name";

            cmbBillToAdress.DataSource = OrderBLL.GetBillToAddressID(frm_MusteriListesi.CustomerID);
            cmbBillToAdress.ValueMember = "AdressID";
            cmbBillToAdress.DisplayMember = "AdressLine";

            cmbShippedToAdress.DataSource = OrderBLL.GetBillToAddressID(frm_MusteriListesi.CustomerID);
            cmbShippedToAdress.ValueMember = "AdressID";
            cmbShippedToAdress.DisplayMember = "AdressLine";

            cmbShippedMetod.DataSource = OrderBLL.GetShipMetodID();
            cmbShippedMetod.DisplayMember = "ShipMethodID";
            cmbShippedMetod.ValueMember = "ShipMethodID";

            lblCustomerName.Text = frm_MusteriListesi.CustomerName;
            
        }
        public static decimal ProductListPrice { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            ProductListPrice =(decimal)dataGridView1.CurrentRow.Cells[3].Value;
            int ProductID = (int)dataGridView1.CurrentRow.Cells["ProductID"].Value;

            try
            {
               
                OrderBLL.İnsertOrderHeader(frm_MusteriListesi.CustomerID, Convert.ToInt32(cmbSatısPersoneli.SelectedValue), Convert.ToInt32(cmbTerratory.SelectedValue), Convert.ToInt32(cmbBillToAdress.SelectedValue), Convert.ToInt32(cmbShippedToAdress.SelectedValue), Convert.ToInt32(cmbShippedMetod.SelectedValue), Convert.ToInt32(cmbCreditID.SelectedValue),Convert.ToDouble(ProductListPrice), Convert.ToInt32(cmbCurrencyRate.SelectedValue),textComment.Text);

                OrderBLL.İnsertSaleOrderDetail(ProductID,ProductListPrice);
                MessageBox.Show("Siparişiniz Başarıyla Alınmıştır İyi Günler Dileriz");
            }
            catch
            {

                MessageBox.Show("Siparişiniz İşleminiz Gerçekleştirilemedi");
            }

        }
    }
}
