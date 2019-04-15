namespace Iskur_EF.UI.Win
{
    partial class frm_MusteriListesi
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
            this.dgv_MusteriListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MusteriListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_MusteriListesi
            // 
            this.dgv_MusteriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MusteriListesi.Location = new System.Drawing.Point(13, 13);
            this.dgv_MusteriListesi.Name = "dgv_MusteriListesi";
            this.dgv_MusteriListesi.Size = new System.Drawing.Size(775, 425);
            this.dgv_MusteriListesi.TabIndex = 0;
            // 
            // frm_MusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_MusteriListesi);
            this.Name = "frm_MusteriListesi";
            this.Text = "frm_MusteriListesi";
            this.Load += new System.EventHandler(this.frm_MusteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MusteriListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_MusteriListesi;
    }
}