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

        private void mağazaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Magazalar form = new frm_Magazalar();
            form.MdiParent = this;
            form.Show();
        }
    }
}
