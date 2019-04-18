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
      
        public dlg_PersonelDetay()
        {
            InitializeComponent();
        }

        Employee emp = new Employee();
        Store store = new Store();

        public int businessEntityId;

   

        private void dlg_PersonelDetay_Load(object sender, EventArgs e)
        {


            emp = EmployeeBLL.GetPeople(businessEntityId);
            txt_Firstname.Text = emp.Person.FirstName;
            txt_Middlename.Text = emp.Person.MiddleName;
            txt_Lastname.Text = emp.Person.LastName;
            txt_Jobtitle.Text = emp.JobTitle;

            dataGridView1.DataSource = emp.Person.PersonPhones.ToList();

        }
    }
}
