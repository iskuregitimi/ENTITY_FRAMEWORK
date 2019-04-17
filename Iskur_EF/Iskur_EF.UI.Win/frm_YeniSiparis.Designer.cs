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
            this.dgv_urunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_salesPerson = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_teriotry = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_biltoAddress = new System.Windows.Forms.ComboBox();
            this.cmb_shipAdress = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_shipMetod = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_credıtCart = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_currency = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_subTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_toplamtutar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_urunler
            // 
            this.dgv_urunler.AllowUserToAddRows = false;
            this.dgv_urunler.AllowUserToDeleteRows = false;
            this.dgv_urunler.AllowUserToOrderColumns = true;
            this.dgv_urunler.AllowUserToResizeRows = false;
            this.dgv_urunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_urunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_urunler.Location = new System.Drawing.Point(10, 202);
            this.dgv_urunler.Name = "dgv_urunler";
            this.dgv_urunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_urunler.Size = new System.Drawing.Size(657, 222);
            this.dgv_urunler.TabIndex = 0;
            this.dgv_urunler.DoubleClick += new System.EventHandler(this.dgv_urunler_DoubleClick);
            this.dgv_urunler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_urunler_MouseDoubleClick);
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
            // cmb_salesPerson
            // 
            this.cmb_salesPerson.FormattingEnabled = true;
            this.cmb_salesPerson.Location = new System.Drawing.Point(164, 59);
            this.cmb_salesPerson.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_salesPerson.Name = "cmb_salesPerson";
            this.cmb_salesPerson.Size = new System.Drawing.Size(151, 21);
            this.cmb_salesPerson.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 37);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
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
            // cmb_teriotry
            // 
            this.cmb_teriotry.Location = new System.Drawing.Point(483, 18);
            this.cmb_teriotry.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_teriotry.Name = "cmb_teriotry";
            this.cmb_teriotry.Size = new System.Drawing.Size(185, 21);
            this.cmb_teriotry.TabIndex = 2;
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
            // cmb_biltoAddress
            // 
            this.cmb_biltoAddress.FormattingEnabled = true;
            this.cmb_biltoAddress.Location = new System.Drawing.Point(483, 40);
            this.cmb_biltoAddress.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_biltoAddress.Name = "cmb_biltoAddress";
            this.cmb_biltoAddress.Size = new System.Drawing.Size(185, 21);
            this.cmb_biltoAddress.TabIndex = 2;
            // 
            // cmb_shipAdress
            // 
            this.cmb_shipAdress.FormattingEnabled = true;
            this.cmb_shipAdress.Location = new System.Drawing.Point(483, 64);
            this.cmb_shipAdress.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_shipAdress.Name = "cmb_shipAdress";
            this.cmb_shipAdress.Size = new System.Drawing.Size(185, 21);
            this.cmb_shipAdress.TabIndex = 2;
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
            // cmb_shipMetod
            // 
            this.cmb_shipMetod.FormattingEnabled = true;
            this.cmb_shipMetod.Location = new System.Drawing.Point(483, 90);
            this.cmb_shipMetod.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_shipMetod.Name = "cmb_shipMetod";
            this.cmb_shipMetod.Size = new System.Drawing.Size(185, 21);
            this.cmb_shipMetod.TabIndex = 2;
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
            // cmb_credıtCart
            // 
            this.cmb_credıtCart.FormattingEnabled = true;
            this.cmb_credıtCart.Location = new System.Drawing.Point(164, 84);
            this.cmb_credıtCart.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_credıtCart.Name = "cmb_credıtCart";
            this.cmb_credıtCart.Size = new System.Drawing.Size(151, 21);
            this.cmb_credıtCart.TabIndex = 2;
            this.cmb_credıtCart.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
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
            // cmb_currency
            // 
            this.cmb_currency.FormattingEnabled = true;
            this.cmb_currency.Location = new System.Drawing.Point(164, 108);
            this.cmb_currency.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_currency.Name = "cmb_currency";
            this.cmb_currency.Size = new System.Drawing.Size(151, 21);
            this.cmb_currency.TabIndex = 2;
            this.cmb_currency.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
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
            // lbl_subTotal
            // 
            this.lbl_subTotal.AutoSize = true;
            this.lbl_subTotal.Location = new System.Drawing.Point(486, 117);
            this.lbl_subTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_subTotal.Name = "lbl_subTotal";
            this.lbl_subTotal.Size = new System.Drawing.Size(37, 13);
            this.lbl_subTotal.TabIndex = 5;
            this.lbl_subTotal.Text = "00000";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(486, 139);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "SubTotal * 0,18";
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(486, 157);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "SubTotal * 0,1";
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 139);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 50);
            this.textBox1.TabIndex = 7;
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
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_toplamtutar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_subTotal);
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
            this.Controls.Add(this.cmb_currency);
            this.Controls.Add(this.cmb_credıtCart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_shipMetod);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmb_shipAdress);
            this.Controls.Add(this.cmb_biltoAddress);
            this.Controls.Add(this.cmb_teriotry);
            this.Controls.Add(this.cmb_salesPerson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_urunler);
            this.Name = "frm_YeniSiparis";
            this.Text = "frm_YeniSiparis";
            this.Load += new System.EventHandler(this.frm_YeniSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_urunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_salesPerson;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_teriotry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_biltoAddress;
        private System.Windows.Forms.ComboBox cmb_shipAdress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_shipMetod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_credıtCart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_currency;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_subTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_toplamtutar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label19;
    }
}