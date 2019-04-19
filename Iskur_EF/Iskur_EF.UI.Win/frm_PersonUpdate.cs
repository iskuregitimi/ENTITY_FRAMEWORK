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
    public partial class frm_PersonUpdate : Form
    {
        public frm_PersonUpdate()
        {
            InitializeComponent();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            EmployeeBLL.EmpoyeeUpdate(EmployeeBLL.BEID, textFirstName.Text, textMiddleName.Text, textLastName.Text, textTitleJop.Text);
            this.Hide();
        }
    }
}
