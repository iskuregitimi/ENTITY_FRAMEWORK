namespace Iskur_EF.UI.Win
{
    partial class dlg_Siparisler
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
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.AllowUserToAddRows = false;
            this.dgvSiparisler.AllowUserToDeleteRows = false;
            this.dgvSiparisler.AllowUserToOrderColumns = true;
            this.dgvSiparisler.AllowUserToResizeRows = false;
            this.dgvSiparisler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(12, 12);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisler.Size = new System.Drawing.Size(627, 325);
            this.dgvSiparisler.TabIndex = 0;
            // 
            // dlg_Siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 349);
            this.Controls.Add(this.dgvSiparisler);
            this.Name = "dlg_Siparisler";
            this.Text = "dlg_Siparisler";
            this.Load += new System.EventHandler(this.dlg_Siparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisler;
    }
}