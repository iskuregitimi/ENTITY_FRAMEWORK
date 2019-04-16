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
    public partial class SalesPersonDetay : Form
    {
        public SalesPersonDetay()
        {
            InitializeComponent();
        }
  
        public   int SalesPersonId { get; internal set; }
        private void SalesPersonDetay_Load(object sender, EventArgs e)
        {
            dgv_salesPerson.DataSource = EmployeeBLL.GetSalesPerson(SalesPersonId);
            //var salesPerson

        }
    }
}
