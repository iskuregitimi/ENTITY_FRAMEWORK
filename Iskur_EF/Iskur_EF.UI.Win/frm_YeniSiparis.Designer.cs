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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_LineTotal = new System.Windows.Forms.Label();
            this.lbl_Freight = new System.Windows.Forms.Label();
            this.lbl_TaxAmount = new System.Windows.Forms.Label();
            this.lbl_SubTotal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_CurrencyRate = new System.Windows.Forms.ComboBox();
            this.cmb_CrediCard = new System.Windows.Forms.ComboBox();
            this.lbl_customerName = new System.Windows.Forms.Label();
            this.cmb_ShipMethod = new System.Windows.Forms.ComboBox();
            this.dtm_ShipDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_ShiptoAddress = new System.Windows.Forms.ComboBox();
            this.cmb_BilltoAddress = new System.Windows.Forms.ComboBox();
            this.cmb_Territory = new System.Windows.Forms.ComboBox();
            this.cmb_SatisPersoneli = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 138);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 50);
            this.textBox1.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(600, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 24);
            this.button1.TabIndex = 36;
            this.button1.Text = "Sipariş Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbl_LineTotal
            // 
            this.lbl_LineTotal.AutoSize = true;
            this.lbl_LineTotal.Location = new System.Drawing.Point(524, 174);
            this.lbl_LineTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LineTotal.Name = "lbl_LineTotal";
            this.lbl_LineTotal.Size = new System.Drawing.Size(155, 13);
            this.lbl_LineTotal.TabIndex = 34;
            this.lbl_LineTotal.Text = "Ara Toplam + Vergiler + Nakliye";
            // 
            // lbl_Freight
            // 
            this.lbl_Freight.AutoSize = true;
            this.lbl_Freight.Location = new System.Drawing.Point(524, 156);
            this.lbl_Freight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Freight.Name = "lbl_Freight";
            this.lbl_Freight.Size = new System.Drawing.Size(75, 13);
            this.lbl_Freight.TabIndex = 33;
            this.lbl_Freight.Text = "SubTotal * 0,1";
            // 
            // lbl_TaxAmount
            // 
            this.lbl_TaxAmount.AutoSize = true;
            this.lbl_TaxAmount.Location = new System.Drawing.Point(524, 138);
            this.lbl_TaxAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TaxAmount.Name = "lbl_TaxAmount";
            this.lbl_TaxAmount.Size = new System.Drawing.Size(81, 13);
            this.lbl_TaxAmount.TabIndex = 32;
            this.lbl_TaxAmount.Text = "SubTotal * 0,18";
            // 
            // lbl_SubTotal
            // 
            this.lbl_SubTotal.AutoSize = true;
            this.lbl_SubTotal.Location = new System.Drawing.Point(524, 116);
            this.lbl_SubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SubTotal.Name = "lbl_SubTotal";
            this.lbl_SubTotal.Size = new System.Drawing.Size(31, 13);
            this.lbl_SubTotal.TabIndex = 31;
            this.lbl_SubTotal.Text = "0000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(366, 174);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Toplam Tutar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(366, 156);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Nakliye Ücreti (Freight)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(366, 138);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Vergiler (TaxAmount)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(366, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Ara Toplam (SubTotal)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(58, 140);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "Açıklama (Comment)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 109);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Döviz Kuru (CurrencyRateID)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Kredi Kartı (CrediCardID)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Taşıma Şeklii(ShipMethodID)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Teslimat Adresi(ShipToAddress)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fatura Adresi(BillToAddress)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Bölge (TerritoryID)";
            // 
            // cmb_CurrencyRate
            // 
            this.cmb_CurrencyRate.FormattingEnabled = true;
            this.cmb_CurrencyRate.Location = new System.Drawing.Point(202, 107);
            this.cmb_CurrencyRate.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_CurrencyRate.Name = "cmb_CurrencyRate";
            this.cmb_CurrencyRate.Size = new System.Drawing.Size(151, 21);
            this.cmb_CurrencyRate.TabIndex = 18;
            // 
            // cmb_CrediCard
            // 
            this.cmb_CrediCard.FormattingEnabled = true;
            this.cmb_CrediCard.Location = new System.Drawing.Point(202, 83);
            this.cmb_CrediCard.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_CrediCard.Name = "cmb_CrediCard";
            this.cmb_CrediCard.Size = new System.Drawing.Size(151, 21);
            this.cmb_CrediCard.TabIndex = 17;
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.AutoSize = true;
            this.lbl_customerName.Location = new System.Drawing.Point(199, 17);
            this.lbl_customerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_customerName.Name = "lbl_customerName";
            this.lbl_customerName.Size = new System.Drawing.Size(35, 13);
            this.lbl_customerName.TabIndex = 20;
            this.lbl_customerName.Text = "label4";
            // 
            // cmb_ShipMethod
            // 
            this.cmb_ShipMethod.FormattingEnabled = true;
            this.cmb_ShipMethod.Location = new System.Drawing.Point(521, 89);
            this.cmb_ShipMethod.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_ShipMethod.Name = "cmb_ShipMethod";
            this.cmb_ShipMethod.Size = new System.Drawing.Size(185, 21);
            this.cmb_ShipMethod.TabIndex = 16;
            // 
            // dtm_ShipDate
            // 
            this.dtm_ShipDate.Location = new System.Drawing.Point(202, 36);
            this.dtm_ShipDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtm_ShipDate.Name = "dtm_ShipDate";
            this.dtm_ShipDate.Size = new System.Drawing.Size(151, 20);
            this.dtm_ShipDate.TabIndex = 19;
            // 
            // cmb_ShiptoAddress
            // 
            this.cmb_ShiptoAddress.FormattingEnabled = true;
            this.cmb_ShiptoAddress.Location = new System.Drawing.Point(521, 63);
            this.cmb_ShiptoAddress.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_ShiptoAddress.Name = "cmb_ShiptoAddress";
            this.cmb_ShiptoAddress.Size = new System.Drawing.Size(185, 21);
            this.cmb_ShiptoAddress.TabIndex = 15;
            // 
            // cmb_BilltoAddress
            // 
            this.cmb_BilltoAddress.FormattingEnabled = true;
            this.cmb_BilltoAddress.Location = new System.Drawing.Point(521, 39);
            this.cmb_BilltoAddress.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_BilltoAddress.Name = "cmb_BilltoAddress";
            this.cmb_BilltoAddress.Size = new System.Drawing.Size(185, 21);
            this.cmb_BilltoAddress.TabIndex = 14;
            // 
            // cmb_Territory
            // 
            this.cmb_Territory.FormattingEnabled = true;
            this.cmb_Territory.Location = new System.Drawing.Point(521, 17);
            this.cmb_Territory.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Territory.Name = "cmb_Territory";
            this.cmb_Territory.Size = new System.Drawing.Size(185, 21);
            this.cmb_Territory.TabIndex = 13;
            // 
            // cmb_SatisPersoneli
            // 
            this.cmb_SatisPersoneli.FormattingEnabled = true;
            this.cmb_SatisPersoneli.Location = new System.Drawing.Point(202, 58);
            this.cmb_SatisPersoneli.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_SatisPersoneli.Name = "cmb_SatisPersoneli";
            this.cmb_SatisPersoneli.Size = new System.Drawing.Size(151, 21);
            this.cmb_SatisPersoneli.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Satış Personeli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kargo Tarihi (ShipDate)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Müşteri Adı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(658, 229);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frm_YeniSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 476);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_LineTotal);
            this.Controls.Add(this.lbl_Freight);
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
            this.Controls.Add(this.cmb_CrediCard);
            this.Controls.Add(this.lbl_customerName);
            this.Controls.Add(this.cmb_ShipMethod);
            this.Controls.Add(this.dtm_ShipDate);
            this.Controls.Add(this.cmb_ShiptoAddress);
            this.Controls.Add(this.cmb_BilltoAddress);
            this.Controls.Add(this.cmb_Territory);
            this.Controls.Add(this.cmb_SatisPersoneli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_YeniSiparis";
            this.Text = "frm_YeniSiparis";
            this.Load += new System.EventHandler(this.frm_YeniSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_LineTotal;
        private System.Windows.Forms.Label lbl_Freight;
        private System.Windows.Forms.Label lbl_TaxAmount;
        private System.Windows.Forms.Label lbl_SubTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_CurrencyRate;
        private System.Windows.Forms.ComboBox cmb_CrediCard;
        private System.Windows.Forms.Label lbl_customerName;
        private System.Windows.Forms.ComboBox cmb_ShipMethod;
        private System.Windows.Forms.DateTimePicker dtm_ShipDate;
        private System.Windows.Forms.ComboBox cmb_ShiptoAddress;
        private System.Windows.Forms.ComboBox cmb_BilltoAddress;
        private System.Windows.Forms.ComboBox cmb_Territory;
        private System.Windows.Forms.ComboBox cmb_SatisPersoneli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}