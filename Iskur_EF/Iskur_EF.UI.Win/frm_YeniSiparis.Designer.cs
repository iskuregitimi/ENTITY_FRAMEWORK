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
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSalesPersons = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTerritory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBilltoAdress = new System.Windows.Forms.ComboBox();
            this.cmbShiptoAddress = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbShipMethod = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCreditCards = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCurrencyRate = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblFreight = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.AllowUserToOrderColumns = true;
            this.dgvUrunler.AllowUserToResizeRows = false;
            this.dgvUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(10, 202);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(657, 222);
            this.dgvUrunler.TabIndex = 0;
            this.dgvUrunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellContentClick);
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
            // 
            // cmbSalesPersons
            // 
            this.cmbSalesPersons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesPersons.FormattingEnabled = true;
            this.cmbSalesPersons.Location = new System.Drawing.Point(164, 59);
            this.cmbSalesPersons.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSalesPersons.Name = "cmbSalesPersons";
            this.cmbSalesPersons.Size = new System.Drawing.Size(151, 21);
            this.cmbSalesPersons.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 37);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(161, 18);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "label4";
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
            // cmbTerritory
            // 
            this.cmbTerritory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerritory.FormattingEnabled = true;
            this.cmbTerritory.Location = new System.Drawing.Point(483, 18);
            this.cmbTerritory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTerritory.Name = "cmbTerritory";
            this.cmbTerritory.Size = new System.Drawing.Size(185, 21);
            this.cmbTerritory.TabIndex = 2;
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
            // cmbBilltoAdress
            // 
            this.cmbBilltoAdress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBilltoAdress.FormattingEnabled = true;
            this.cmbBilltoAdress.Location = new System.Drawing.Point(483, 42);
            this.cmbBilltoAdress.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBilltoAdress.Name = "cmbBilltoAdress";
            this.cmbBilltoAdress.Size = new System.Drawing.Size(185, 21);
            this.cmbBilltoAdress.TabIndex = 2;
            // 
            // cmbShiptoAddress
            // 
            this.cmbShiptoAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShiptoAddress.FormattingEnabled = true;
            this.cmbShiptoAddress.Location = new System.Drawing.Point(483, 66);
            this.cmbShiptoAddress.Margin = new System.Windows.Forms.Padding(2);
            this.cmbShiptoAddress.Name = "cmbShiptoAddress";
            this.cmbShiptoAddress.Size = new System.Drawing.Size(185, 21);
            this.cmbShiptoAddress.TabIndex = 2;
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
            // cmbShipMethod
            // 
            this.cmbShipMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShipMethod.FormattingEnabled = true;
            this.cmbShipMethod.Location = new System.Drawing.Point(483, 90);
            this.cmbShipMethod.Margin = new System.Windows.Forms.Padding(2);
            this.cmbShipMethod.Name = "cmbShipMethod";
            this.cmbShipMethod.Size = new System.Drawing.Size(185, 21);
            this.cmbShipMethod.TabIndex = 2;
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
            // cmbCreditCards
            // 
            this.cmbCreditCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreditCards.FormattingEnabled = true;
            this.cmbCreditCards.Location = new System.Drawing.Point(164, 84);
            this.cmbCreditCards.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCreditCards.Name = "cmbCreditCards";
            this.cmbCreditCards.Size = new System.Drawing.Size(151, 21);
            this.cmbCreditCards.TabIndex = 2;
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
            // cmbCurrencyRate
            // 
            this.cmbCurrencyRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrencyRate.FormattingEnabled = true;
            this.cmbCurrencyRate.Location = new System.Drawing.Point(164, 108);
            this.cmbCurrencyRate.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCurrencyRate.Name = "cmbCurrencyRate";
            this.cmbCurrencyRate.Size = new System.Drawing.Size(151, 21);
            this.cmbCurrencyRate.TabIndex = 2;
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
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(486, 114);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(37, 13);
            this.lblSubTotal.TabIndex = 5;
            this.lblSubTotal.Text = "00000";
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
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(486, 139);
            this.lblTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(37, 13);
            this.lblTax.TabIndex = 5;
            this.lblTax.Text = "00000";
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
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.Location = new System.Drawing.Point(486, 157);
            this.lblFreight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(37, 13);
            this.lblFreight.TabIndex = 5;
            this.lblFreight.Text = "00000";
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
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(486, 175);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(37, 13);
            this.lblTotalAmount.TabIndex = 5;
            this.lblTotalAmount.Text = "00000";
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
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(164, 139);
            this.txtComment.Margin = new System.Windows.Forms.Padding(2);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(151, 50);
            this.txtComment.TabIndex = 7;
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
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblFreight);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
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
            this.Controls.Add(this.cmbCurrencyRate);
            this.Controls.Add(this.cmbCreditCards);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.cmbShipMethod);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbShiptoAddress);
            this.Controls.Add(this.cmbBilltoAdress);
            this.Controls.Add(this.cmbTerritory);
            this.Controls.Add(this.cmbSalesPersons);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUrunler);
            this.Name = "frm_YeniSiparis";
            this.Text = "frm_YeniSiparis";
            this.Load += new System.EventHandler(this.frm_YeniSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSalesPersons;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTerritory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBilltoAdress;
        private System.Windows.Forms.ComboBox cmbShiptoAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbShipMethod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCreditCards;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCurrencyRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblFreight;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label19;
    }
}