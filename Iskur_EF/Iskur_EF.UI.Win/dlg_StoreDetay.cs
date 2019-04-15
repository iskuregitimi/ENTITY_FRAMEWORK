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
    public partial class dlg_StoreDetay : Form
    {
        public dlg_StoreDetay()
        {
            InitializeComponent();
        }
        Store selectedtore;
        public int SalesId = 0;

        private void dlg_StoreDetay_Load(object sender, EventArgs e)
        {
            //selectedtore = EmployeeBLL.GetStoreDetails(SalesId);
            //Store st = EmployeeBLL.GetStoreDetails(SalesId);
            //label1.Text = st.Name;
            //dgv_salesdetay.DataSource = selectedtore

            //Employee emp = EmployeeBLL.GetPeople(BussinessEntityId);
            //lbl_firstname.Text = emp.Person.FirstName;
            //lbl_lastname.Text = emp.Person.LastName;
            //lbl_middlename.Text = emp.Person.MiddleName;
            //lbl_JobTitle.Text = emp.JobTitle;

            //dgv_PersonelDetay.DataSource = selectedemployee.Person.PersonPhones.ToList();
        }
    }
}
