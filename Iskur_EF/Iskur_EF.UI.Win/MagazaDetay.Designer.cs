namespace Iskur_EF.UI.Win
{
    partial class MagazaDetay
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
            this.dgvPersonelDetay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonelDetay
            // 
            this.dgvPersonelDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonelDetay.Location = new System.Drawing.Point(51, 143);
            this.dgvPersonelDetay.Name = "dgvPersonelDetay";
            this.dgvPersonelDetay.Size = new System.Drawing.Size(716, 193);
            this.dgvPersonelDetay.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "FirstName";
            // 
            // MagazaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPersonelDetay);
            this.Controls.Add(this.label1);
            this.Name = "MagazaDetay";
            this.Text = "MagazaDetay";
            this.Load += new System.EventHandler(this.MagazaDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonelDetay;
        private System.Windows.Forms.Label label1;
    }
}