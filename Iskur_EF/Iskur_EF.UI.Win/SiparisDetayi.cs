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
    public partial class SiparisDetayi : Form
    {
        public SiparisDetayi()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void SiparisDetayi_Load(object sender, EventArgs e)
        {
            dgv_SiparisDetayi.DataSource = OrderDetaisBLL.GetOrderDetails(id);
        }
    }
}
