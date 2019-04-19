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
    public partial class frm_PersonelGüncelle : Form
    {
        internal int busines;

        public frm_PersonelGüncelle()
        {
            InitializeComponent();
        }

        public int PersonelID;

        private void btn_PersonelGüncelle_Click(object sender, EventArgs e)
        {
            Employee emp = EmployeeBLL.GetPeople(PersonelID);
            emp.Person.FirstName = txt_Firstname.Text;
            emp.Person.LastName = txt_Lastname.Text;
            emp.Person.MiddleName = txt_Middlename.Text;
            emp.JobTitle = txt_Jobtitle.Text;
            EmployeeBLL.UpdateEmployee(emp);

        }

    }
}
