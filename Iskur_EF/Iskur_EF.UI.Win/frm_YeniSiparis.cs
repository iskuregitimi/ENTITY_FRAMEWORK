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
   
        public int CustomerId { get; internal set; }
        Customer customer = new Customer();
        Employee emp = new Employee();
        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductBLL.GetProducts();
            customer = CustomerBLL.GetCustomer(CustomerId);
            lbl_customerName.Text = customer.Person.FirstName;
            List<Employee> employee = EmployeeBLL.GetSalesPerson();
            cmb_SatisPersoneli.DataSource = employee;
            cmb_SatisPersoneli.DisplayMember =emp.Person.FirstName;
            cmb_SatisPersoneli.ValueMember = "BusinessEntityID";
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            var header = OrderBLL.AddOrder(CustomerId, 100);
            int ProductID = int.Parse(dataGridView1.SelectedRows[0].Cells["ProductID"].Value.ToString());
            Product product = ProductBLL.GetProduct(ProductID);
            OrderBLL.AddOrderDetail(product, header);
        }
    }
}
