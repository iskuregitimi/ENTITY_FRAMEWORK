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
        public int BusinessEntityID { get; internal set; }
        public dlg_MagazaListesi()
        {
            InitializeComponent();
        }

        private void dlg_PersonelMagaza_Load(object sender, EventArgs e)
        {
            dgvPersonelMagaza.DataSource = EmployeeBLL.GetStores(string.Empty);
        }

        private void mağazaDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvPersonelMagaza.SelectedRows[0].Cells["BusinessEntityID"].Value.ToString());
            dlg_MagazaDetay form = new dlg_MagazaDetay();
            form.ShowDialog();
        }
    }
}
