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
    public partial class dlg_PersonelDetay : Form
    {
        public dlg_PersonelDetay()
        {
            InitializeComponent();
        }
        Employee selectedemployee;
        public int BussinessEntityId = 0;
        private void dlg_PersonelDetay_Load(object sender, EventArgs e)
        {

            selectedemployee = EmployeeBLL.GetPeople(BussinessEntityId);

                
            Employee emp = EmployeeBLL.GetPeople(BussinessEntityId);
            lbl_firstname.Text = emp.Person.FirstName;
            lbl_lastname.Text = emp.Person.LastName;
            lbl_middlename.Text = emp.Person.MiddleName;
            lbl_JobTitle.Text = emp.JobTitle;

            dgv_PersonelDetay.DataSource = selectedemployee.Person.PersonPhones.ToList();
            //dgv_PersonelDetay.DataSource = EmployeeBLL.GetPeople(BussinessEntityId);

        }
    }
}
