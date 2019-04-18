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
    public partial class dlg_PersonelGuncelle : Form
    {
        public int BusinessEntityID;
        public dlg_PersonelGuncelle()
        {
            InitializeComponent();
        }

        private void dlg_PersonelGuncelle_Load(object sender, EventArgs e)
        {
            Employee emp = EmployeeBLL.GetPeople(BusinessEntityID);
            txtAdi.Text = emp.Person.FirstName + " " + emp.Person.MiddleName;
            txtSoyadi.Text = emp.Person.LastName;
            txtGorevi.Text = emp.JobTitle;
            txtKimlikNo.Text = emp.NationalIDNumber;
            dtpDogumTarihi.Value = emp.BirthDate;
            if (emp.MaritalStatus == "S")
                cbSingle.Checked = true;
            else
                cbMarried.Checked = true;
            dtpBaslamaTarihi.Value = emp.HireDate;
            txtTelefon.Text = emp.Person.PersonPhones.FirstOrDefault().PhoneNumber;

        }
    }
}
