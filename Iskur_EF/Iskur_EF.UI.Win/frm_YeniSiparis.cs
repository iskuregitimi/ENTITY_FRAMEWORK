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
            comboBox7.ValueMember = "CurrencyRateID"; ;

            comboBox1.DataSource = OrderBLL.GetSalePerson();
            comboBox1.DisplayMember = "SalesPersonName";
            comboBox1.ValueMember= "BusinessEntityID";

            comboBox4.DataSource = OrderBLL.GetShipToAddress(CustomerId);
            comboBox4.DisplayMember= "AddressLine1";
            comboBox4.ValueMember = "AddressID";
            

            comboBox3.DataSource = OrderBLL.GetBillToAdress(CustomerId);
            comboBox3.DisplayMember = "AddressLine1";
            comboBox3.ValueMember = "AddressID";


            comboBox5.DataSource = OrderBLL.GetShip();
            comboBox5.DisplayMember = "ShipMethodID";
            comboBox5.ValueMember = "ShipMethodID";
            dataGridView1.DataSource = ProductBLL.GetProducts();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double StandardCost = double.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());

            label12.Text = StandardCost.ToString();
            label14.Text = (StandardCost * 18 / 100).ToString();
            label16.Text = (StandardCost * 1 / 10).ToString();
            label18.Text = (StandardCost + (StandardCost * 18 / 100) + (StandardCost * 1 / 10)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesOrderHeader saless = new SalesOrderHeader();
            saless.CustomerID = CustomerId;
            saless.SalesPersonID = Convert.ToInt32(comboBox1.SelectedValue);
            saless.TerritoryID =  Convert.ToInt32(comboBox2.SelectedValue);
            saless.BillToAddressID = Convert.ToInt32(comboBox3.SelectedValue);
            saless.ShipToAddressID = Convert.ToInt32(comboBox4.SelectedValue);
            saless.ShipMethodID = Convert.ToInt32(comboBox5.SelectedValue);
            saless.CreditCardID= Convert.ToInt32(comboBox6.SelectedValue);
            saless.CurrencyRateID = Convert.ToInt32(comboBox7.SelectedValue);
            saless.SubTotal = Convert.ToDecimal(label12.Text);
            saless.TaxAmt = Convert.ToDecimal(label14.Text);
            saless.Freight= Convert.ToDecimal(label16.Text);
            saless.ShipDate = dateTimePicker1.Value;
            saless.Comment = textBox1.Text;

            var header = OrderBLL.AddOrder(saless);
            MessageBox.Show("kayıt eklendi");
            
        }

    }
}
