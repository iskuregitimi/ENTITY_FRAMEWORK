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

        public int CustomerId=29485;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public int businessEntityId = 0;
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        Employee emp = new Employee();
 
        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            Customer cs = new Customer();
            cs = CustomerBLL.GetCustomer(CustomerId);
            label4.Text = cs.Person.FirstName+"  "+cs.Person.LastName;
            comboBox3.DataSource = OrderBLL.GetBillToAdress(CustomerId);
            comboBox3.DisplayMember = "AddressLine1";
            comboBox1.DataSource = OrderBLL.GetSalePerson();
            comboBox1.DisplayMember = "SalesPersonName";
            comboBox6.DataSource = OrderBLL.GetCrediCard(CustomerId);
            comboBox6.DisplayMember = "CreditCardID";
            comboBox6.ValueMember = "CreditCardID";
            comboBox2.DataSource = OrderBLL.GetTerretory(CustomerId);
            comboBox2.DisplayMember = "TerritoryID";
            comboBox4.DataSource = OrderBLL.GetShipToAddress(CustomerId);
            comboBox4.ValueMember = "AddressLine1";
            comboBox7.DataSource = OrderBLL.GetCurrentyRateId();
            comboBox7.DisplayMember = "CurrencyRateID";

           
        }
    }
}
