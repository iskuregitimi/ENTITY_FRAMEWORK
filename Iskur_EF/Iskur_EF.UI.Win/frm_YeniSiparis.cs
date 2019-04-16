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
            dataGridView1.DataSource = OrderBLL.GetProducts();

            foreach (var item in OrderBLL.GetSalesPerson())
            {
                cmb_PersonelAdı.Items.Add(item.FirstName);
            }
            //cmb_PersonelAdı.DataSource = OrderBLL.GetSalesPerson();

            foreach (var item in OrderBLL.GetCreditCardID())
            {
                cmb_KrediKartID.Items.Add(item.CreditCardID);
            }
        }
    }
}
