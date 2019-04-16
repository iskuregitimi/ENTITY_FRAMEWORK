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
        Employee selectemployee;
        public dlg_PersonelDetay()
        {
            InitializeComponent();
        }

        public int BusinessEntityID { get; internal set; }

        private void dlg_PersonelDetay_Load(object sender, EventArgs e)
        {

            //dgv_PersonelDetay.DataSource = EmployeeBLL.GetBusinessEntity();

            selectemployee = EmployeeBLL.GetBusinessEntity(BusinessEntityID);
            txt_name.Text = selectemployee.Person.FirstName;
            txt_midleName.Text= selectemployee.Person.MiddleName;
            txt_LastName.Text  = selectemployee.Person.LastName;
            txt_JobTitle.Text = selectemployee.JobTitle;
            dgv_PersonelDetay.DataSource = selectemployee.Person.PersonPhones.ToList();
        }
    }
}
