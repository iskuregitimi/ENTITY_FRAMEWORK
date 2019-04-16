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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PersonelListesi form = new frm_PersonelListesi();
            form.MdiParent = this;
            form.Show();
        }

        private void personelDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void personelDetayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dlg_PersonelDetay detay = new dlg_PersonelDetay();
            detay.MdiParent = this;
            detay.Show();
        }

        private void magazaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_magazalistesi frm = new frm_magazalistesi();
            frm.Show();

        }

        private void müsterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Müsteriler müs = new Müsteriler();
            müs.Show();

        }
    }
}
