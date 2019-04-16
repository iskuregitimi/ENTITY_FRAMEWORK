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

        public int BusinessID = 0;

        private void dlg_PersonelDetay_Load(object sender, EventArgs e)
        {
            lbl_FrsName.Text = PersonBLL.GetPerson(BusinessID).FirstName.ToString();
            lbl_LastName.Text= PersonBLL.GetPerson(BusinessID).LastName.ToString();
            lbl_MidName.Text= PersonBLL.GetPerson(BusinessID).MiddleName.ToString();
            lbl_JobTitle.Text = EmployeeBLL.Employee(BusinessID).JobTitle.ToString();
            dgv_Phone.DataSource = PhoneBLL.GetPhones(BusinessID);
        }
    }
}
