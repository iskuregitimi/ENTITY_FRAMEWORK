using Iskur_Ef.DAL;
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
    public partial class Siparişler_genel_ : Form
    {
        public Siparişler_genel_()
        {
            InitializeComponent();
        }
        Customer selectedcustomer;
        public int CustomerId = 0;
        private void Siparişler_genel__Load(object sender, EventArgs e)
        {

            selectedcustomer = CustomerBLL.GetCustomerDetails(CustomerId);
        
            Customer cust = CustomerBLL.GetCustomerDetails(CustomerId);

            dgv_siparis.DataSource = selectedcustomer.SalesOrderHeaders.ToList();
            //selectedemployee = EmployeeBLL.GetPeople(BussinessEntityId);

            //Employee emp = EmployeeBLL.GetPeople(BussinessEntityId);
            //lbl_firstname.Text = emp.Person.FirstName;
            //lbl_lastname.Text = emp.Person.LastName;
            //lbl_middlename.Text = emp.Person.MiddleName;
            //lbl_JobTitle.Text = emp.JobTitle;

            //dgv_PersonelDetay.DataSource = selectedemployee.Person.PersonPhones.ToList();
            ////dgv_PersonelDetay.DataSource = EmployeeBLL.GetPeople(BussinessEntityId);

        }

        private void siparişDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_siparisDetails frm = new dlg_siparisDetails();


            frm.Show();
        }
    }
}
