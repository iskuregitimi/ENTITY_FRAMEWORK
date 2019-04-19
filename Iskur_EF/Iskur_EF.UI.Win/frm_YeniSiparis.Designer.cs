﻿namespace Iskur_EF.UI.Win
{
    partial class frm_YeniSiparis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_urunlistesi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_salesperson = new System.Windows.Forms.ComboBox();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.lbl_musteriadi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Territory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_billaddress = new System.Windows.Forms.ComboBox();
            this.cmb_shippingAdress = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_shipmethod = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_CreditCard = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_CurrencyRate = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_SubTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_TaxAmount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_freight = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunlistesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_urunlistesi
            // 
            this.dgv_urunlistesi.AllowUserToAddRows = false;
            this.dgv_urunlistesi.AllowUserToDeleteRows = false;
            this.dgv_urunlistesi.AllowUserToOrderColumns = true;
            this.dgv_urunlistesi.AllowUserToResizeRows = false;
            this.dgv_urunlistesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_urunlistesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_urunlistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_urunlistesi.Location = new System.Drawing.Point(10, 202);
            this.dgv_urunlistesi.Name = "dgv_urunlistesi";
            this.dgv_urunlistesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_urunlistesi.Size = new System.Drawing.Size(657, 222);
            this.dgv_urunlistesi.TabIndex = 0;
            this.dgv_urunlistesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_urunlistesi_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kargo Tarihi (ShipDate)";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Satış Personeli";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_salesperson
            // 
            this.cmb_salesperson.DisplayMember = "Firstname,LastName";
            this.cmb_salesperson.FormattingEnabled = true;
            this.cmb_salesperson.Location = new System.Drawing.Point(164, 59);
            this.cmb_salesperson.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_salesperson.Name = "cmb_salesperson";
            this.cmb_salesperson.Size = new System.Drawing.Size(151, 21);
            this.cmb_salesperson.TabIndex = 2;
            this.cmb_salesperson.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBox1_Format);
            // 
            // dtpicker
            // 
            this.dtpicker.Location = new System.Drawing.Point(164, 37);
            this.dtpicker.Margin = new System.Windows.Forms.Padding(2);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(151, 20);
            this.dtpicker.TabIndex = 3;
            this.dtpicker.ValueChanged += new System.EventHandler(this.dtpicker_ValueChanged);
            // 
            // lbl_musteriadi
            // 
            this.lbl_musteriadi.AutoSize = true;
            this.lbl_musteriadi.Location = new System.Drawing.Point(161, 18);
            this.lbl_musteriadi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_musteriadi.Name = "lbl_musteriadi";
            this.lbl_musteriadi.Size = new System.Drawing.Size(35, 13);
            this.lbl_musteriadi.TabIndex = 4;
            this.lbl_musteriadi.Text = "label4";
            this.lbl_musteriadi.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bölge (TerritoryID)";
            // 
            // cmb_Territory
            // 
            this.cmb_Territory.FormattingEnabled = true;
            this.cmb_Territory.Location = new System.Drawing.Point(483, 18);
            this.cmb_Territory.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Territory.Name = "cmb_Territory";
            this.cmb_Territory.Size = new System.Drawing.Size(185, 21);
            this.cmb_Territory.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fatura Adresi(BillToAddress)";
            // 
            // cmb_billaddress
            // 
            this.cmb_billaddress.FormattingEnabled = true;
            this.cmb_billaddress.Location = new System.Drawing.Point(483, 40);
            this.cmb_billaddress.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_billaddress.Name = "cmb_billaddress";
            this.cmb_billaddress.Size = new System.Drawing.Size(185, 21);
            this.cmb_billaddress.TabIndex = 2;
            this.cmb_billaddress.SelectedIndexChanged += new System.EventHandler(this.cmb_billaddress_SelectedIndexChanged);
            // 
            // cmb_shippingAdress
            // 
            this.cmb_shippingAdress.FormattingEnabled = true;
            this.cmb_shippingAdress.Location = new System.Drawing.Point(483, 64);
            this.cmb_shippingAdress.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_shippingAdress.Name = "cmb_shippingAdress";
            this.cmb_shippingAdress.Size = new System.Drawing.Size(185, 21);
            this.cmb_shippingAdress.TabIndex = 2;
            this.cmb_shippingAdress.SelectedIndexChanged += new System.EventHandler(this.cmb_shippingAdressList_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Teslimat Adresi(ShipToAddress)";
            // 
            // cmb_shipmethod
            // 
            this.cmb_shipmethod.FormattingEnabled = true;
            this.cmb_shipmethod.Location = new System.Drawing.Point(483, 90);
            this.cmb_shipmethod.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_shipmethod.Name = "cmb_shipmethod";
            this.cmb_shipmethod.Size = new System.Drawing.Size(185, 21);
            this.cmb_shipmethod.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Taşıma Şeklii(ShipMethodID)";
            // 
            // cmb_CreditCard
            // 
            this.cmb_CreditCard.FormattingEnabled = true;
            this.cmb_CreditCard.Location = new System.Drawing.Point(164, 84);
            this.cmb_CreditCard.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_CreditCard.Name = "cmb_CreditCard";
            this.cmb_CreditCard.Size = new System.Drawing.Size(151, 21);
            this.cmb_CreditCard.TabIndex = 2;
            this.cmb_CreditCard.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Kredi Kartı (CrediCardID)";
            // 
            // cmb_CurrencyRate
            // 
            this.cmb_CurrencyRate.FormattingEnabled = true;
            this.cmb_CurrencyRate.Location = new System.Drawing.Point(164, 108);
            this.cmb_CurrencyRate.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_CurrencyRate.Name = "cmb_CurrencyRate";
            this.cmb_CurrencyRate.Size = new System.Drawing.Size(151, 21);
            this.cmb_CurrencyRate.TabIndex = 2;
            this.cmb_CurrencyRate.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 110);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Döviz Kuru (CurrencyRateID)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 117);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Ara Toplam (SubTotal)";
            // 
            // lbl_SubTotal
            // 
            this.lbl_SubTotal.AutoSize = true;
            this.lbl_SubTotal.Location = new System.Drawing.Point(486, 117);
            this.lbl_SubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SubTotal.Name = "lbl_SubTotal";
            this.lbl_SubTotal.Size = new System.Drawing.Size(37, 13);
            this.lbl_SubTotal.TabIndex = 5;
            this.lbl_SubTotal.Text = "00000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(328, 139);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Vergiler (TaxAmount)";
            // 
            // lbl_TaxAmount
            // 
            this.lbl_TaxAmount.AutoSize = true;
            this.lbl_TaxAmount.Location = new System.Drawing.Point(486, 139);
            this.lbl_TaxAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TaxAmount.Name = "lbl_TaxAmount";
            this.lbl_TaxAmount.Size = new System.Drawing.Size(81, 13);
            this.lbl_TaxAmount.TabIndex = 5;
            this.lbl_TaxAmount.Text = "SubTotal * 0,18";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(328, 157);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Nakliye Ücreti (Freight)";
            // 
            // lbl_freight
            // 
            this.lbl_freight.AutoSize = true;
            this.lbl_freight.Location = new System.Drawing.Point(486, 157);
            this.lbl_freight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_freight.Name = "lbl_freight";
            this.lbl_freight.Size = new System.Drawing.Size(75, 13);
            this.lbl_freight.TabIndex = 5;
            this.lbl_freight.Text = "SubTotal * 0,1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(328, 175);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Toplam Tutar";
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.Location = new System.Drawing.Point(486, 175);
            this.lbl_toplam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(155, 13);
            this.lbl_toplam.TabIndex = 5;
            this.lbl_toplam.Text = "Ara Toplam + Vergiler + Nakliye";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(562, 436);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sipariş Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_comment
            // 
            this.txt_comment.Location = new System.Drawing.Point(164, 139);
            this.txt_comment.Margin = new System.Windows.Forms.Padding(2);
            this.txt_comment.Multiline = true;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(151, 50);
            this.txt_comment.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 141);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Açıklama (Comment)";
            // 
            // frm_YeniSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 472);
            this.Controls.Add(this.txt_comment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_toplam);
            this.Controls.Add(this.lbl_freight);
            this.Controls.Add(this.lbl_TaxAmount);
            this.Controls.Add(this.lbl_SubTotal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_CurrencyRate);
            this.Controls.Add(this.cmb_CreditCard);
            this.Controls.Add(this.lbl_musteriadi);
            this.Controls.Add(this.cmb_shipmethod);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.cmb_shippingAdress);
            this.Controls.Add(this.cmb_billaddress);
            this.Controls.Add(this.cmb_Territory);
            this.Controls.Add(this.cmb_salesperson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_urunlistesi);
            this.Name = "frm_YeniSiparis";
            this.Text = "frm_YeniSiparis";
            this.Load += new System.EventHandler(this.frm_YeniSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunlistesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_urunlistesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_salesperson;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Label lbl_musteriadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Territory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_billaddress;
        private System.Windows.Forms.ComboBox cmb_shippingAdress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_shipmethod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_CreditCard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_CurrencyRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_SubTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_TaxAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_freight;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_toplam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.Label label19;
    }
}