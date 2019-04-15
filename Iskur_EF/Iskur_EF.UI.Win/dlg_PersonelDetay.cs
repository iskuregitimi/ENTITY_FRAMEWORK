using System;
using Iskur_EF.BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Iskur_EF.DAL;

namespace Iskur_EF.UI.Win
{
    public partial class dlg_PersonelDetay : Form
    {
        public dlg_PersonelDetay()
        {
            InitializeComponent();
        }
        Employee selectedEmployee;
        
        public int businessentityid { get; internal set; }


        private void dlg_PersonelDetay_Load(object sender, EventArgs e)
        {
           Employee emp = EmployeeBLL.GetEmployee(businessentityid);

            selectedEmployee = EmployeeBLL.GetEmployee(businessentityid);
            label1.Text = emp.Person.FirstName;
            label2.Text = emp.Person.LastName;
            label3.Text = emp.Person.MiddleName;
            label4.Text = emp.JobTitle;

            dgvPersonelDetay.DataSource = selectedEmployee.Person.PersonPhones.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
