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
    public partial class dlg_Magaza : Form
    {
        public dlg_Magaza()
        {
            InitializeComponent();
        }

        public int SalesPersonId { get; private set; }

        private void dlg_Magaza_Load(object sender, EventArgs e)
        {
            dgv_Magaza.DataSource = MagazaBLL.GetStores(string.Empty);
        }

        private void satışPersoneliGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            dlg_PersonelDetay form = new dlg_PersonelDetay();
            form.businessEntityId= int.Parse(dgv_Magaza.SelectedRows[0].Cells["SalesPersonID"].Value.ToString());
            form.Show();
        }

    }
}
