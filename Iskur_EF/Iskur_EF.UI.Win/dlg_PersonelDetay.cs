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
    public partial class dlg_PersonelDetay : Form
    {
        Employee selectedEmployee;
        public int BusinessEntityID { get; internal set; }
        public dlg_PersonelDetay()
        {
            InitializeComponent();
        }

        private void dlg_PersonelDetay_Load(object sender, EventArgs e)
        {
            selectedEmployee = EmployeeBLL.GetEmployee(BusinessEntityID);
            txtFirstName.Text = selectedEmployee.Person.FirstName;
            txtMiddleName.Text = selectedEmployee.Person.MiddleName;
            txtLastName.Text = selectedEmployee.Person.LastName;
            txtJobTitle.Text = selectedEmployee.JobTitle;

            dgvPersonelDetay.DataSource = selectedEmployee.Person.PersonPhones.ToList();
        }
    }
}
