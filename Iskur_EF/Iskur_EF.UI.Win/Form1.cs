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

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void personelDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_PersonelDetay form = new dlg_PersonelDetay();
            form.MdiParent = this;
            form.Show();

        }

        private void magazaLİstesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

           MagazaListesi  form = new MagazaListesi();
            form.MdiParent = this;
            form.Show();

        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void musterileriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteriListesi frm = new FrmMusteriListesi();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
