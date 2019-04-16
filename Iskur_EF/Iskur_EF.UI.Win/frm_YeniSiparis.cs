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
    public partial class frm_YeniSiparis : Form
    {
        public frm_YeniSiparis()
        {
            InitializeComponent();
        }

        public int CustomerId=29485;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public int businessEntityId = 0;
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        Employee emp = new Employee();
 
        private void frm_YeniSiparis_Load(object sender, EventArgs e)
        {
            Customer cs = new Customer();
            cs = CustomerBLL.GetCustomer(CustomerId);
            label4.Text = cs.Person.FirstName;

        }
    }
}
