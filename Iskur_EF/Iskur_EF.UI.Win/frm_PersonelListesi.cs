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
    public partial class frm_PersonelListesi : Form
    {
        public frm_PersonelListesi()
        {
            InitializeComponent();
        }

        private void frm_PersonelListesi_Load(object sender, EventArgs e)
        {
            var a= EmployeeBLL.GetEployees(textBox1.Text).ToList();
            dataGridView1.DataSource = a;
        }
        public static int BusinessEntityId { get; set; }
        
        private void personelDetayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_PersonelDetay frm = new dlg_PersonelDetay();
            BusinessEntityId= (int)dataGridView1.CurrentRow.Cells[0].Value;
            frm.Show();
        }
    }
}
