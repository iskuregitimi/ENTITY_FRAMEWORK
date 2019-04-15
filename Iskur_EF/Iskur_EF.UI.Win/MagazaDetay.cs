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
    public partial class MagazaDetay : Form
    {
        public int SalesPersonID{ get; internal set; }

        public MagazaDetay()
        {
            InitializeComponent();
        }

        private void MagazaDetay_Load(object sender, EventArgs e)
        {
            
            Store store = EmployeeBLL.GetStore(SalesPersonID);
            label1.Text = store.Name.ToString();

          

            
        }
    }
}
