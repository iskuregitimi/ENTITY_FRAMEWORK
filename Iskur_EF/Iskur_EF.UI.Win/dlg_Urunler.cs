﻿using Iskur_EF.BLL;
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
    public partial class dlg_Urunler : Form
    {
        public dlg_Urunler()
        {
            InitializeComponent();
        }

        private void dlg_Urunler_Load(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = UrunlerBLL.GetProducts(string.Empty);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var header = OrderBLL.AddOrder(id, 100);
            int productID = int.Parse(dgv_Products.SelectedRows[0].Cells["ProductID"].Value.ToString());
            Product product = ProductBLL.GetProduct(productID);
            OrderDetaisBLL.AddOrderDetails(product, header);
        }
    }
}
