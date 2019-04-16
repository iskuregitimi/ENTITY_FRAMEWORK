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

        
        public int Id;
        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            Customer c = CustomerBLL.GetCustomer(Id);
            label4.Text = c.Person.FirstName;
            cmb_bolge.DataSource = bolgeler.GetSalesTerritory();
            cmb_bolge.DisplayMember = "Name";
            cmb_bolge.ValueMember = "TerritoryID";

        }

        private void cmb_bolge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
