namespace Iskur_EF.UI.Win
{
    partial class SiparisEkle
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
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.dgv_Products = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(265, 392);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(229, 46);
            this.btn_Ekle.TabIndex = 2;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // dgv_Products
            // 
            this.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Products.Location = new System.Drawing.Point(12, 12);
            this.dgv_Products.Name = "dgv_Products";
            this.dgv_Products.Size = new System.Drawing.Size(776, 359);
            this.dgv_Products.TabIndex = 3;
            // 
            // SiparisEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Products);
            this.Controls.Add(this.btn_Ekle);
            this.Name = "SiparisEkle";
            this.Text = "SiparisEkle";
            this.Load += new System.EventHandler(this.SiparisEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.DataGridView dgv_Products;
    }
}