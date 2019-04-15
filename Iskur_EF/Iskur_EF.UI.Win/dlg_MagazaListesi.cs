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
    public partial class dlg_MagazaListesi : Form
    {
        public dlg_MagazaListesi()
        {
            InitializeComponent();
        }

        private void dlg_MagazaListesi_Load(object sender, EventArgs e)
        {
            dgv_magazalistesi.DataSource = StoreBLL.GetStores(string.Empty);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgv_magazalistesi.DataSource = StoreBLL.GetStores(txt_Magaza.Text);
        }
    }
}
