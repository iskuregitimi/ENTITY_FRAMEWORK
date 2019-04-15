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
    public partial class frm_Magazalar : Form
    {
        public frm_Magazalar()
        {
            InitializeComponent();
        }

        private void frm_Magazalar_Load(object sender, EventArgs e)
        {
            dgv_Magazalar.DataSource = StoreBLL.GetStores(string.Empty);
        }
    }
}
