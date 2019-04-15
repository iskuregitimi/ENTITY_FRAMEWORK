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
        public dlg_PersonelDetay()
        {
            InitializeComponent();
        }
        public int BusinessEntitiyID { get; internal set; }

        private void dlg_PersonelDetay_Load(object sender, EventArgs e)
        {
            selectedEmployee = EmployeeBLL.GetEmployee(BusinessEntitiyID);

            lbl_firstname.Text = selectedEmployee.Person.FirstName;
            lbl_middlename.Text = selectedEmployee.Person.MiddleName;
            lbl_lastname.Text = selectedEmployee.Person.LastName;
            lbl_jobtitle.Text = selectedEmployee.JobTitle;

            dgv_PhoneNumbers.DataSource = selectedEmployee.Person.PersonPhones.ToList();
        }
    }
}
