namespace Iskur_EF.UI.Win
{
    partial class dlg_MüsteriDetay
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
            this.dgv_MüsteriListele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MüsteriListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_MüsteriListele
            // 
            this.dgv_MüsteriListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MüsteriListele.Location = new System.Drawing.Point(12, 42);
            this.dgv_MüsteriListele.Name = "dgv_MüsteriListele";
            this.dgv_MüsteriListele.Size = new System.Drawing.Size(538, 245);
            this.dgv_MüsteriListele.TabIndex = 0;
            // 
            // dlg_MüsteriDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 299);
            this.Controls.Add(this.dgv_MüsteriListele);
            this.Name = "dlg_MüsteriDetay";
            this.Text = "dlg_MüsteriDetay";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MüsteriListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_MüsteriListele;
    }
}