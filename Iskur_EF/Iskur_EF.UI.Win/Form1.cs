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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void personDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dlg_PersonelDetay frm = new dlg_PersonelDetay();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void salesStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dlg_Sales frm = new dlg_Sales();
            //frm.MdiParent = this;
            //frm.Show();

        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void storeGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void storeSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_Sales frm = new dlg_Sales();
            frm.MdiParent = this;
            frm.Show();

        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            müsteriListele frm = new müsteriListele();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
