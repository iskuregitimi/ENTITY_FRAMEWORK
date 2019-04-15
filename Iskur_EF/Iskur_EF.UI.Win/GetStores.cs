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
    public partial class GetStores : Form
    {
        public GetStores()
        {
            InitializeComponent();
        }

        private void GetStores_Load(object sender, EventArgs e)
        {
             dataGridView1.DataSource=   EmployeeBLL.GetStore(textBox1.Text);
        }

        private void GetStores_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeeBLL.GetStore(textBox1.Text);
        }
        public static int BIED { get; set; }
        private void satıcıBilgileriniGetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
