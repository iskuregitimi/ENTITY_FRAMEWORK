namespace Iskur_EF.UI.Win
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
            this.dvg_showproducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbx_salesperson = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_musteriadi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbx_territory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbx_bill = new System.Windows.Forms.ComboBox();
            this.cmbx_shipadres = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbx_shipmethodid = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_credit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbx_currency = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_nakliye = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_toplamtutar = new System.Windows.Forms.Label();
            this.btn_siparisekle = new System.Windows.Forms.Button();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_showproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_showproducts
            // 
            this.dvg_showproducts.AllowUserToAddRows = false;
            this.dvg_showproducts.AllowUserToDeleteRows = false;
            this.dvg_showproducts.AllowUserToOrderColumns = true;
            this.dvg_showproducts.AllowUserToResizeRows = false;
            this.dvg_showproducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvg_showproducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg_showproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_showproducts.Location = new System.Drawing.Point(10, 202);
            this.dvg_showproducts.Name = "dvg_showproducts";
            this.dvg_showproducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvg_showproducts.Size = new System.Drawing.Size(657, 222);
            this.dvg_showproducts.TabIndex = 0;
            this.dvg_showproducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_showproducts_CellContentClick);
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
            // cmbx_salesperson
            // 
            this.cmbx_salesperson.FormattingEnabled = true;
            this.cmbx_salesperson.Location = new System.Drawing.Point(164, 59);
            this.cmbx_salesperson.Margin = new System.Windows.Forms.Padding(2);
            this.cmbx_salesperson.Name = "cmbx_salesperson";
            this.cmbx_salesperson.Size = new System.Drawing.Size(151, 21);
            this.cmbx_salesperson.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 37);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 3;
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
            // cmbx_territory
            // 
            this.cmbx_territory.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbx_territory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbx_territory.FormattingEnabled = true;
            this.cmbx_territory.Location = new System.Drawing.Point(483, 18);
            this.cmbx_territory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbx_territory.Name = "cmbx_territory";
            this.cmbx_territory.Size = new System.Drawing.Size(185, 21);
            this.cmbx_territory.TabIndex = 2;
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
            // cmbx_bill
            // 
            this.cmbx_bill.FormattingEnabled = true;
            this.cmbx_bill.Location = new System.Drawing.Point(483, 40);
            this.cmbx_bill.Margin = new System.Windows.Forms.Padding(2);
            this.cmbx_bill.Name = "cmbx_bill";
            this.cmbx_bill.Size = new System.Drawing.Size(185, 21);
            this.cmbx_bill.TabIndex = 2;
            // 
            // cmbx_shipadres
            // 
            this.cmbx_shipadres.FormattingEnabled = true;
            this.cmbx_shipadres.Location = new System.Drawing.Point(483, 64);
            this.cmbx_shipadres.Margin = new System.Windows.Forms.Padding(2);
            this.cmbx_shipadres.Name = "cmbx_shipadres";
            this.cmbx_shipadres.Size = new System.Drawing.Size(185, 21);
            this.cmbx_shipadres.TabIndex = 2;
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
            // cmbx_shipmethodid
            // 
            this.cmbx_shipmethodid.FormattingEnabled = true;
            this.cmbx_shipmethodid.Location = new System.Drawing.Point(483, 90);
            this.cmbx_shipmethodid.Margin = new System.Windows.Forms.Padding(2);
            this.cmbx_shipmethodid.Name = "cmbx_shipmethodid";
            this.cmbx_shipmethodid.Size = new System.Drawing.Size(185, 21);
            this.cmbx_shipmethodid.TabIndex = 2;
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
            // cmb_credit
            // 
            this.cmb_credit.FormattingEnabled = true;
            this.cmb_credit.Location = new System.Drawing.Point(164, 84);
            this.cmb_credit.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_credit.Name = "cmb_credit";
            this.cmb_credit.Size = new System.Drawing.Size(151, 21);
            this.cmb_credit.TabIndex = 2;
            this.cmb_credit.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
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
            // cmbx_currency
            // 
            this.cmbx_currency.FormattingEnabled = true;
            this.cmbx_currency.Location = new System.Drawing.Point(164, 108);
            this.cmbx_currency.Margin = new System.Windows.Forms.Padding(2);
            this.cmbx_currency.Name = "cmbx_currency";
            this.cmbx_currency.Size = new System.Drawing.Size(151, 21);
            this.cmbx_currency.TabIndex = 2;
            this.cmbx_currency.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
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
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Location = new System.Drawing.Point(486, 117);
            this.lbl_subtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(37, 13);
            this.lbl_subtotal.TabIndex = 5;
            this.lbl_subtotal.Text = "00000";
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
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Location = new System.Drawing.Point(486, 139);
            this.lbl_tax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(71, 13);
            this.lbl_tax.TabIndex = 5;
            this.lbl_tax.Text = "Subtotal*0.18";
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
            // lbl_nakliye
            // 
            this.lbl_nakliye.AutoSize = true;
            this.lbl_nakliye.Location = new System.Drawing.Point(486, 157);
            this.lbl_nakliye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nakliye.Name = "lbl_nakliye";
            this.lbl_nakliye.Size = new System.Drawing.Size(75, 13);
            this.lbl_nakliye.TabIndex = 5;
            this.lbl_nakliye.Text = "SubTotal * 0,1";
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
            // lbl_toplamtutar
            // 
            this.lbl_toplamtutar.AutoSize = true;
            this.lbl_toplamtutar.Location = new System.Drawing.Point(486, 175);
            this.lbl_toplamtutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_toplamtutar.Name = "lbl_toplamtutar";
            this.lbl_toplamtutar.Size = new System.Drawing.Size(155, 13);
            this.lbl_toplamtutar.TabIndex = 5;
            this.lbl_toplamtutar.Text = "Ara Toplam + Vergiler + Nakliye";
            this.lbl_toplamtutar.Click += new System.EventHandler(this.lbl_toplamtutar_Click);
            // 
            // btn_siparisekle
            // 
            this.btn_siparisekle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_siparisekle.Location = new System.Drawing.Point(562, 436);
            this.btn_siparisekle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_siparisekle.Name = "btn_siparisekle";
            this.btn_siparisekle.Size = new System.Drawing.Size(105, 24);
            this.btn_siparisekle.TabIndex = 6;
            this.btn_siparisekle.Text = "Sipariş Ekle";
            this.btn_siparisekle.UseVisualStyleBackColor = true;
            this.btn_siparisekle.Click += new System.EventHandler(this.button1_Click);
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
            this.Controls.Add(this.btn_siparisekle);
            this.Controls.Add(this.lbl_toplamtutar);
            this.Controls.Add(this.lbl_nakliye);
            this.Controls.Add(this.lbl_tax);
            this.Controls.Add(this.lbl_subtotal);
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
            this.Controls.Add(this.cmbx_currency);
            this.Controls.Add(this.cmb_credit);
            this.Controls.Add(this.lbl_musteriadi);
            this.Controls.Add(this.cmbx_shipmethodid);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbx_shipadres);
            this.Controls.Add(this.cmbx_bill);
            this.Controls.Add(this.cmbx_territory);
            this.Controls.Add(this.cmbx_salesperson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvg_showproducts);
            this.Name = "frm_YeniSiparis";
            this.Text = "frm_YeniSiparis";
            this.Load += new System.EventHandler(this.frm_YeniSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_showproducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg_showproducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbx_salesperson;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_musteriadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbx_territory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbx_bill;
        private System.Windows.Forms.ComboBox cmbx_shipadres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbx_shipmethodid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_credit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbx_currency;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_nakliye;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_toplamtutar;
        private System.Windows.Forms.Button btn_siparisekle;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.Label label19;
    }
}