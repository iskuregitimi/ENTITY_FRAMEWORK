namespace Iskur_EF.UI.Win
{
    partial class SiparisDetayi
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
            this.dgv_SiparisDetayi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SiparisDetayi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_SiparisDetayi
            // 
            this.dgv_SiparisDetayi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_SiparisDetayi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SiparisDetayi.Location = new System.Drawing.Point(12, 12);
            this.dgv_SiparisDetayi.Name = "dgv_SiparisDetayi";
            this.dgv_SiparisDetayi.Size = new System.Drawing.Size(776, 426);
            this.dgv_SiparisDetayi.TabIndex = 0;
            // 
            // SiparisDetayi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_SiparisDetayi);
            this.Name = "SiparisDetayi";
            this.Text = "SiparisDetayi";
            this.Load += new System.EventHandler(this.SiparisDetayi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SiparisDetayi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SiparisDetayi;
    }
}